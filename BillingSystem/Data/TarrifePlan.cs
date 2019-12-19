using System;

namespace BillingSystem.Data
{
    class TarrifePlan: IElementId, IElementName
    {
        public Guid Id { get; set; }

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
