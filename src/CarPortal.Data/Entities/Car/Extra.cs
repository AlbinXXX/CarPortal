﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CarPortal.Data.Entities.Car
{
    public class Extra
    {
        [Key]
        public int Id { get; set; }

        [Required]
        [StringLength(80)]
        public string Name { get; set; } = null!;

        public ICollection<CarExtra> Cars = new List<CarExtra>();
    }
}