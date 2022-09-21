﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DbTableComparer.Models
{
    public class Column
    {
        public Column(string name, int type, int length, int scale)
        {
            Name = name;
            Type = type;    
            Length = length;
            Scale = scale;
        }
        public string  Name { get; set; }
        public int Type { get; set; }
        public int Length { get; set; }
        public int Scale { get; set; }

    }
}