﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace NoMasAccidentesApi.Models
{
    public class Login
    {
        public int empId { get; set; }
        public string username { get; set; }
        public string clave { get; set; }
    }
}
