﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace MvcDemo.Models
{
    [Table("students")]
    public class Student
    {
        [Key]
        public int Id{ get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public int FeePaid { get; set; }
        public string Course { get; set; }
    }
}