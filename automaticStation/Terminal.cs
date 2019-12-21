﻿using System;

namespace AutomaticStation
{
    public class Terminal//: ILinkTarget
    {
        private int id;

        private int activePort;


        //delegate void call(); //метод
        //event call Notify; // событие   

        //public void Update(int commandId, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}


        //объявление событий Event Hundler
        #region EventHundler

        public event EventHandler<CallEventArgs> CallRequested;

        #endregion


        ////подписка
        //public void SubscribeToPort(int portId)
        //{

        //}

        ////отписка
        //public void UnsubscribeFromPort()
        //{

        //}

        #region metods

        public void OnCallRequested(Object sender, CallEventArgs e) => CallRequested(this, e);

        //подключение к порту
        public void ConnectToPort(int portId)
        {
            //SubscribeToPort(portId);

            //подписка на события порта
            CallRequested += OnCallRequested;


            //сохраняем порт у себя
            activePort = portId;
        }

        //отключение от порта
        public void DisconnectFromPort()
        {
            //UnsubscribeFromPort();

            //отписка от событий порта
            CallRequested -= OnCallRequested;

            activePort = 0;
        }

        #endregion
    }
}