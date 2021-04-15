﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace FinalProjectGroupA.Models
{
    public class Team
    {
        public int Id { get; set; }
        public string TeamName { get; set; }
        public DateTime CreationDate { get; set; }
        public string College { get; set; }
        public string PrimaryColor { get; set; }
    }
}
