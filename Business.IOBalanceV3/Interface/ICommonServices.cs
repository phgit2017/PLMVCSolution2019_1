using Business.IOBalanceV3.Dto;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Business.IOBalanceV3.Interface
{
    public interface ICommonServices
    {
        IQueryable<UnitDetails> GetAllUnits();
        bool SaveDetailsUnits(UnitDetails newDetails);
        bool UpdateDetailsUnits(UnitDetails newDetails);
        IQueryable<CustomerDetails> GetAllCustomers();
        bool SaveDetailsCustomers(CustomerDetails newDetails);
        bool UpdateDetailsCustomers(CustomerDetails newDetails);
        IQueryable<FilePasswordDetails> GetAllFilePasswords();
        bool SaveDetailsFilePasswords(FilePasswordDetails newDetails);
        bool UpdateDetailsFilePasswords(FilePasswordDetails newDetails);
        IQueryable<SupplierDetails> GetAllSuppliers();
        bool SaveDetailsSuppliers(SupplierDetails newDetails);
        bool UpdateDetailsSuppliers(SupplierDetails newDetails);
    }
}
