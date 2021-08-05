using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ASPNetCoreIntro2.Entities;
using ASPNetCoreIntro2.Models;
using Microsoft.AspNetCore.Mvc;

namespace ASPNetCoreIntro2.Controllers
{
    public class ProductController : Controller
    {
        public List<string> Shops { get; private set; }

        /*
public string Index()    //bu şu anlama gelir
{                         
return "Hello Worald";               //http://canyuksel.com/product/index
}
*/
        public IActionResult Index()    //bu şu anlama gelir
        {
            return View();               //http://canyuksel.com/product/index
        }
        public string Index2(int id)    //bu şu anlama gelir
        {
            return id.ToString();       //http://canyuksel.com/product/index2/id
        }
        
    }
}