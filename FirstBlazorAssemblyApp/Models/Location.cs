﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FirstBlazorAssemblyApp.Models
{
    public class Location
    {
        public int Id { get; set; }
        public string City { get; set; }
        public string ProvState { get; set; }
        public string Country { get; set; }
    }
}
