using JobQuest.Data;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace JobQuest.Web.Controllers
{

    [Authorize(Roles = "Recruiter")]
    public class RecruiterController : Controller
    {
        JobQuestEntities e = new JobQuestEntities();
        //
        // GET: /Recruiter/
        public ActionResult Index()
        {
            return View();
        }


        public ActionResult CreateJob()
        {
            return View(new Job());
        }

        [HttpPost]
        public ActionResult CreateJob(Job job)
        {
            job.IsPublished = true;
            e.Jobs.Add(job);
            e.SaveChanges();
            return View();
        }
        public ActionResult ListJob()
        {

            return View(e.Jobs.Where(a=>a.IsPublished==true).ToList());

        }

        public ActionResult EditJob(int id)
        {

            return View(e.Jobs.SingleOrDefault(a => a.JobID == id));
        }

        [HttpPost]
        public ActionResult EditJob(Job job)
        {

            e.Entry(job).State=EntityState.Modified;
            e.SaveChanges();
             return RedirectToAction("ListJob");

            

            

        }

        public ActionResult DeleteJob(int id)
        {
            Job job = e.Jobs.Find(id);
            job.IsPublished = false;
            e.Entry(job).State = EntityState.Modified;
            e.SaveChanges();
            return RedirectToAction("ListJob");
        }

    }
}