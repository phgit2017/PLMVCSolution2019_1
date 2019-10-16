
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Business.IOBalanceV3.Dto;
using Infrastructure.Utilities;
using IOBalanceDBV3Entity = DataAccess.Database.IOBalanceV3;

namespace Business.IOBalanceV3.Extensions
{
    public static class EntityMapper
    {
        public static IOBalanceDBV3Entity.Unit DtoToEntity(this UnitDetails dto)
        {
            IOBalanceDBV3Entity.Unit entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Unit
                {
                    UnitID = dto.UnitId,
                    UnitDescription = dto.UnitDescription
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.Customer DtoToEntity(this CustomerDetails dto)
        {
            IOBalanceDBV3Entity.Customer entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Customer
                {
                    CustomerID = dto.CustomerId,
                    CreatedBy = dto.CreatedBy,
                    CustomerAddress = dto.CustomerAddress,
                    CustomerCode = dto.CustomerCode,
                    CustomerName = dto.CustomerName,
                    DateCreated = dto.DateCreated,
                    DateUpdated = dto.DateUpdated,
                    IsActive = dto.IsActive,
                    UpdatedBy = dto.UpdatedBy
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.Supplier DtoToEntity(this SupplierDetails dto)
        {
            IOBalanceDBV3Entity.Supplier entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Supplier
                {
                    SupplierID = dto.SupplierId,
                    CreatedBy = dto.CreatedBy,
                    DateCreated = dto.DateCreated,
                    SupplierCode = dto.SupplierCode,
                    DateUpdated = dto.DateUpdated,
                    IsActive = dto.IsActive,
                    SupplierName = dto.SupplierName,
                    UpdatedBy = dto.UpdatedBy,
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.FilePassword DtoToEntity(this FilePasswordDetails dto)
        {
            IOBalanceDBV3Entity.FilePassword entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.FilePassword
                {
                    CreatedBy = dto.CreatedBy,
                    DateCreated = dto.DateCreated,
                    FilePasswordName = dto.FilePasswordName,
                    FilePasswordID = dto.FilePasswordId,
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.Product DtoToEntity(this ProductDetails dto)
        {
            IOBalanceDBV3Entity.Product entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Product
                {
                    ProductID = dto.ProductId,
                    ProductCode = dto.ProductCode,
                    ProductDescription = dto.ProductDescription,
                    ProductExtension = dto.ProductExtension,
                    ProductQuantity = dto.ProductQuantity,
                    CreatedBy = dto.CreatedBy,
                    UpdatedBy = dto.UpdatedBy,
                    DateCreated = dto.DateCreated,
                    DateUpdated = dto.DateUpdated
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.Loggers DtoToEntity(this LoggerDetails dto)
        {
            IOBalanceDBV3Entity.Loggers entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Loggers
                {
                    LoggerID = dto.LoggerId,
                    LoggingMethod = dto.LoggingMethod,
                    ColumnName = dto.ColumnName,
                    DateCreated = dto.DateCreated,
                    NewValue = dto.NewValue,
                    OldValue = dto.OldValue
                };
            }

            return entity;
        }
    }
}
