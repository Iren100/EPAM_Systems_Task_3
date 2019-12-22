using System;

namespace BillingSystem.Data
{
    class Station
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        private int PortId { get; set; }

        //методы

        public int? GetPort(int id)
        {

            return PortId;
            //return null;
        }
    }
}
