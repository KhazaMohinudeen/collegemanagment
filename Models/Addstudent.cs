using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace collegemanagment.Models
{
    public class Addstudent
    {
        [Required]
        public string StudentName { get; set; }
        [Required]
        [DataType(DataType.Date), DisplayFormat(DataFormatString = "{0:dd/MM/yyyy}", ApplyFormatInEditMode = true)]
        public string Dob { get; set; }
        [Required]
        public string contact { get; set; }
        [Required]
        public string Gender { get; set; }
        [Required]
        public string GuardianName { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.PNG|.JPG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase UG { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.PNG|.JPG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase PG { get; set; }

        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.JPG|.PNG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase tenth { get; set; }
        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.JPG|.PNG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase plustwo { get; set; }
        [Required(ErrorMessage = "Please select file.")]
        [RegularExpression(@"([a-zA-Z0-9\s_\\.\-:])+(.png|.jpg|.JPG|.PNG)$", ErrorMessage = "Only Image files allowed.")]
        public HttpPostedFileBase CC { get; set; }
        [Required]
        public string Address { get; set; }
        [Required]
        public string Coursetype { get; set; }

        [Required]
        public string collegename { get; set; }
        [Required]
        public string Degree { get; set; }
           
      
    }

}