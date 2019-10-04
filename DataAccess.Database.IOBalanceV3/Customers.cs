using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Database.IOBalanceV3
{
    public class Customers
    {
        [Key]
        public long CustomerID { get; set; }
        public string CustomerCode { get; set; }
        public string CustomerName { get; set; }
        public string CustomerAddress { get; set; }
        public long? CreatedBy { get; set; }
        public DateTime? DateCreated { get; set; }
        public long? UpdatedBy { get; set; }
        public DateTime? DateUpdated { get; set; }
        public bool IsActive { get; set; }
    }
}
