using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro2.Entities;
using ASPNetCoreIntro2.Models;
using ASPNetCoreIntro2.Services.Logging;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace ASPNetCoreIntro2.Controllers
{
    [Route("deneme")]
    public class CustomerController : Controller
    {
        //DEPENDENCY INJECTION
        private ILogger _logger;
        public CustomerController(ILogger logger)
        {
            this._logger = logger;
        }
        //DEPENDENCY INJECTION//





        public IActionResult Index()
        {
            return View();
        }

        [Route("index3")]
        [Route("")]         //bu ise default olarak sadece deneme yazılırsa bu açılsın demektir.
        [Route("~/anasayfa")]
        public IActionResult Index3()   //view döndürebilmek için IActionResult yazılır.
        {

            /*
            DatabaseLogger logger = new DatabaseLogger();
            logger.Log("deneme");
            */

            _logger.Log("Mesaj");


            List<Customer> customers = new List<Customer>
            {
                new Customer {Id=1, FirstName="Engin", LastName="Demirog", City="Ankara"},
                new Customer {Id=2, FirstName="Can", LastName="Yuksel", City="Samsun"}
            };
            List<string> shops = new List<string>
            {
                "Ankara", "İzmir", "İstanbul"
            };
            var model = new CustomerListViewModel
            {
                Customers = customers,
                Shops = shops
            };
            return View(model);
        }


        [HttpGet]
        [Route("save")]
        //üzerine birşey yazılmayan herşey [HttpGet]
        public IActionResult SaveCustomer()
        {
            return View(new SaveCustomerViewModel
            {
                Cities = new List<SelectListItem>
                {
                    new SelectListItem{Text = "Ankara", Value= "06"},
                    new SelectListItem{Text = "İzmir", Value= "35"},
                    new SelectListItem{Text = "İstanbul", Value= "34"}
                }
            });  //SaveCustomer da sayfa açılınca bu çalışcak
        }

        [HttpPost]
        [Route("save")]
        public string SaveCustomer(Customer customer)
        {
            return "Kaydedildi";    //post yapınca da bu çalışıcak
        }
    }
}