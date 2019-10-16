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
    public class CustomerController : Controller
    {
        ICommonServices _commonServices;
        public CustomerController(ICommonServices commonServices)
        {
            this._commonServices = commonServices;
        }
        // GET: Customer
        public ActionResult Index()
        {
            return View();
        }

        [HttpPost]
        public JsonResult GetDetails()
        {
            var list = _commonServices.GetAllCustomers().ToList();

            var response = new
            {
                data = list
            };
            return Json(response, JsonRequestBehavior.AllowGet);
        }

        [HttpPost]
        public ActionResult SaveDetails(CustomerDetails dto)
        {
            bool isSuccess = false;
            string alertMessage = string.Empty;


            if (ModelState.IsValid)
            {
                dto.CustomerId = 0;

                var duplicate = _commonServices.GetAllCustomers().Where(m => m.CustomerName == dto.CustomerName && m.CustomerCode == dto.CustomerCode).Count();

                if (duplicate >= 1)
                {
                    alertMessage = (string.Format(Messages.DuplicateItem, "Customer"));
                }
                else
                {

                    if (!this._commonServices.SaveDetailsCustomers(dto))
                    {
                        alertMessage = string.Format(Messages.ErrorOccuredDuringProcessingThis, "saving in customer");
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
        public ActionResult UpdateDetails(CustomerDetails dto)
        {
            bool isSuccess = false;
            string alertMessage = string.Empty;

            if (ModelState.IsValid)
            {
                var duplicate = _commonServices.GetAllCustomers().Where(c => c.CustomerName == dto.CustomerName && c.CustomerCode == dto.CustomerCode && c.CustomerId != dto.CustomerId).Count();

                if (duplicate >= 1)
                {
                    alertMessage = (string.Format(Messages.DuplicateItem, "Customer"));
                }
                else
                {
                    if (!this._commonServices.UpdateDetailsCustomers(dto))
                    {
                        alertMessage = string.Format(Messages.ErrorOccuredDuringProcessingThis, "updating in customers");
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

        private IQueryable<CustomerDetails> GetDetail(CustomerSearchModel searchModel)
        {

            IQueryable<CustomerDetails> list = null;

            if (!searchModel.HasAnyValue())
            {
                list = _commonServices.GetAllCustomers();
            }
            else
            {
                var predicate = PredicateBuilder.True<CustomerDetails>();

                if (!searchModel.CustomerName.IsNull())
                {
                    predicate = predicate.And(c => c.CustomerName.Contains(searchModel.CustomerName));
                }

                if (!searchModel.CustomerCode.IsNull())
                {
                    predicate = predicate.And(c => c.CustomerCode.Contains(searchModel.CustomerCode));
                }

                list = _commonServices.GetAllCustomers().AsExpandable().Where(predicate);

            }

            return list;

        }
    }
}