
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
        public static IOBalanceDBV3Entity.Units DtoToEntity(this UnitDetails dto)
        {
            IOBalanceDBV3Entity.Units entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Units
                {
                    UnitID = dto.UnitId,
                    UnitDescription = dto.UnitDescription
                };
            }

            return entity;
        }

        public static IOBalanceDBV3Entity.Customers DtoToEntity(this CustomerDetails dto)
        {
            IOBalanceDBV3Entity.Customers entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Customers
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

        public static IOBalanceDBV3Entity.Suppliers DtoToEntity(this SupplierDetails dto)
        {
            IOBalanceDBV3Entity.Suppliers entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.Suppliers
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

        public static IOBalanceDBV3Entity.FilePasswords DtoToEntity(this FilePasswordDetails dto)
        {
            IOBalanceDBV3Entity.FilePasswords entity = null;

            if (!dto.IsNull())
            {
                entity = new IOBalanceDBV3Entity.FilePasswords
                {
                    CreatedBy = dto.CreatedBy,
                    DateCreated = dto.DateCreated,
                    FilePassword = dto.FilePassword,
                    FilePasswordID = dto.FilePasswordId,
                };
            }

            return entity;
        }
    }
}
