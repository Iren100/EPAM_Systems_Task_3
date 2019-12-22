using System;
using System.Collections.Generic;
using AutomaticStation;

namespace BillingSystem.Data
{
    public class Station
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        private ICollection<Port> PortItems { get; set; }

        private int _activePort { get; set; }

        //методы
        #region metods

        public int? GetPort(int id)
        {
            return _activePort;
            //return null;
        }



        //станция умеет отслеживать изменения состояния порта - отключен, подключен, звонок и т.п.

        //реализовать!!!

        #endregion
    }
}
