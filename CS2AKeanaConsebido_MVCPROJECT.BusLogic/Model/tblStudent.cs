﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CS2AKeanaConsebido_MVCPROJECT.BusLogic.Model
{
    public class tblStudent
    {
        [Key]
        public int id { get; set; }
        public string? FirstName { get; set; }
        public string? LastName { get; set; }
        public int? Age { get; set; }
        public string? Course { get; set; }
    }
}
