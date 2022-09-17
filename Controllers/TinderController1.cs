using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace SignUp_SignIn.Controllers
{
    public class TinderController1 : Controller
    {
        public ViewResult  SignIn()
        {
            return View();
        }
    }
}
