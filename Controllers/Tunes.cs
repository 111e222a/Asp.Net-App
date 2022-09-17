using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SignUp_SignIn.Controllers
{
    public class Tunes : Controller
    {
        public ViewResult Guitar()
        {
            return View();
        }
        public ViewResult Ukulele()
        {
            return View();
        }
        public ViewResult Spooky()
        {
            return View();
        }
    }
}
