using System;
using System.Data;
using System.Linq;
using System.Web.Mvc;
using DevNext.Web.Filters;
using DevNext.Web.Models;
using DevNext.Web.Models.ViewModel;

namespace DevNext.Web.Controllers
{
    [InitializeSimpleMembership]
    [Authorize]
    public class EventController : Controller
    {
        private readonly DevNextDbContext _context = new DevNextDbContext();

        [HttpGet]
        [AllowAnonymous]
        public ViewResult Index()
        {
            EventListView listView = new EventListView
                {
                    PastEvents = _context.Events.Where(e => e.EndDateTime < DateTime.UtcNow),
                    UpcomingEvents = _context.Events.Where(e => e.EndDateTime >= DateTime.UtcNow)
                };
            return View(listView);
        }

        [HttpGet]
        [AllowAnonymous]
        public ViewResult Details(int id)
        {
            UserGroupEvent eventinfo = _context.Events.Single(x => x.Id == id);
            ViewBag.IsUserAlreadyRegistered = false;
            if (User.Identity.IsAuthenticated)
            {
                UserProfile user = _context.UserProfiles.Single(u => u.UserName == User.Identity.Name);
                if (eventinfo.RegisteredUsers.Contains(user))
                    ViewBag.IsUserAlreadyRegistered = true;
            }
            return View(eventinfo);
        }

        [HttpGet]
        public ActionResult Create()
        {
            return View();
        }

        [HttpPost]
        [Authorize(Roles = "CommunityLeader")]
        [ValidateAntiForgeryToken]
        public ActionResult Create(UserGroupEvent eventinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Events.Add(eventinfo);
                _context.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(eventinfo);
        }

        [HttpGet]
        [Authorize(Roles = "CommunityLeader")]
        public ActionResult Edit(int id)
        {
            UserGroupEvent eventinfo = _context.Events.Single(x => x.Id == id);
            return View(eventinfo);
        }

        [HttpPost]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CommunityLeader")]
        public ActionResult Edit(UserGroupEvent eventinfo)
        {
            if (ModelState.IsValid)
            {
                _context.Entry(eventinfo).State = EntityState.Modified;
                _context.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(eventinfo);
        }

        [HttpGet]
        [Authorize(Roles = "CommunityLeader")]
        public ActionResult Delete(int id)
        {
            UserGroupEvent eventinfo = _context.Events.Single(x => x.Id == id);
            return View(eventinfo);
        }

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        [Authorize(Roles = "CommunityLeader")]
        public ActionResult DeleteConfirmed(int id)
        {
            UserGroupEvent eventinfo = _context.Events.Single(x => x.Id == id);
            _context.Events.Remove(eventinfo);
            _context.SaveChanges();
            return RedirectToAction("Index");
        }

        [HttpPost, ActionName("Register")]
        [Authorize]
        public ActionResult RegisterForEvent(int eventId)
        {
            try
            {
                UserGroupEvent userGroupEvent = _context.Events.Single(x => x.Id == eventId);
                UserProfile user = _context.UserProfiles.Single(u => u.UserName == User.Identity.Name);
                if (userGroupEvent.RegisteredUsers.Contains(user))
                    return Json(new {response = true, message = "You have already registered to attend this event!"});
                userGroupEvent.RegisteredUsers.Add(user);
                _context.Entry(userGroupEvent).State = EntityState.Modified;
                _context.SaveChanges();
                return Json(new {response = true, message = "We are glad to see you are coming " + User.Identity.Name + "!"});
            }
            catch (Exception)
            {
                return
                    Json(
                        new
                            {
                                response = false,
                                message =
                            "Sorry we are unable to register you at the moment but we don't want to miss you " + User.Identity.Name +
                            ". Please try again later!"
                            });
            }
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                _context.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}