﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_3
{
    public class Phone : IElementId
    {
        public Guid Id { get; set; }

        //public string Name { get; set; }

        public string Number { get; set; }
    }
}
