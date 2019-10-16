using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Dto
{
    public class ProductDetails : CommonDetails
    {
        public long ProductId { get; set; }

        [StringLength(64)]
        public string ProductCode { get; set; }

        [StringLength(256)]
        public string ProductDescription { get; set; }

        [StringLength(256)]
        public string ProductExtension { get; set; }

        public decimal ProductQuantity { get; set; }
    }
}
