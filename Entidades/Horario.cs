﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Horario
    {
        public int ID { get; set; }
        public DateTime Hora { get; set; }

        public override string ToString()
        {
            return ID.ToString();
        }
    }
}
