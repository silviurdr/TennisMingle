﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using TennisMingle.API.Enums;

namespace TennisMingle.API.Models
{
    public class TennisClubForUpdateDTO
    {
        [Required(ErrorMessage ="You should provide a name value")]
        [MaxLength(50)]
        /// <summary>
        /// Name of the tennis club 
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// The collection of the tennis club courts 
        /// </summary>
        public ICollection<TennisCourtDTO> TennisCourts { get; set; }

        /// <summary>
        /// The collection of the tennis club coaches
        /// </summary>
        public ICollection<CoachDTO> Coaches { get; set; }

        /// <summary>
        /// The collection of the tennis club courts surfaces 
        /// </summary>
        public ICollection<Surface> Surfaces { get; set; }

        /// <summary>
        /// The collection of the tennis club facilities 
        /// </summary>
        public ICollection<Facilities> Facilities { get; set; }

        /// <summary>
        /// The tennis club adress
        /// </summary>
        public string Address { get; set; }
        /// <summary>
        /// The tennis club phone number
        /// </summary>
        public string PhoneNumber { get; set; }

        /// <summary>
        /// The tennis club description
        /// </summary>
        public string Description { get; set; }

        /// <summary>
        /// The tennis club prices
        /// </summary>
        public List<int> Prices { get; set; }

        /// <summary>
        /// The tennis club schedule
        /// </summary>
        public string Schedule { get; set; }

        /// <summary>
        /// The uploaded tennis club image
        /// </summary>
        public string Image { get; set; }
    }
}
