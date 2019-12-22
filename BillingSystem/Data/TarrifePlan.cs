using System;

namespace BillingSystem.Data
{
    public class TarrifePlan
    {
        //public Guid Id { get; set; }  // т.к. тарифный план только один! поэтому коммент.

        public string Name { get; set; }
      
        //Для всех абонентов применяется один тарифный план.
        #region Singleton

        private static TarrifePlan instance;

        private TarrifePlan()
        { }

        public static TarrifePlan getInstance()
        {
            if (instance == null)
                instance = new TarrifePlan();
            return instance;
        }

        #endregion
    }
}
