using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DBProject.Models
{
    public partial class Customer
    {
        [Key]
        [Column("CustomerID")]
        public int Id { get; set; }
        public string NameStyle { get; set; } = null!;
        public string? Title { get; set; }
        public string FirstName { get; set; } = null!;
        public string? MiddleName { get; set; }
        public string LastName { get; set; } = null!;
        public string? Suffix { get; set; }
        public string CompanyName { get; set; } = null!;
        public string SalesPerson { get; set; } = null!;
        public string EmailAddress { get; set; } = null!;
        public string Phone { get; set; } = null!;
        public string ModifiedDate { get; set; } = null!;
        //public virtual ICollection<Orders> Orders { get; set; } = new List<Orders>();

    }
}
