using DAL.Facade;
using DAL.Method;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class ApplicantBL
    {
        private readonly Facade _facade;

        public ApplicantBL(Facade facade)
        {
            this._facade = facade;
        }

        //Create Applicant

        public void CreateApplicant(Applicant model)
        {
            _facade.CreateApplicant(model);
        }

        //Get Applicants

        public List<Applicant> GetApplicants()
        {
            var applicants = _facade.GetApplicants();

            return applicants;
        }
    }
}
