﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.IOBalanceV3.Dto;
using Business.IOBalanceV3.Extensions;
using Business.IOBalanceV3.Interface;
using DataAccess.Database.IOBalanceV3;
using DataAccess.Repository.PL.Interface;
using Infrastructure.Utilities;
using IOBalanceDBV3Entity = DataAccess.Database.IOBalanceV3;

namespace Business.IOBalanceV3
{
    public partial class InventoryServices
    {
        IPLRepository<Product> _products;

        IOBalanceDBV3Entity.Product products;

        public InventoryServices(IPLRepository<Product> products)
        {
            this._products = products;

            this.products = new IOBalanceDBV3Entity.Product();
        }
    }

    public partial class InventoryServices : IInventoryServices
    {
        public IQueryable<ProductDetails> GetAllProductDetails()
        {
            var result = from det in this._products.GetAll()
                         select new ProductDetails()
                         {
                             ProductId = det.ProductID,
                             ProductCode = det.ProductCode,
                             ProductDescription = det.ProductDescription,
                             ProductExtension = det.ProductExtension,
                             ProductQuantity = det.ProductQuantity,
                             CreatedBy = det.CreatedBy,
                             DateCreated = det.DateCreated,
                             UpdatedBy = det.UpdatedBy,
                             DateUpdated = det.DateUpdated
                         };

            return result;
        }

        public bool SaveDetailsProducts(ProductDetails newDetails)
        {
            this.products = newDetails.DtoToEntity();

            if (this._products.Insert(this.products).IsNull())
            {
                return false;
            }

            return true;
        }

        public bool UpdateDetailsProducts(ProductDetails newDetails)
        {
            var details = newDetails.DtoToEntity();

            if (_products.Update2(details).IsNull())
            {
                return false;
            }

            return true;
        }
    }
}
