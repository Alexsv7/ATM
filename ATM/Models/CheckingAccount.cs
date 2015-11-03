using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ATM.Models
{
    public class CheckingAccount
    {
        public int id { get; set; }
        [Required]
        [RegularExpression(@"\d{6,10}",ErrorMessage ="Account #must have 6 to 10 numbers")]
        [StringLength(10)]
        [Column(TypeName="varchar")]
        [Display (Name="Account#")]
        public string AccountNumber { get; set; }

        [Required]
        [Display(Name = "First Name")]
        
        public string FirstName { get; set; }
        [Required]
        [Display(Name = "Last name")]
        public string LastName { get; set; }

        public string Name {
            get { return string.Format("{0} {1}", this.FirstName, this.LastName); }
        }
        [DataType (DataType.Currency)]
        public decimal Balance { get; set; }
        public virtual ApplicationUser User { get; set; }
        [Required]
        public string ApplicationUserId { get; set; }

        public virtual ICollection<Transaction> Transactions { get; set;  }
    }
}
  