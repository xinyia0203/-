﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;

namespace CourseManager.Models
{
    public class ActionLink
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [StringLength(20)]
        public string Name { get; set; }
        [Required]
        [StringLength(20)]
        public string Controller { get; set; }
        [Required]
        [StringLength(20)]
        public string Action { get; set; }
    }
}
