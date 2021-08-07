using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro2.Entities;
using ASPNetCoreIntro2.Extensions;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro2.Controllers
{
    public class SessionDemooController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        //private string isim = "Engin";
        public string Index1()
        {
            //isim = "Osman";

            Customer customer = new Customer { Id = 1, FirstName = "Engin" };
            HttpContext.Session.SetString("isim", "Engin"); //session oluşturma
            HttpContext.Session.SetObject("musteri", customer);

            return "Session oluştu";
        }
        public string Index2()
        {
            //return isim;        //engin dönecektir.

            //return HttpContext.Session.GetString("isim");   //session okuma
            //üstteki normal session alttaki object session
            var customer = HttpContext.Session.GetObject<Customer>("musteri");
            return customer.FirstName;      //budA 2.
        }
    }
}