﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FormsExersize
{
    class Deets
    {
        public string Fname { get; set; }
        public string Lname { get; set; }
        public int Age { get; set; }

        public string DisplayName()
        {
            return $"{Fname} {Lname}";
        }
    }
}
