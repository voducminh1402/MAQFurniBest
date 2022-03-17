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
using Microsoft.AspNetCore.WebUtilities;
using System.Text;
using Microsoft.Extensions.Logging;
using Microsoft.AspNetCore.Authorization;

namespace MAQFurni.Controllers
{
    [Authorize(Roles = "User")]
    public class ChangeInfoController : Controller
    {
        private readonly UserManager<User> _userManager;
        private readonly SignInManager<User> _signInManager;

        private readonly FurnitureShopContext _context;

        private readonly ILogger<ChangeInfoController> _logger;


        public ChangeInfoController(ILogger<ChangeInfoController> logger, FurnitureShopContext context, UserManager<User> userManager, SignInManager<User> signInManager)
        {
            _context = context;
            _userManager = userManager;
            _signInManager = signInManager;
            _logger = logger;
        }
        //
        // GET: /Products/

        [HttpPost("user/change-info")]
        [ActionName("ChangeInfor")]
        public ActionResult ChangeInfor(string name, string phone)
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            var user = _context.Users.SingleOrDefault(o => o.Id == userId);
            if (name.Trim().Length == 0 || phone.Trim().Length == 0)
                return View("ChangeInfo", user);

            // user.UserName = name.Trim();
            user.NormalizedUserName = name.Trim().ToUpper();
            user.PhoneNumber = phone.Trim();
            _context.Users.Update(user);
            _context.SaveChanges();
            // Add action logic here
            return View("ChangeInfo", user);
        }

        [HttpPost("user/change-password")]
        [ActionName("ChangePassword")]
        public async Task<ActionResult> ChangePasswordAsync(string newPassword, string confirmPassword)
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            var user = _context.Users.SingleOrDefault(o => o.Id == userId);
            if (newPassword == null || confirmPassword == null)
            {
                ViewBag.Fail = "Change password fail!";
                return View("ChangeInfo", user);
            }

            if (newPassword.Trim().Length == 0 || confirmPassword.Trim().Length == 0)
            {
                ViewBag.Fail = "Change password fail!";
                return View("ChangeInfo", user);
            }



            var code = await _userManager.GeneratePasswordResetTokenAsync(user);
            // code = Encoding.UTF8.GetString(WebEncoders.Base64UrlDecode(code));

            var result = await _userManager.ResetPasswordAsync(user, code, newPassword);
            if (result.Succeeded)
            {
                _logger.LogInformation("User change password success.");
                IndexViewModel ivm = new IndexViewModel();
                ivm.ListCategory = await _context.Categories.ToListAsync();
                ivm.ListProduct = await _context.Products.ToListAsync();
                ViewBag.Success = "Change password success!";
                return View("ChangeInfo");
            }
            _logger.LogError("User change password fail");
            // Add action logic here
            ViewBag.Fail = "Change password fail!";
            return View("ChangeInfo");
        }
        [HttpGet("user/change-user-info")]
        [ActionName("ChangeInfo")]
        public ActionResult ChangeInfo()
        {
            var userId = _userManager.GetUserId(User);
            if (!_signInManager.IsSignedIn(User))
                return Redirect("https://localhost:5001/login");
            var user = _context.Users.SingleOrDefault(o => o.Id == userId);
            // Add action logic here
            return View(user);
        }

    }
}