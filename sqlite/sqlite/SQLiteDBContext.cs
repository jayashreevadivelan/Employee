using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

namespace SQLiteAspNetCoreDemo
{
    class SQLiteDBContext:DbContext
    {
       public DbSet<Employee> Employees { get; set; }
        //public object Employees { get; internal set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
            => options.UseSqlite(@"data source=C:\sqlite\Employee.db");
    }
}

