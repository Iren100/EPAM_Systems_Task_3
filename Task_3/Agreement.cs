using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Agreement: IElementId
    {
        public Guid Id { get; set; }

        public string Name { get; set; }

        public DateTime DateBeg { get; set; }

        public DateTime DateEnd { get; set; }

        //target
        //int TargetBankDetailId
        //int TargetAddressId

        //customer
        //int СustomerBankDetailId
        //int СustomerAddressId


        //enum
        //AgreementType

        public string DocNumber { get; set; }

        public DateTime DocDate { get; set; }

        public string CustomerFirmName { get; set; }

        public string TargetFirmName { get; set; }

        public string calc_agreementState { get; set; }

        public int StatusId { get; set; }

        public string calc_CurrencyId { get; set; }

        public string Note { get; set; }


        public int CreatedByUserId { get; set; }

        public DateTime CreatedDateTime { get; set; }

        public int UpdatedByUserId { get; set; }

        public DateTime UpdatedDateTime { get; set; }

        public bool IsDeleted { get; set; }

    }
}
