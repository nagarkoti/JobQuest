using JobQuest.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JobQuest.Web.Models
{
    public class JobSeekerRegModel
    {
        public JobSeeker jobSeeker{get;set;}
        public RegisterViewModel registerViewModel { get; set; }
    }
}