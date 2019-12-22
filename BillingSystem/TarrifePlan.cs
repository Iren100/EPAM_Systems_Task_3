using System;

namespace BillingSystem.Data
{
    public class TarrifePlan
    {
        //private Guid _id { get; set; }  // т.к. тарифный план только один! поэтому коммент.

        public string Name { get; private set; }
      
        //Для всех абонентов применяется один тарифный план.
        #region Singleton

        private static TarrifePlan instance;

        private TarrifePlan(string name)
        {
            Name = name;
        }

        public static TarrifePlan getInstance(string name)
        {
            if (instance == null)
                instance = new TarrifePlan(name);
            return instance;
        }

        #endregion
    }
}
