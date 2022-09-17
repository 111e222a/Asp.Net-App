using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SignUp_SignIn.Models;
namespace SignUp_SignIn.Controllers
{
    public class UserController : Controller
    {
        [HttpGet]
        public ViewResult AddUser()
        {
            return View();
        }
        [HttpPost]
        public ViewResult AddUser(User u)
        {
           
                UserRepository.Add(u);
                return View("SignIn");
          
        }
        [HttpPost]
        public ViewResult SignIn()
        {
            return View("SignIn");
        }
        [HttpPost]
        public ViewResult Check(User u)
        {
            bool b=false;

            if(UserRepository.Get(u))
                return View("Home", UserRepository.Users);
            else
                
                return View("SignInMsg");
         

        }
        public ViewResult Home()
        {
            return View();
        }
       public ViewResult Contact()
        {
            //string data = "";
            if(HttpContext.Request.Cookies.ContainsKey("first_req"))
            {
                string fristdate = HttpContext.Request.Cookies["first_req"];
                ViewBag.data = "You submitted this form before";
            }
            else

            {
                
                //CookieOptions option = new CookieOptions();
                //option.Expires=System.DateTime.Now.AddDays(1);
                ViewBag.data = "You visited this page first time";
                HttpContext.Response.Cookies.Append("first_req", System.DateTime.Now.ToString());
            }
            return View("Home");
        }

    }
}
