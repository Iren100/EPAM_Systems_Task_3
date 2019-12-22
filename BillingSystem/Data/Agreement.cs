using System;

namespace BillingSystem.Data
{
    public class Agreement
    {
        private Guid _d = new Guid();


        #region Phone number

        //мы не знаем ничего о порте и терминале, просто набираем номер
        public string PhoneNumber { get; set; }

        //public Guid StationId { get; set; } // ссылка на АТС

        //public Guid PortId { get; set; } // ссылка на порт

        #endregion


        #region private other fields

        private User _user { get; set; }

        private TarrifePlan _tarrifePlan { get; set; }

        private Station _station { get; set; }


        private string _docNumber { get; set; }

        private DateTime _docDate { get; set; }

        private string _note { get; set; }

        #endregion


        public Agreement(string phoneNumber, User user, TarrifePlan tarrifePlan, Station station, 
                           string dogNumder, DateTime docDate, string note)
        {
            PhoneNumber = phoneNumber;
            _user = user;
            _tarrifePlan = tarrifePlan;
            _station = station;
            _docNumber = _docNumber;
            _docDate = docDate;
            _note = note;
        }


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
