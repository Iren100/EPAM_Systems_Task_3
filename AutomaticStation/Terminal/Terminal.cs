using System;

namespace AutomaticStation
{
    public class Terminal//: ILinkTarget
    {
        private Guid _id = new Guid();

        public TerminalController terminalController { get; private set; }


        public Terminal()
        {
            this.terminalController = new TerminalController();
        }

        //delegate void call(); //метод
        //event call Notify; // событие   

        //public void Update(int commandId, Dictionary<string, object> parameters)
        //{
        //    throw new NotImplementedException();
        //}    
    }
}
