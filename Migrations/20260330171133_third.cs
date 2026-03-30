using System;
using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssociationWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class third : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_Members_MemberId",
                table: "Dues");

            migrationBuilder.DropForeignKey(
                name: "FK_Dues_Revenue_RevenueId",
                table: "Dues");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Safe_SafeId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Members_Address_AddressId",
                table: "Members");

            migrationBuilder.DropTable(
                name: "Corporate");

            migrationBuilder.DropTable(
                name: "Individual");

            migrationBuilder.DropTable(
                name: "MeetingMember");

            migrationBuilder.DropTable(
                name: "Revenue");

            migrationBuilder.DropTable(
                name: "AuthorizedPerson");

            migrationBuilder.DropTable(
                name: "Address");

            migrationBuilder.DropIndex(
                name: "IX_Members_AddressId",
                table: "Members");

            migrationBuilder.RenameColumn(
                name: "AddressId",
                table: "Members",
                newName: "Address_StateId");

            migrationBuilder.RenameColumn(
                name: "RevenueId",
                table: "Dues",
                newName: "IncomeId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_RevenueId",
                table: "Dues",
                newName: "IX_Dues_IncomeId");

            migrationBuilder.AddColumn<string>(
                name: "AccountHolder",
                table: "Safe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "AccountNumber",
                table: "Safe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "AssociationId",
                table: "Safe",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "BranchName",
                table: "Safe",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "Address_CityId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Address_CountryId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Address_DistrictId",
                table: "Members",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Address_OpenAddress",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "Address_PostalCode",
                table: "Members",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<DateTime>(
                name: "BRD",
                table: "Members",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "BRN",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "BirthDate",
                table: "Members",
                type: "datetime2",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Birthplace",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "CorporateName",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "EducationStatus",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FaxNumber",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "FinancialMail",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "NationalIdentityNumber",
                table: "Members",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Occupation",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Surname",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxNumber",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "TaxOffice",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Website",
                table: "Members",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<DateTime>(
                name: "DueDate",
                table: "Dues",
                type: "datetime2",
                nullable: false,
                defaultValue: new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified));

            migrationBuilder.CreateTable(
                name: "Association",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_OpenAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_DistrictId = table.Column<int>(type: "int", nullable: false),
                    Address_CityId = table.Column<int>(type: "int", nullable: false),
                    Address_StateId = table.Column<int>(type: "int", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Association", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Income",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Type = table.Column<int>(type: "int", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    SafeId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Income", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Income_Safe_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safe",
                        principalColumn: "Id");
                });

            migrationBuilder.CreateTable(
                name: "IncomingDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Sender = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FolderPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false),
                    ExtraInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IncomingDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "IndividualMeetingParticipants",
                columns: table => new
                {
                    IndividualParticipantsId = table.Column<int>(type: "int", nullable: false),
                    MeetingsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_IndividualMeetingParticipants", x => new { x.IndividualParticipantsId, x.MeetingsId });
                    table.ForeignKey(
                        name: "FK_IndividualMeetingParticipants_Meeting_MeetingsId",
                        column: x => x.MeetingsId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_IndividualMeetingParticipants_Members_IndividualParticipantsId",
                        column: x => x.IndividualParticipantsId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "InternalDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FolderPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false),
                    ExtraInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InternalDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "OutgoingDocuments",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Receiver = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    RegistrationNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    FolderPath = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FileType = table.Column<int>(type: "int", nullable: false),
                    ExtraInformation = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_OutgoingDocuments", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Representative",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Gender = table.Column<int>(type: "int", nullable: false),
                    NationalIdentityNumber = table.Column<int>(type: "int", nullable: false),
                    ParentName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Title = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationStatus = table.Column<int>(type: "int", nullable: false),
                    RepresentationStartDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    CorporateId = table.Column<int>(type: "int", nullable: false),
                    Address_OpenAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_DistrictId = table.Column<int>(type: "int", nullable: false),
                    Address_CityId = table.Column<int>(type: "int", nullable: false),
                    Address_StateId = table.Column<int>(type: "int", nullable: false),
                    Address_PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address_CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Representative", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Representative_Members_CorporateId",
                        column: x => x.CorporateId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Administrator",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AuthorizationLevel = table.Column<int>(type: "int", nullable: false),
                    RegisterDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Email = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Phone = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdentityNumber = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: true),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    AssociationId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Administrator", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Administrator_Association_AssociationId",
                        column: x => x.AssociationId,
                        principalTable: "Association",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "RepresentativeMeetingParticipants",
                columns: table => new
                {
                    MeetingsId = table.Column<int>(type: "int", nullable: false),
                    RepresentativeParticipantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_RepresentativeMeetingParticipants", x => new { x.MeetingsId, x.RepresentativeParticipantsId });
                    table.ForeignKey(
                        name: "FK_RepresentativeMeetingParticipants_Meeting_MeetingsId",
                        column: x => x.MeetingsId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_RepresentativeMeetingParticipants_Representative_RepresentativeParticipantsId",
                        column: x => x.RepresentativeParticipantsId,
                        principalTable: "Representative",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Safe_AssociationId",
                table: "Safe",
                column: "AssociationId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Administrator_AssociationId",
                table: "Administrator",
                column: "AssociationId");

            migrationBuilder.CreateIndex(
                name: "IX_Income_SafeId",
                table: "Income",
                column: "SafeId");

            migrationBuilder.CreateIndex(
                name: "IX_IndividualMeetingParticipants_MeetingsId",
                table: "IndividualMeetingParticipants",
                column: "MeetingsId");

            migrationBuilder.CreateIndex(
                name: "IX_Representative_CorporateId",
                table: "Representative",
                column: "CorporateId");

            migrationBuilder.CreateIndex(
                name: "IX_RepresentativeMeetingParticipants_RepresentativeParticipantsId",
                table: "RepresentativeMeetingParticipants",
                column: "RepresentativeParticipantsId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_Income_IncomeId",
                table: "Dues",
                column: "IncomeId",
                principalTable: "Income",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_Members_MemberId",
                table: "Dues",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Safe_SafeId",
                table: "Expense",
                column: "SafeId",
                principalTable: "Safe",
                principalColumn: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_Safe_Association_AssociationId",
                table: "Safe",
                column: "AssociationId",
                principalTable: "Association",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Dues_Income_IncomeId",
                table: "Dues");

            migrationBuilder.DropForeignKey(
                name: "FK_Dues_Members_MemberId",
                table: "Dues");

            migrationBuilder.DropForeignKey(
                name: "FK_Expense_Safe_SafeId",
                table: "Expense");

            migrationBuilder.DropForeignKey(
                name: "FK_Safe_Association_AssociationId",
                table: "Safe");

            migrationBuilder.DropTable(
                name: "Administrator");

            migrationBuilder.DropTable(
                name: "Income");

            migrationBuilder.DropTable(
                name: "IncomingDocuments");

            migrationBuilder.DropTable(
                name: "IndividualMeetingParticipants");

            migrationBuilder.DropTable(
                name: "InternalDocuments");

            migrationBuilder.DropTable(
                name: "OutgoingDocuments");

            migrationBuilder.DropTable(
                name: "RepresentativeMeetingParticipants");

            migrationBuilder.DropTable(
                name: "Association");

            migrationBuilder.DropTable(
                name: "Representative");

            migrationBuilder.DropIndex(
                name: "IX_Safe_AssociationId",
                table: "Safe");

            migrationBuilder.DropColumn(
                name: "AccountHolder",
                table: "Safe");

            migrationBuilder.DropColumn(
                name: "AccountNumber",
                table: "Safe");

            migrationBuilder.DropColumn(
                name: "AssociationId",
                table: "Safe");

            migrationBuilder.DropColumn(
                name: "BranchName",
                table: "Safe");

            migrationBuilder.DropColumn(
                name: "Address_CityId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Address_CountryId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Address_DistrictId",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Address_OpenAddress",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Address_PostalCode",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BRD",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BRN",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "BirthDate",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Birthplace",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "CorporateName",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "EducationStatus",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "FaxNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "FinancialMail",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "NationalIdentityNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Occupation",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Surname",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TaxNumber",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "TaxOffice",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "Website",
                table: "Members");

            migrationBuilder.DropColumn(
                name: "DueDate",
                table: "Dues");

            migrationBuilder.RenameColumn(
                name: "Address_StateId",
                table: "Members",
                newName: "AddressId");

            migrationBuilder.RenameColumn(
                name: "IncomeId",
                table: "Dues",
                newName: "RevenueId");

            migrationBuilder.RenameIndex(
                name: "IX_Dues_IncomeId",
                table: "Dues",
                newName: "IX_Dues_RevenueId");

            migrationBuilder.CreateTable(
                name: "Address",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    City = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Country = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    District = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    OpenAddress = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    PostalCode = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    State = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Address", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Individual",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    EducationStatus = table.Column<int>(type: "int", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdentityNumber = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Individual", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Individual_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "MeetingMember",
                columns: table => new
                {
                    MeetingsId = table.Column<int>(type: "int", nullable: false),
                    ParticipantsId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_MeetingMember", x => new { x.MeetingsId, x.ParticipantsId });
                    table.ForeignKey(
                        name: "FK_MeetingMember_Meeting_MeetingsId",
                        column: x => x.MeetingsId,
                        principalTable: "Meeting",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_MeetingMember_Members_ParticipantsId",
                        column: x => x.ParticipantsId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Revenue",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    SafeId = table.Column<int>(type: "int", nullable: false),
                    Amount = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Date = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Description = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Iban = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Source = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Type = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Revenue", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Revenue_Safe_SafeId",
                        column: x => x.SafeId,
                        principalTable: "Safe",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "AuthorizedPerson",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AddressId = table.Column<int>(type: "int", nullable: false),
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    BirthDate = table.Column<DateTime>(type: "datetime2", nullable: false),
                    Birthplace = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Name = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    NationalIdentityNumber = table.Column<int>(type: "int", nullable: false),
                    Occupation = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Surname = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AuthorizedPerson", x => x.Id);
                    table.ForeignKey(
                        name: "FK_AuthorizedPerson_Address_AddressId",
                        column: x => x.AddressId,
                        principalTable: "Address",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_AuthorizedPerson_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Corporate",
                columns: table => new
                {
                    MemberId = table.Column<int>(type: "int", nullable: false),
                    AuthorizedPersonId = table.Column<int>(type: "int", nullable: false),
                    BRD = table.Column<DateTime>(type: "datetime2", nullable: false),
                    BRN = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CompanyName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    FaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxNumber = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    TaxOffice = table.Column<string>(type: "nvarchar(max)", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Corporate", x => x.MemberId);
                    table.ForeignKey(
                        name: "FK_Corporate_AuthorizedPerson_AuthorizedPersonId",
                        column: x => x.AuthorizedPersonId,
                        principalTable: "AuthorizedPerson",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Corporate_Members_MemberId",
                        column: x => x.MemberId,
                        principalTable: "Members",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Members_AddressId",
                table: "Members",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizedPerson_AddressId",
                table: "AuthorizedPerson",
                column: "AddressId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_AuthorizedPerson_MemberId",
                table: "AuthorizedPerson",
                column: "MemberId",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_Corporate_AuthorizedPersonId",
                table: "Corporate",
                column: "AuthorizedPersonId");

            migrationBuilder.CreateIndex(
                name: "IX_MeetingMember_ParticipantsId",
                table: "MeetingMember",
                column: "ParticipantsId");

            migrationBuilder.CreateIndex(
                name: "IX_Revenue_SafeId",
                table: "Revenue",
                column: "SafeId");

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_Members_MemberId",
                table: "Dues",
                column: "MemberId",
                principalTable: "Members",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Dues_Revenue_RevenueId",
                table: "Dues",
                column: "RevenueId",
                principalTable: "Revenue",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Expense_Safe_SafeId",
                table: "Expense",
                column: "SafeId",
                principalTable: "Safe",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Members_Address_AddressId",
                table: "Members",
                column: "AddressId",
                principalTable: "Address",
                principalColumn: "Id",
                onDelete: ReferentialAction.Cascade);
        }
    }
}

