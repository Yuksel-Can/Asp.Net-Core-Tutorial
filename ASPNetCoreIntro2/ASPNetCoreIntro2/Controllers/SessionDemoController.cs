using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro2.Entities;
using ASPNetCoreIntro2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro2.Controllers
{
    public class SessionDemoController : Controller
    {

        //private string isim = "Engin";
        public string Index1()
        {
            //isim = "Osman";

            //HttpContext.Session.SetString("isim", "Engin"); //session oluşturma
            return "Sessiın oluştu";
        }
        public string Index2()
        {
            //return isim;        //engin dönecektir.

            //return HttpContext.Session.GetString("isim");   //session okuma
            return "deneme";
        }
    }
}
