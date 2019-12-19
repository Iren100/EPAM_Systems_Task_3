using System;
using System.Collections.Generic;
using System.Linq;

namespace UnitOfWorkClass.Link
{
    // Связывает между собой объекты, предлагает оповещать одни объекты об изменении состояния других
    public class Linker : IDisposable
    {
        private static Linker _instance;
        private readonly List<Tuple<ILinkSource, ILinkTarget>> _links;

        public static Linker Instance
        {
            get { return _instance ?? (_instance = new Linker()); }
        }

        public Linker()
        {
            _links = new List<Tuple<ILinkSource, ILinkTarget>>();
        }

        public bool IsSource(object item)
        {
            if (item is ILinkSource)
                return _links.Any(i => i.Item1.Equals(item));
            return false;
        }

        public bool IsTarget(object item)
        {
            if (item is ILinkTarget)
                return _links.Any(i => i.Item2.Equals(item));
            return false;
        }

        // Регистрирует пару "объект-наблюдатель"
        public void Register(ILinkSource source, ILinkTarget target)
        {
            if (source == null || target == null || _links.Any(l => l.Item1.Equals(source) && l.Item2.Equals(target)))
                return;

            _links.Add(new Tuple<ILinkSource, ILinkTarget>(source, target));
        }

        // Отключает наблюдателей от источника
        public void Unregister(object source)
        {
            if (source is ILinkSource)
                _links.RemoveAll(l => l.Item1.Equals(source as ILinkSource));
            else if (source is ILinkTarget)
                _links.RemoveAll(l => l.Item2.Equals(source as ILinkTarget));
        }

        // Запускает обновление наблюдателям
        public void Notify(ILinkSource source, int commandId, Dictionary<string, object> parameters)
        {
            if (source == null)
                return;

            foreach (var link in _links.Where(l => l.Item1.Equals(source)).ToList())
            {
                link.Item2.Update(commandId, parameters);
            }
        }

        // Уведомление конкретного получателя
        public void Notify<TTarget>(ILinkSource source, int commandId, Dictionary<string, object> parameters)
        {
            var target = _links.FirstOrDefault(l => l.Item1.Equals(source) && l.Item2.GetType() == typeof(TTarget));
            if (target == null)
                return;
            target.Item2.Update(commandId, parameters);
        }

        public object GetState(ILinkTarget target, ILinkSource source)
        {
            if (target == null || source == null)
                return null;

            var link = _links.FirstOrDefault(l => l.Item1.Equals(source) && l.Item2.Equals(target));
            return link == null ? null : link.Item1.GetState();
        }

        // Получает данные от источника определенного типа
        public object GetState<T>(ILinkTarget target)
        {
            if (target == null)
                return null;

            var link = _links.FirstOrDefault(l => l.Item1 is T && l.Item2.Equals(target));
            return link == null ? null : link.Item1.GetState();
        }

        // Получает данные от источника определенного типа вне зависимости от существования связи между объектами
        public object GetState<T>()
        {
            var link = _links.FirstOrDefault(l => l.Item1 is T);
            return link == null ? null : link.Item1.GetState();
        }

        public void Dispose()
        {
            foreach (var link in _links)
            {
                Unregister(link.Item1);
                Unregister(link.Item2);
            }
        }
    }

    // Для облегчения доступа к методам
    public static class ObjectLinkerExtensions
    {
        public static void NotifyTargets(this ILinkSource source, int commandId, Dictionary<string, object> parameters)
        {
            Linker.Instance.Notify(source, commandId, parameters);
        }

        public static void UnregisterLink(this ILinkSource source)
        {
            Linker.Instance.Unregister(source);
        }

        public static void UnregisterLink(this ILinkTarget target)
        {
            Linker.Instance.Unregister(target);
        }
    }
}
