﻿using Entitiess.Concrete;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Concrete.EntityFramework.Context
{
    public class EmployeeDbContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=VELI\SQLEXPRESS;Database=EmployeeDb;Integrated Security=true;TrustServerCertificate=True");
        }

        public DbSet<Department> Departments { get; set; }

        public DbSet<Employee> Employees { get; set; }

        public DbSet<OffDay> OffDays { get; set; }

        public DbSet<PayrollParameter> PayrollParameters { get; set; }

        public DbSet<Payroll> Payrolls { get; set; }

    }
}
