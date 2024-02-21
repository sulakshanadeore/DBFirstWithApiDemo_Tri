using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BusinessLogicDBFirst;
using WebAPIDemoDBFirst.Models;

namespace WebAPIDemoDBFirst.Controllers
{
    public class NWSuppliersController : ApiController
    {
        public List<SupplierModel> Get()
        {
            SupplierBusiness supplierbuiness = new SupplierBusiness();
            List<SupplierModel> supplierModelList = new List<SupplierModel>();
            List<SupplierDTO> suppliers = supplierbuiness.GetListOfSuppliers();
            foreach (var item in suppliers)
            {


                SupplierModel supplier = new SupplierModel();
                supplier.SupplierID = item.SupplierID;
                supplier.CompanyName = item.CompanyName;
                supplier.ContactName = item.ContactName;
                supplier.ContactTitle = item.ContactTitle;
                supplier.Address = item.Address;
                supplier.City = item.City;
                supplier.Region = item.Region;
                supplier.PostalCode = item.PostalCode;
                supplier.Country = item.Country;
                supplier.Phone = item.Phone;
                supplier.Fax = item.Fax;
                supplier.HomePage = item.HomePage;

                supplierModelList.Add(supplier);
            }
            return supplierModelList;
        }
    }
}
