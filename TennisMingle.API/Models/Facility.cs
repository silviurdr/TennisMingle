﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using TennisMingle.API.Enums;

namespace TennisMingle.API.Models
{
    public class Facility
    {
        public int Id { get; set; }
        [Required]
        public Facilities FacilityType { get; set; }
    }
}
