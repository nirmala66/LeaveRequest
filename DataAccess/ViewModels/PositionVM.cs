﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.ViewModels
{
    public class PositionVM
    {
        public string Name { get; set; }

        public PositionVM(string name)
        {
            this.Name = name;
        }
    }
}
