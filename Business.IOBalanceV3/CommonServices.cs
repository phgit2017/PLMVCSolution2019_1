
using System;
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
    public partial class CommonServices
    {
        IPLRepository<Units> _units;
        IPLRepository<Customers> _customers;
        IPLRepository<FilePasswords> _filePasswords;
        IPLRepository<Suppliers> _suppliers;

        IOBalanceDBV3Entity.Units units;
        IOBalanceDBV3Entity.Customers customers;
        IOBalanceDBV3Entity.FilePasswords filePasswords;
        IOBalanceDBV3Entity.Suppliers suppliers;

        public CommonServices(IPLRepository<Units> units, 
            IPLRepository<Customers> customers,
            IPLRepository<FilePasswords> filePasswords,
            IPLRepository<Suppliers> suppliers)
        {
            this._units = units;
            this._customers = customers;
            this._filePasswords = filePasswords;
            this._suppliers = suppliers;

            this.units = new IOBalanceDBV3Entity.Units();
            this.customers = new IOBalanceDBV3Entity.Customers();
            this.filePasswords = new IOBalanceDBV3Entity.FilePasswords();
            this.suppliers = new IOBalanceDBV3Entity.Suppliers();
        }
        
    }

    public partial class CommonServices : ICommonServices
    {
        public IQueryable<UnitDetails> GetAllUnits()
        {
            var result = from det in this._units.GetAll()
                         select new UnitDetails()
                         {
                             UnitId = det.UnitID,
                             UnitDescription = det.UnitDescription
                         };
            return result;
        }

        public bool SaveDetailsUnits(UnitDetails newDetails)
        {
            this.units = newDetails.DtoToEntity();

            if (this._units.Insert(this.units).IsNull())
            {
                return false;
            }

            return true;
        }

        public bool UpdateDetailsUnits(UnitDetails newDetails)
        {
            var details = newDetails.DtoToEntity();

            if (_units.Update2(details).IsNull())
            {
                return false;
            }
            
            return true;
        }

        public IQueryable<CustomerDetails> GetAllCustomers()
        {
            var result = from det in this._customers.GetAll()
                         select new CustomerDetails()
                         {
                             CustomerId = det.CustomerID,
                             CustomerCode = det.CustomerCode,
                             CustomerName = det.CustomerName,
                             CustomerAddress = det.CustomerAddress,
                             CreatedBy = det.CreatedBy,
                             DateCreated = det.DateCreated,
                             DateUpdated = det.DateUpdated,
                             IsActive = det.IsActive,
                             UpdatedBy = det.UpdatedBy
                         };

            return result;
        }

        public bool SaveDetailsCustomers(CustomerDetails newDetails)
        {
            this.customers = newDetails.DtoToEntity();

            if (this._customers.Insert(this.customers).IsNull())
            {
                return false;
            }

            return true;
        }

        public bool UpdateDetailsCustomers(CustomerDetails newDetails)
        {
            var details = newDetails.DtoToEntity();

            if (_customers.Update2(details).IsNull())
            {
                return false;
            }

            return true;
        }

        public IQueryable<FilePasswordDetails> GetAllFilePasswords()
        {
            var result = from det in this._filePasswords.GetAll()
                         select new FilePasswordDetails()
                         {
                             CreatedBy = det.CreatedBy,
                             DateCreated = det.DateCreated,
                             FilePassword = det.FilePassword,
                             FilePasswordId = det.FilePasswordID
                         };

            return result;
        }

        public bool SaveDetailsFilePasswords(FilePasswordDetails newDetails)
        {
            this.filePasswords = newDetails.DtoToEntity();

            if (this._filePasswords.Insert(this.filePasswords).IsNull())
            {
                return false;
            }

            return true;
        }

        public bool UpdateDetailsFilePasswords(FilePasswordDetails newDetails)
        {
            var details = newDetails.DtoToEntity();

            if (_filePasswords.Update2(details).IsNull())
            {
                return false;
            }

            return true;
        }

        public IQueryable<SupplierDetails> GetAllSuppliers()
        {
            var result = from det in this._suppliers.GetAll()
                         select new SupplierDetails()
                         {
                             SupplierCode = det.SupplierCode,
                             SupplierId = det.SupplierID,
                             SupplierName = det.SupplierName,
                             CreatedBy = det.CreatedBy,
                             DateCreated = det.DateCreated,
                             DateUpdated = det.DateUpdated,
                             IsActive = det.IsActive,
                             UpdatedBy = det.UpdatedBy
                         };

            return result;
        }

        public bool SaveDetailsSuppliers(SupplierDetails newDetails)
        {
            this.suppliers = newDetails.DtoToEntity();

            if (this._suppliers.Insert(this.suppliers).IsNull())
            {
                return false;
            }

            return true;
        }

        public bool UpdateDetailsSuppliers(SupplierDetails newDetails)
        {
            var details = newDetails.DtoToEntity();

            if (_suppliers.Update2(details).IsNull())
            {
                return false;
            }

            return true;
        }

    }

}
