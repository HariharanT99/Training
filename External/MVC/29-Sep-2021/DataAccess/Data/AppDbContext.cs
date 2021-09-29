using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Data
{
    public class AppDbContext : IdentityDbContext
    {

        //public class OptionsBuild
        //{
        //    public OptionsBuild()
        //    {
        //        settings = new AppConfiguration();
        //        opsBuilder = new DbContextOptionsBuilder<AppDbContext>();
        //        opsBuilder.UseSqlServer(settings.sqlConnectionString);
        //        dbOptions = opsBuilder.Options;
        //    }

        //    public DbContextOptionsBuilder<AppDbContext> opsBuilder { get; set; }
        //    public DbContextOptions<AppDbContext> dbOptions { get; set; }
        //    private AppConfiguration settings { get; set; }
        //}
        public AppDbContext(DbContextOptions<AppDbContext> options): base(options)
        {

        }


    }
}
