using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace HospitalManagementSystem.Migrations
{
    public partial class CreateHospitalDB : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Doctors",
                columns: table => new
                {
                    DocID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    DocName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    DocSpciality = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    DocPassword = table.Column<string>(type: "nvarchar(12)", maxLength: 12, nullable: true),
                    Discriminator = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Clinic_Name = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctors", x => x.DocID);
                });

            migrationBuilder.CreateTable(
                name: "Hospitals",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    HospName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    HospLocation = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospType = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Hospitals", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "Juniors",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Degree = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Juniors", x => x.ID);
                });

            migrationBuilder.CreateTable(
                name: "sections",
                columns: table => new
                {
                    SecID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SecName = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patients_gender = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    patient_capacity = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    HospitalID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_sections", x => x.SecID);
                    table.ForeignKey(
                        name: "FK_sections_Hospitals_HospitalID",
                        column: x => x.HospitalID,
                        principalTable: "Hospitals",
                        principalColumn: "ID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Patient",
                columns: table => new
                {
                    PatID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    gender = table.Column<int>(type: "int", nullable: false),
                    PatDOB = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Enternace_Time = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Sickness = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    Perception = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SectionSecID = table.Column<int>(type: "int", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Patient", x => x.PatID);
                    table.ForeignKey(
                        name: "FK_Patient_sections_SectionSecID",
                        column: x => x.SectionSecID,
                        principalTable: "sections",
                        principalColumn: "SecID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateTable(
                name: "Doctor_Pateint",
                columns: table => new
                {
                    ID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    PatientPatID = table.Column<int>(type: "int", nullable: true),
                    DocID = table.Column<int>(type: "int", nullable: false),
                    DoctorDocID = table.Column<int>(type: "int", nullable: true),
                    diagnose = table.Column<string>(type: "nvarchar(max)", nullable: true)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Doctor_Pateint", x => x.ID);
                    table.ForeignKey(
                        name: "FK_Doctor_Pateint_Doctors_DoctorDocID",
                        column: x => x.DoctorDocID,
                        principalTable: "Doctors",
                        principalColumn: "DocID",
                        onDelete: ReferentialAction.Restrict);
                    table.ForeignKey(
                        name: "FK_Doctor_Pateint_Patient_PatientPatID",
                        column: x => x.PatientPatID,
                        principalTable: "Patient",
                        principalColumn: "PatID",
                        onDelete: ReferentialAction.Restrict);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Pateint_DoctorDocID",
                table: "Doctor_Pateint",
                column: "DoctorDocID");

            migrationBuilder.CreateIndex(
                name: "IX_Doctor_Pateint_PatientPatID",
                table: "Doctor_Pateint",
                column: "PatientPatID");

            migrationBuilder.CreateIndex(
                name: "IX_Patient_SectionSecID",
                table: "Patient",
                column: "SectionSecID");

            migrationBuilder.CreateIndex(
                name: "IX_sections_HospitalID",
                table: "sections",
                column: "HospitalID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "Doctor_Pateint");

            migrationBuilder.DropTable(
                name: "Juniors");

            migrationBuilder.DropTable(
                name: "Doctors");

            migrationBuilder.DropTable(
                name: "Patient");

            migrationBuilder.DropTable(
                name: "sections");

            migrationBuilder.DropTable(
                name: "Hospitals");
        }
    }
}
