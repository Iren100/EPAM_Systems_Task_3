using System;
using System.Collections.Generic;
using AutomaticStation;

namespace BillingSystem.Data
{
    public class Station
    {
        private Guid _id = new Guid();

        public string Name { get; private set; }

        private int _port { get; set; }


        public Station(string name)
        {
            Name = name;
        }


        #region metods

        public int? GetPort(int id)
        {
            return _port;
            //return null;
        }



        //станция умеет отслеживать изменения состояния порта - отключен, подключен, звонок и т.п.

        //реализовать!!!

        #endregion
    }
}
