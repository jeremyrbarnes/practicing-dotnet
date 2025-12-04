using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConferenceAttendees.Api.Migrations
{
    /// <inheritdoc />
    public partial class InitialCreate : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Genders",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genders", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "JobRoles",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_JobRoles", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "ReferralSources",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_ReferralSources", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Attendees",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    FirstName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(50)", maxLength: 50, nullable: false),
                    EmailAddress = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    PhoneNumber = table.Column<string>(type: "nvarchar(14)", maxLength: 14, nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(150)", maxLength: 150, nullable: false),
                    ReferralSourceId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    JobRoleId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    GenderId = table.Column<Guid>(type: "uniqueidentifier", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Attendees", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Attendees_Genders_GenderId",
                        column: x => x.GenderId,
                        principalTable: "Genders",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendees_JobRoles_JobRoleId",
                        column: x => x.JobRoleId,
                        principalTable: "JobRoles",
                        principalColumn: "Id");
                    table.ForeignKey(
                        name: "FK_Attendees_ReferralSources_ReferralSourceId",
                        column: x => x.ReferralSourceId,
                        principalTable: "ReferralSources",
                        principalColumn: "Id");
                });

            migrationBuilder.InsertData(
                table: "Genders",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("995dd6e5-6a17-4f7d-9e61-7563ce443317"), "Male" },
                    { new Guid("bef000a6-0b2e-4ae9-9202-4afadc772b68"), "Female" }
                });

            migrationBuilder.InsertData(
                table: "JobRoles",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("b441ab89-404a-406e-8915-04ef7e1a2ab4"), "Supervisor" },
                    { new Guid("bdf05908-cb76-4bfc-870f-0b549d2ee80e"), "Manager" },
                    { new Guid("e950a843-bfd2-4c0c-bf27-a5d338600b3c"), "Employee" }
                });

            migrationBuilder.InsertData(
                table: "ReferralSources",
                columns: new[] { "Id", "Name" },
                values: new object[,]
                {
                    { new Guid("45ed833d-6954-4b54-b6c0-8e5b3817ac8f"), "Internet Advertisement" },
                    { new Guid("5d951b9e-d7cd-4914-b7fd-5f44b42dfe9f"), "Television" },
                    { new Guid("a9bc3e61-de20-44bf-b834-e21e035ae706"), "Newspaper Article" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_GenderId",
                table: "Attendees",
                column: "GenderId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_JobRoleId",
                table: "Attendees",
                column: "JobRoleId");

            migrationBuilder.CreateIndex(
                name: "IX_Attendees_ReferralSourceId",
                table: "Attendees",
                column: "ReferralSourceId");

            migrationBuilder.CreateIndex(
                name: "IX_Genders_Name",
                table: "Genders",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_JobRoles_Name",
                table: "JobRoles",
                column: "Name",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_ReferralSources_Name",
                table: "ReferralSources",
                column: "Name",
                unique: true);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Attendees");

            migrationBuilder.DropTable(
                name: "Genders");

            migrationBuilder.DropTable(
                name: "JobRoles");

            migrationBuilder.DropTable(
                name: "ReferralSources");
        }
    }
}
