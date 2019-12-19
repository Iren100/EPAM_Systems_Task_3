using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkClass.Link;

namespace AutomaticStation
{
    class Terminal: ILinkTarget
    {

        delegate void call(); //метод
        event call Notify; // событие   

        public void Update(int commandId, Dictionary<string, object> parameters)
        {
            throw new NotImplementedException();
        }
    }
}
