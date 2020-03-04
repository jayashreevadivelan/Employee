using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore.Migrations;
using System.Data;

namespace SQLiteAspNetCoreDemo.Migrations
{
    public partial class InitialCreate : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Employee",
                columns:table=> new
                {
                    Id = table.Column<int>(nullable: false)
                    .Annotation("Sqlite:Autoincrement",true),
                    FirstName=table.Column<string>(nullable:true),
                    LastName=table.Column<string>(nullable:true),
                    Age=table.Column<int>(nullable:false)
                },

                constraints:table=>
                {
                    table.PrimaryKey("PK_Employees", x => x.Id);

                } );

        }
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Employees");
        }
    }
}
