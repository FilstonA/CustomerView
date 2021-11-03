using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.Models
{
    public class Customer
    {
        [Key]
        [Required(ErrorMessage = "The customerId field is required")]
        public int CustomerID { get; set; }

        [ForeignKey("Titles")]
        [Column(Order = 1)]
        public int TitleID { get; set; }

        [ForeignKey("Statuses")]
        [Column(Order = 1)]
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]     
        public string Forename { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Surname { get; set; }

        [Required(ErrorMessage = "Required")]
        public DateTime DateOfBirth { get; set; }

        [StringLength(40, ErrorMessage = "Max 40 characters")]
        [RegularExpression(@"\b[A-Z0-9._%-]+@[A-Z0-9.-]+\.[A-Z]{2,4}\b")]
        public string Email { get; set; }
    }
}
