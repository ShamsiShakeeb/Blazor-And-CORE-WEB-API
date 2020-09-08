using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ApiAndBlazor.Controllers
{
   
    
    public class InformationController : Controller
    {
        [Route("api/Information")]
        public ActionResult GetInfos()
        {
            var Obj = new Info()
            {
                Name = "Shamsi",
                Address = "Dhaka",
                Phone = "019",
            };
            var Obj1 = new Info()
            {
                Name = "Washiq",
                Address = "Mirpur",
                Phone = "017",
            };
            var Obj2 = new Info()
            {
                Name = "Shakeeb",
                Address = "Savar",
                Phone = "011",
            };

            List<Info> data = new List<Info>();
            data.Add(Obj); data.Add(Obj1); data.Add(Obj2);
            return Json( new { success=true, value = data } );
        }
        struct Info
        {
            public String Name { set; get; }
            public String Address { set; get; }
            public String Phone { set; get; }
        }
    }
}