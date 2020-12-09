using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace collegemanagment.Models
{
    [Table("Student_tbl")]
    public class studentmodel
    {
        [Key]
        public int Id { get; set; }
        public string StudentName { get; set; }
        public System.DateTime Dob { get; set; }
        public string contact { get; set; }
        public string Gender { get; set; }
        public string GuardianName { get; set; }
        public string UG { get; set; }
        public string PG { get; set; }
        public string tenth { get; set; }
        public string plustwo { get; set; }
        public string CC { get; set; }
        public string Address { get; set; }
        public string Coursetype { get; set; }
        public string collegename { get; set; }
        public string Degree { get; set; }
    }
}