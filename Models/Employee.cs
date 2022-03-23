using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace EnumTest.Models
{
    [Table("employee")]
    public partial class Employee
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [StringLength(120)]
        public string Name { get; set; }
        [StringLength(100)]
        public string Gender { get; set; }
        [Column("city")]
        [StringLength(100)]
        public string City { get; set; }
    }
}
