﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace EasyKBTaskBoard.API.Models
{
    public class ColumnForCreationDto
    {
        [Required]
        [MaxLength(30)]
        public string Name { get; set; }
    }
}
