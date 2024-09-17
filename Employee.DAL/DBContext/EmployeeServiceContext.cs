using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Employee.Domain.Model.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Internal;


namespace Employee.DAL
{
    public class EmployeeServiceContext: DbContext
    {
        public EmployeeServiceContext(DbContextOptions<EmployeeServiceContext> options) : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            
            modelBuilder.Entity<EmpTable>().HasKey(e => e.EmpId);

        }
       
        public DbSet<EmpTable> EmpTable { get; set; }
        

    }
}

