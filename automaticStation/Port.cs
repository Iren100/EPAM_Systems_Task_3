using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStation
{
    public class Port
    {
        #region properties

        //свободен/занят
        private bool busy { get; set; }

        //включен/выключен
        private bool turnOn { get; set; }

        //звонок
        private bool call { get; set; }

        #endregion
    }
}
