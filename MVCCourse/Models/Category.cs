﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace MVCCourse.Models
{
    public class Category
    {
        public int Id { get; set; }
        [Display(Name ="Descrição")]
        [Required(ErrorMessage = "Description field is required.")]
        public string Description { get; set; }
    }
}
                                                                                                                                                                                  