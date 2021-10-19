using DAL.Interfaces;
using DAL.Model;
using Dapper;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Method
{
    public class Dapper: IDapper
    {
        private readonly string _connectionString;

        public Dapper(string connectionString)
        {
            this._connectionString = connectionString;
        }

        //Insert Applicant

        public void CreateApplicant(Applicant model)
        {
            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                connection.Query("execute uspInsertApplicant @Name, @LastEmployer, @LastDesignation, @AppliedFor, @ReferedBy, @MedicalStatus, @NoticePeriod, @Resume",
                    new
                    {
                        model.Name,
                        model.LastEmployer,
                        model.LastDesignation,
                        model.AppliedFor,
                        model.ReferedBy,
                        model.MedicalStatus,
                        model.NoticePeriod,
                        model.Resume
                    });
            }
        }

        //Get Applicants

        public List<Applicant> GetApplicants()
        {
            List<Applicant> applicants = new();

            using (SqlConnection connection = new SqlConnection(_connectionString))
            {
                applicants = connection.Query<Applicant>("execute uspGetApplicants").ToList();
            }

            return applicants;
        }

    }
}
