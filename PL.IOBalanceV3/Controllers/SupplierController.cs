using Business.IOBalanceV3;
using Business.IOBalanceV3.Dto;
using Business.IOBalanceV3.Interface;
using Infrastructure.Utilities;
using LinqKit;
using PL.IOBalanceV3.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace PL.IOBalanceV3.Controllers
{
    public class SupplierController : Controller
    {
        ICommonServices _commonServices;
        public SupplierController(ICommonServices commonServices)
        {
            _commonServices = commonServices;
        }

        // GET: Supplier
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetDetails()
        {
            var list = _commonServices.GetAllSuppliers().ToList();

            var response = new
            {
                data = list
            };
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveDetails(SupplierDetails dto)
        {
            bool isSuccess = false;
            string alertMessage = string.Empty;


            if (ModelState.IsValid)
            {
                dto.SupplierId = 0;

                var duplicate = _commonServices.GetAllSuppliers().Where(m => m.SupplierName == dto.SupplierName && m.SupplierCode == dto.SupplierCode).Count();

                if (duplicate >= 1)
                {
                    alertMessage = (string.Format(Messages.DuplicateItem, "Supplier"));
                }
                else
                {

                    if (!this._commonServices.SaveDetailsSuppliers(dto))
                    {
                        alertMessage = string.Format(Messages.ErrorOccuredDuringProcessingThis, "saving in supplier");
                    }
                    else
                    {
                        isSuccess = true;
                        alertMessage = Messages.InsertSuccess;
                    }
                }
            }
            else
            {
                alertMessage = Messages.ErrorOccuredDuringProcessingOrRequiredFields;
            }

            var jsonResult = new
            {
                isSuccess = isSuccess,
                alertMessage = alertMessage
            };

            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult UpdateDetails(SupplierDetails dto)
        {
            bool isSuccess = false;
            string alertMessage = string.Empty;

            if (ModelState.IsValid)
            {
                var duplicate = _commonServices.GetAllSuppliers().Where(c => c.SupplierName == dto.SupplierName && c.SupplierCode == dto.SupplierCode && c.SupplierId != dto.SupplierId).Count();

                if (duplicate >= 1)
                {
                    alertMessage = (string.Format(Messages.DuplicateItem, "Supplier"));
                }
                else
                {
                    if (!this._commonServices.UpdateDetailsSuppliers(dto))
                    {
                        alertMessage = string.Format(Messages.ErrorOccuredDuringProcessingThis, "updating in suppliers");
                    }
                    else
                    {
                        isSuccess = true;
                        alertMessage = (Messages.UpdateSuccess);
                    }
                }
            }
            else
            {
                alertMessage = Messages.ErrorOccuredDuringProcessingOrRequiredFields;
            }


            var jsonResult = new
            {
                isSuccess = isSuccess,
                alertMessage = alertMessage
            };

            return Json(jsonResult, JsonRequestBehavior.AllowGet);
        }

        private IQueryable<SupplierDetails> GetDetail(SupplierSearchModel searchModel)
        {

            IQueryable<SupplierDetails> list = null;

            if (!searchModel.HasAnyValue())
            {
                list = _commonServices.GetAllSuppliers();
            }
            else
            {
                var predicate = PredicateBuilder.True<SupplierDetails>();

                if (!searchModel.SupplierName.IsNull())
                {
                    predicate = predicate.And(c => c.SupplierName.Contains(searchModel.SupplierName));
                }

                if (!searchModel.SupplierCode.IsNull())
                {
                    predicate = predicate.And(c => c.SupplierCode.Contains(searchModel.SupplierCode));
                }

                list = _commonServices.GetAllSuppliers().AsExpandable().Where(predicate);

            }

            return list;

        }

        protected override void Dispose(bool disposing)
        {
            if (!_commonServices.IsNull())
            {
                _commonServices = null;
            }
            base.Dispose(disposing);
        }
    }
}