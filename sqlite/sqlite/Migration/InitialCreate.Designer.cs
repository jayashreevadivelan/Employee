using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using SQLiteAspNetCoreDemo;

namespace SQLiteAspNetCoreDemo.Migrations
{
    [DbContext(typeof(SQLiteDBContext))]
    [Migration("InitialCreate")]
    partial class InitialCreate
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.0.0");

            modelBuilder.Entity("SQLiteAspNetCoreDemo.Employee", b =>
            {
                b.Property<int>("Id")
                    .ValueGeneratedOnAdd()
                    .HasColumnType("INTEGER");

                b.Property<int>("Age")
                    .HasColumnType("INTEGER");

                b.Property<string>("FirstName")
                    .HasColumnType("TEXT");

                b.Property<string>("LastName")
                    .HasColumnType("TEXT");

                b.HasKey("Id");

                b.ToTable("Employees");
            });
        }
    }
}