using Business.IOBalanceV3.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Interface
{
    public interface IInventoryServices
    {
        bool SaveDetailsProducts(ProductDetails newDetails);
        bool UpdateDetailsProducts(ProductDetails newDetails);
        IQueryable<ProductDetails> GetAllProductDetails();
    }
}
