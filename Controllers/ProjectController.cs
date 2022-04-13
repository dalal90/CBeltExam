using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using BeltExam.Models;
using System.Linq;
using Microsoft.AspNetCore.Http;
using System;

namespace BeltExam.Controllers
{
    public class ProjectController: Controller
    {
        private MyContext _context;
        public ProjectController(MyContext context)
        {
            _context = context;
        }

        [HttpGet("dashboard")]
        public IActionResult Dashboard()
        {
            if (HttpContext.Session.GetInt32("uid") != null)
            {
                List<Hobby> allHobbies = _context.Hobbies
                .Include( e => e.Creator)
                .Include( e => e.Enthusiasts)
                .ThenInclude( a => a.HobbiesUsers)
                .ToList();
                return View("Dashboard", allHobbies);
                
            }
            else
            {
                return RedirectToAction("NotLoggedIn");
            }
        }
        [HttpGet("not_logged_in")]
        public ViewResult NotLoggedIn()
        {
            return View("LogError");
        }

        [HttpGet("logout")]
        public RedirectToActionResult Logout()
        {
            HttpContext.Session.Clear();
            return RedirectToAction("Index", "User");
        }
        [HttpGet("hobby/new")]
        public ViewResult NewHobby()
        {
            return View();
        }
        
        [HttpPost("hobby/process")]
        public IActionResult ProcessNewHobby(Hobby newHobby)
        {
            if (ModelState.IsValid)
            {
                    newHobby.UserId = (int)HttpContext.Session.GetInt32("uid");
                    _context.Hobbies.Add(newHobby);
                    _context.SaveChanges();
                    return Redirect($"/hobby/{newHobby.HobbyId}");
                
            }
            else 
            {
                return View("NewHobby");
            }
        }
        [HttpGet("hobby/{eid}")]
        public ViewResult HobbyDetail(int eid)
        {
            Hobby thisHobby = _context.Hobbies
            .Include( e => e.Enthusiasts)
            .ThenInclude( a => a.HobbiesUsers)
            .FirstOrDefault(e => e.HobbyId == eid);
            return View("Detail", thisHobby);
        }
        [HttpGet("hobby/join/{eid}")]
        public RedirectToActionResult JoinHobby(int eid)
        {
            Association thisPerson = new Association();
            thisPerson.UserId = (int)HttpContext.Session.GetInt32("uid");
            thisPerson.HobbyId = eid;
            _context.Associations.Add(thisPerson);
            _context.SaveChanges();
            return RedirectToAction("Dashboard");
        }
    }
}