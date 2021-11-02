using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.Models
{
    public class Title
    {
        [Key]
        [Required(ErrorMessage = "Required")]
        [Column(Order = 1)]
        public int TitleID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(30, ErrorMessage = "Max 30 characters")]
        public string Description { get; set; }
    }
}
