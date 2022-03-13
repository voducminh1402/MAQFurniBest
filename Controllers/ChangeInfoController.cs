using System.Diagnostics;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MAQFurni.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using System;
using Newtonsoft.Json;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace MAQFurni.Controllers
{
    public class ChangeInfoController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly FurnitureShopContext _context; 

        public ChangeInfoController(FurnitureShopContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
        }
        //
        // GET: /Products/

        [HttpPost("user/change-info")]
        [ActionName("ChangeInfo")]
        public ActionResult ChangeInfo(string name, string phone)
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            var user = _context.Users.SingleOrDefault(o => o.Id == userId);
            if (name.Trim().Length == 0 || phone.Trim().Length == 0)
                return View(user);
            
            user.UserName = name.Trim();
            user.PhoneNumber = phone.Trim();
            _context.Users.Update(user);
            _context.SaveChanges(); 
            // Add action logic here
            return View(user);
        }

        public ActionResult Index()
        {
            // Add action logic here
            return View();
        }
    }
}