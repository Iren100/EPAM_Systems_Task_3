using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkClass.Link;

namespace AutomaticStation
{
    public class Terminal//: ILinkTarget
    {
        private int Id;

        private Port activePort;


        //объявление событий Event Hundler




        //delegate void call(); //метод
        //event call Notify; // событие   

        //public void Update(int commandId, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}


        //подписка
        public void SubscribeToPort(int portId)
        {

        }

        //отписка
        public void UnsubscribeFromPort(int portId)
        {

        }

        //подключение к порту
        public void ConnectTjPort(Terminal terminal)
        {
            SubscribeToPort(this.Id);
        }

        //отключение от порта
        public void DisconnectFromPort(Terminal terminal)
        {
            UnsubscribeFromPort(this.Id);
        }
    }
}
