using System;
using System.Collections.Generic;
using System.Text;
using DitsPortal.Common.Responses;
using DitsPortal.DataAccess.DBEntities;
using DitsPortal.DataAccess.DBEntities.Base;
using Microsoft.EntityFrameworkCore;

namespace DitsPortal.DataAccess.Data
{
    public class ApplicationDBContext: DbContext
    {
        public ApplicationDBContext(DbContextOptions options) : base(options)
        {

        }

        public DbSet<User> Users { get; set; }
        public DbSet<GlobalCodes> GlobalCodes { get; set; }
        public DbSet<GlobalCodeCategories> GlobalCodeCategories { get; set; }
        public DbSet<AnnualHolidays> AnnualHoliday { get; set; }
        public DbSet<Leaves> Leave { get; set; }
        public DbSet<LeavesBalance> LeavesBalance { get; set; }
        public DbSet<ErrorLog> ErrorLog { get; set; }


    }
}
