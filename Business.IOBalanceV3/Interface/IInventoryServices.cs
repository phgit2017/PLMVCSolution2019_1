using Business.IOBalanceV3.Dto;
using DataAccess.Database.IOBalanceV3;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.IOBalanceV3.Interface
{
    public interface IInventoryServices
    {
        Product SaveDetailsProducts(ProductDetails newDetails);
        Product UpdateDetailsProducts(ProductDetails newDetails);
        IQueryable<ProductDetails> GetAllProductDetails();
    }
}
