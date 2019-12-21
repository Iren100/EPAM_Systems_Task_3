using System;

namespace BillingSystem.Data
{
    public class Agreement
    {
        public Guid Id { get; set; }

        public string Name { get; set; }


        #region Phone number

        public Guid StationId { get; set; } // ссылка на АТС

        public Guid PortId { get; set; } // ссылка на порт

        #endregion


        #region Other fields

        public string DocNumber { get; set; }

        public DateTime DocDate { get; set; }

        public string Note { get; set; }

        #endregion

    }
}
