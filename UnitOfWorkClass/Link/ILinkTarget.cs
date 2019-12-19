using System.Collections.Generic;

namespace UnitOfWorkClass.Link
{
    // Получатель изменений состояния
    public interface ILinkTarget
    {
        void Update(int commandId, Dictionary<string, object> parameters);
    }
}
