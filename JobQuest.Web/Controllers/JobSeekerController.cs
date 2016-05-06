using JobQuest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Security;

namespace JobQuest.Web.Controllers
{
    public class JobSeekerController : Controller
    {
        JobQuestEntities entities = new JobQuestEntities();
        //
        // GET: /JobSeeker/
        public ActionResult Index()
        {
            return View();
        }
        
        public ActionResult EditProfile()
        {
            String userID = Membership.GetUser().ProviderUserKey.ToString();

            JobSeeker jobseeker = entities.JobSeekers.SingleOrDefault(mo => mo.UserID == userID);
            return View(jobseeker);
        }
	}
}