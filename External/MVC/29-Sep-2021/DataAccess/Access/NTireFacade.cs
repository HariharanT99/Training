using DAL.Data;
using DAL.Models;
using DAL.Repository;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL.Access
{
    class NTireFacade: INTireFacade
    {
        public readonly IAccountDAL _accountDAL;
        public readonly IEntryDAL _entryDAL;
        private readonly NTireAppContext _db;
        public NTireFacade(IAccountDAL accountDAL, IEntryDAL entryDAL, NTireAppContext db)
        {
            this._accountDAL = accountDAL;
            this._entryDAL = entryDAL;
            this._db = db;
        }

        public IQueryable<AspNetUser> GetUser(string name)
        {
            var user = _db.GetUser(name);

            return user;
        }   


    }
}
