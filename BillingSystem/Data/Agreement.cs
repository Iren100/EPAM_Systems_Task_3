using System;

namespace BillingSystem.Data
{
    public class Agreement
    {
        public Guid Id { get; set; }


        #region Phone number

        //мы не знаем ничего о порте и терминале, просто набираем номер

        public String phoneNumber { get; set; }

        //public Guid StationId { get; set; } // ссылка на АТС

        //public Guid PortId { get; set; } // ссылка на порт

        #endregion


        #region Other fields

        public string DocNumber { get; set; }

        public DateTime DocDate { get; set; }

        public string Note { get; set; }

        #endregion

        //методы
        public ConnectStatus SignAgreement()
        {
            return ConnectStatus.Ok;
        }
    }
}
