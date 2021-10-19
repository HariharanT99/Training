using DAL.Interfaces;
using DAL.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Facade
{
    public class Facade
    {
        private readonly IDapper _dapper;

        public Facade(IDapper dapper)
        {
            this._dapper = dapper;
        }

        //Insert Applicant

        public void CreateApplicant(Applicant model)
        {
            _dapper.CreateApplicant(model);
        }


        //Get Applicants
        public List<Applicant> GetApplicants()
        {
            var applicants = _dapper.GetApplicants();

            return applicants;
        }
    }
}
