using ASPNetCoreIntro2.Entities;
using Microsoft.AspNetCore.Mvc.Rendering;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ASPNetCoreIntro2.Models
{
    public class SaveCustomerViewModel  //customer'a gönderilecek tüm datalar burda toplanır
    {
        public Customer Customer { get; set; }
        public List<SelectListItem> Cities { get; set; }
        //prop
    }
}
