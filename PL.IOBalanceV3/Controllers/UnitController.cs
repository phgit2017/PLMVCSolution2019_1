using Business.IOBalanceV3.Interface;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.IOBalanceV3.Controllers
{
    public class UnitController : Controller
    {
        ICommonServices _commonServices;
        public UnitController(ICommonServices commonServices)
        {
            this._commonServices = commonServices;
        }

        [HttpPost]
        public JsonResult GetDetails()
        {
            var list = _commonServices.GetAllUnits().ToList();

            var response = new
            {
                data = list
            };
            return Json(response,JsonRequestBehavior.AllowGet);
        }

        // GET: Unit
        public ActionResult Index()
        {
            var list = _commonServices.GetAllUnits().ToList();
            return View();
        }
    }
}