using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DataAccessLayerDBFirst;

namespace BusinessLogicDBFirst
{
    public class SupplierBusiness
    {
        public List<SupplierDTO> GetListOfSuppliers() {
            DataAccessLayerDBFirst.NorthwindEntities db = new NorthwindEntities();
            DbSet<Supplier> s=db.Suppliers;
        List<SupplierDTO> suppliers = new List<SupplierDTO>();
            foreach (var item in s)
            {
                SupplierDTO supplier = new SupplierDTO();
                supplier.SupplierID = item.SupplierID;
                supplier.CompanyName = item.CompanyName;
                supplier.ContactName = item.ContactName;
                supplier.ContactTitle = item.ContactTitle;
                supplier.Address = item.Address;
                supplier.City = item.City;
                supplier.Region = item.Region;
                supplier.PostalCode = item.PostalCode;
                supplier.Country=item.Country;
                supplier.Phone = item.Phone;
                supplier.Fax = item.Fax;
                supplier.HomePage= item.HomePage;

                suppliers.Add(supplier);
            }
            return suppliers;

        }

    }
}
