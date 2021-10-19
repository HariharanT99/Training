using BL;
using DAL.Model;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ApplicantController : Controller
    {
        private readonly ApplicantBL _applicantBL;

        public ApplicantController(ApplicantBL applicantBL)
        {
            this._applicantBL = applicantBL;
        }

        //Create Applicant

        [HttpPost]
        public void PostApplicant(Applicant model)
        {
            _applicantBL.CreateApplicant(model);
        }


        [HttpGet]
        //Get Applicants
        public List<Applicant> GetApplicants()
        {
            var applicants = _applicantBL.GetApplicants();

            return applicants;
        }


    }
}
