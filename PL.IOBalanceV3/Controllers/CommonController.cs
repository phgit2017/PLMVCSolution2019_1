using Business.IOBalanceV3.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.IOBalanceV3.Controllers
{
    public class CommonController : Controller
    {
        private readonly ICommonServices _commonServices;
        private readonly IInventoryServices _inventoryServices;
        
        public CommonController(ICommonServices commonServices,
            IInventoryServices inventoryServices)
        {
            this._commonServices = commonServices;
            this._inventoryServices = inventoryServices;
        }

        // GET: Common
        public ActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public JsonResult GetEditProductEditType()
        {
            List<QtyType> data = new List<QtyType>();

            data.Add(new QtyType() { QuantityTypeIntValue = 1, QuantityTypeName = "Add", QuantityTypeValue = "+" });
            data.Add(new QtyType() { QuantityTypeIntValue = 2, QuantityTypeName = "Minus", QuantityTypeValue = "-" });
            return Json(data, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetSuppliers()
        {
            var result = this._commonServices.GetAllSuppliers().Where(m => m.IsActive);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public JsonResult GetCustomers()
        {
            var result = this._commonServices.GetAllCustomers().Where(m => m.IsActive);
            return Json(result, JsonRequestBehavior.AllowGet);
        }

        [HttpGet]
        public ActionResult GetProducts()
        {
            var result = this._inventoryServices.GetAllProductDetails();
            return Json(result, JsonRequestBehavior.AllowGet);
        }


        public class QtyType
        {
            public string QuantityTypeValue { get; set; }
            public string QuantityTypeName { get; set; }
            public int QuantityTypeIntValue { get; set; }
        }
    }
}