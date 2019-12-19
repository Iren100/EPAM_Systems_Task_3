using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Call: IElementId
    {
        public Guid Id { get; set; }

        public Phone incomingCallNumber { get; set; }

        public Phone outgoingCallNumber { get; set; }

    }
}
