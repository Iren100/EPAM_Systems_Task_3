using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class User: IElementId, IElementName
    {
        public Guid Id { get; set; }

        public string Name {
                             get { return  firstName + " " + lastName + " " + patronymicName; }
                             set { value = firstName + " " + lastName + " " + patronymicName; }
                           }

        public string firstName { get; set; }

        public string lastName { get; set; }

        public string patronymicName { get; set; }
        
        public string Adress { get; set; }

        //физ./юр. лицо
        //public string 

        //mail
        public string mail { get; set; }

        // пароль
        public string password { get; set; }

        // ИНН

        //

    }
}
