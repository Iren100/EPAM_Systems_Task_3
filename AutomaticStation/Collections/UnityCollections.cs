using System.Collections.Generic;

namespace AutomaticStation.Collections
{
    class UnityCollections
    {
        //коллекция пар порт-терминал
        private IDictionary<Port, Terminal> _mappingPortTerminal = new Dictionary<Port, Terminal>();

        //коллекция портов
        public ICollection<Port> portItems { get; private set; }
    }
}
