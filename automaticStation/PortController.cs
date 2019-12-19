using System;
using UnitOfWorkClass.Link;

namespace AutomaticStation
{
    //класс для отслеживания измения состояния порта
    class PortController : ILinkSource
    {
        public object GetState()
        {
            throw new NotImplementedException();
        }
    }
}
