using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Configuration;


namespace CRUD_EF_CodeFirst.Models
{
    public class Student
    {

        public int id { get; set; }

        [Required(ErrorMessage = "Name {0} is required")]
        [Display(Name ="Name")]
        public string name { get; set; }

        [Required(ErrorMessage = "Batch {0} is required")]
        [Display(Name = "Batch")]
        public string batch { get; set; }

        [Required(ErrorMessage = "Marks {0} is required")]
        [Display(Name = "Marks")]
        [Range(0, 100, ErrorMessage = "Range should be 0-100")]
        public int marks { get; set; }

    }
    public partial class StudentContext:DbContext
    {
        public virtual DbSet<Student> Students { get; set; }

      
    }
}