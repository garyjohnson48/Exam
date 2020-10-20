using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using System.Linq;
using Microsoft.AspNetCore.Identity;
using Exam.Models;
using System;
using System.Collections.Generic;

namespace Exam.Controllers
{
     public class ExamController : Controller
    {
	 private MyContext _context;

        public ExamController(MyContext User)
        {
            _context = User;
        } 

        [HttpGet("")]
        public IActionResult Registration()
        {
           
            return View();
        }

        [HttpGet("login")]
        public IActionResult Login()
        {
            return View();
        }


         [HttpPost("Process_Register")]
            public IActionResult Process_Register(User user)
            {
                if (ModelState.IsValid)
                {
                    if(_context.users.Any(u => u.Email == user.Email))
                    {
                        // Manually add a ModelState error to the Email field, with provided
                        // error message
                        ModelState.AddModelError("Email", "Email already in use!");
                        
                        // You may consider returning to the View at this point
                        return View("Registration");
                    }
                    PasswordHasher<User> Hasher = new PasswordHasher<User>();
                    user.Password = Hasher.HashPassword(user, user.Password);

                    _context.Add(user);
                    Console.WriteLine("Added User");
                    _context.SaveChanges();
                    Console.WriteLine("Saved User");
                    return RedirectToAction("Login");
                }
                return View("Registration");

            }

        [HttpPost("Process_Login")]
        public IActionResult Process_Login(Login_User user)
        {
           
            
            if (ModelState.IsValid)
            {
                var val = user.Email;
                HttpContext.Session.SetString("userid", val);

                Console.WriteLine(HttpContext.Session.GetString("userid"));
                Console.WriteLine("Model state seems to be valid");


                User ValidateUser = _context.users
                .FirstOrDefault(d => d.Email == user.Email);
                if (ValidateUser == null)
                {
                    Console.WriteLine("User is null");
                    ModelState.AddModelError("Email", "Invalid Email/Password");
                    return View("Login");
                }

                 var hasher = new PasswordHasher<Login_User>();
            
                // verify provided password against hash stored in db
                var result = hasher.VerifyHashedPassword(user, ValidateUser.Password, user.Password);
                
                // result can be compared to 0 for failure
                if(result == 0)
                {
                    Console.WriteLine("Password is returning 0");
                    // handle failure (this should be similar to how "existing email" is handled)
                     ModelState.AddModelError("Password", "Password Incorrect");
                     return View("Login");
                }

                
                return RedirectToAction("Bright_Ideas");
            }
            Console.WriteLine("Model state seems to be invalid");
            return View("Login");

        }

         [HttpGet("logout")]
            public IActionResult Logout()
            {
                HttpContext.Session.Clear();
                return RedirectToAction("Registration");
            }
            
            [HttpGet("bright_ideas")]
            public IActionResult Bright_Ideas()
            {
              
                if ( HttpContext.Session.GetString("userid") == null)
                {
                    return View("Login");
                }

                var emailuid = HttpContext.Session.GetString("userid");

                ViewBag.user = _context.users
                .FirstOrDefault(l => l.Email == emailuid);

                Idea idea = new Idea();
                ViewBag.allideas = _context.ideas
                .Include(i => i.IdeaCreator)
                .Include(a => a.Likes)
                //Delete this line if you get stuck
                .OrderByDescending(l => l.Likes.Count);

                return View(idea);
            }

            [HttpPost("Add_Idea/{UserId}")]
            public IActionResult Add_Idea(Idea idea, int Userid)
            {
                if(ModelState.IsValid)
                {
                    Console.WriteLine("Idea Model is Valid");
                    idea.UserId = Userid;
                    _context.Add(idea);
                    _context.SaveChanges();

                return RedirectToAction("Bright_Ideas");
                }
                Console.WriteLine("Idea Model is not valid");
                return View("Bright_Ideas");
                
            }

            [HttpGet("like/{IdeaId}")]
            public IActionResult Likes(int IdeaId)
            {
                var uid = HttpContext.Session.GetString("userid");
                var userid = _context.users
                .FirstOrDefault(u => u.Email == uid);

                Like like = new Like();
                like.UserId = userid.UserId;
                like.IdeaId = IdeaId; 

                _context.Add(like);
                _context.SaveChanges();

                return RedirectToAction("Bright_Ideas");
            }

            [HttpGet("bright_ideas/{IdeaId}")]
            public IActionResult Idea(int IdeaId)
            {
               Idea idea= _context.ideas
               .Include(i => i.IdeaCreator)
               .Include(i => i.Likes)
               .ThenInclude(i => i.IdeasLikeByUser)
                .FirstOrDefault(i => i.IdeaId == IdeaId);


                return View(idea);

            }

            [HttpGet("users/{UserId}")]
            public IActionResult UserPage(int UserId)
            {
               ViewBag.user = _context.users
               .Include(l => l.IdeasCreated)
               .Include(l => l.Liked)
                .FirstOrDefault(u => u.UserId == UserId);

                User user = new User();
                return View(user);
            }





    }

}

