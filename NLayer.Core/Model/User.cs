﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Core.Model
{
    public class User:BaseEntity
    {
        public string Name { get; set; }
        public string Password { get; set; }
    }
}
