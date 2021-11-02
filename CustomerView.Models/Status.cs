using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CustomerView.Models
{
    public class Status
    {
        [Key]
        [Required(ErrorMessage = "Required")]
        [Column(Order = 1)]
        public int StatusID { get; set; }

        [Required(ErrorMessage = "Required")]
        [StringLength(50, ErrorMessage = "Max 50 characters")]
        public string Description { get; set; }

        [Required(ErrorMessage = "Required")]
        public bool IsMarketingAllowed { get; set; }
    }
}
