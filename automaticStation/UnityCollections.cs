using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AutomaticStation
{
    class UnityCollections
    {
        //коллекция пар порт-терминал
        private IDictionary<Port, Terminal> _mappingPortTerminal = new Dictionary<Port, Terminal>();

        //коллекция портов
        public ICollection<Port> portItems { get; private set; }
    }
}
