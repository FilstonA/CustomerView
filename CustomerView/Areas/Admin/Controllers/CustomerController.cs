using CustomerView.DataAccess.Repository.Interfaces;
using CustomerView.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using CustomerView.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Dapper;

namespace CustomerView.Areas.Admin.Controllers
{
    [Area("Admin")]
    public class CustomerController : Controller
    {
        private readonly IUnitOfWork _uow;

        public CustomerController(IUnitOfWork uow)
        {
            _uow = uow;
        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Upsert(int? id)
        {
            Customer customer = new Customer();
            
            if (id == null)
            {
                return View(customer);
            }

            customer = _uow.Customer.get(id.GetValueOrDefault());
            if (customer == null)
            {
                return NotFound();
            }
            return View(customer);
        }

        #region API Calls
        [HttpGet]
        public IActionResult GetAll()
        {
            var allObj = _uow.StoredProcs.List<CustomerViewModel>("dbo.GetCustomerDetails");
            return Json(new { data = allObj });
        }
        #endregion
    }
}
