﻿using System;

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


        #region private other fields

        private User _user { get; set; }

        private TarrifePlan _tarrifePlan { get; set; }

        private Station _station { get; set; }


        private string DocNumber { get; set; }

        private DateTime DocDate { get; set; }

        private string Note { get; set; }

        #endregion


        #region metods
        //отдать модель BS(Agreement, User, TariffPlan, Station)
        public AgreementStatus Sign(User user, TarrifePlan tarrifePlan, Station station)
        {
            _user = user;

            _tarrifePlan = tarrifePlan;

            _station = station;

            return AgreementStatus.Ok;
        }

        #endregion
    }
}
