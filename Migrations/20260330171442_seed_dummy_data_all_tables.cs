using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace AssociationWebAPI.Migrations
{
    /// <inheritdoc />
    public partial class seed_dummy_data_all_tables : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DECLARE @now DATETIME2 = SYSUTCDATETIME();
DECLARE @associationId INT;
DECLARE @safeId INT;
DECLARE @meetingId INT;
DECLARE @individualMemberId INT;
DECLARE @corporateMemberId INT;
DECLARE @representativeId INT;
DECLARE @incomeId INT;

INSERT INTO [Association]
    ([Name], [Description], [Address_OpenAddress], [Address_DistrictId], [Address_CityId], [Address_StateId], [Address_PostalCode], [Address_CountryId])
VALUES
    ('__seed_dummy_all_tables__', 'Seed association row for integration tests', 'Seed Street 1', 1, 1, 1, '34000', 90);

SET @associationId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Safe]
    ([Iban], [Balance], [BankName], [BranchName], [AccountHolder], [AccountNumber], [AssociationId])
VALUES
    ('TR000000000000000000000001', 10000.00, 'Seed Bank', 'Main Branch', 'Seed Holder', 'SEED-ACC-0001', @associationId);

SET @safeId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Meeting]
    ([Date], [Location], [Agenda], [FolderPath])
VALUES
    (@now, 'Seed Meeting Hall', 'Seed agenda', '/seed/meetings/1');

SET @meetingId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Members]
    ([RegistrationDate], [Status], [InactiveDate], [Email], [Phone], [Type], [Address_OpenAddress], [Address_DistrictId], [Address_CityId], [Address_StateId], [Address_PostalCode], [Address_CountryId], [BRD], [BRN], [BirthDate], [Birthplace], [CorporateName], [EducationStatus], [FaxNumber], [FinancialMail], [Name], [NationalIdentityNumber], [Occupation], [Surname], [TaxNumber], [TaxOffice], [Website])
VALUES
    (@now, 0, '9999-12-31T23:59:59.9999999', 'seed.individual@esray.local', '05000000001', 0, 'Seed Member Address 1', 1, 1, 1, '34001', 90, NULL, NULL, '1990-01-01T00:00:00', 'Istanbul', NULL, 3, NULL, NULL, 'Seed', 111111111, 'Engineer', 'Individual', NULL, NULL, NULL);

SET @individualMemberId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Members]
    ([RegistrationDate], [Status], [InactiveDate], [Email], [Phone], [Type], [Address_OpenAddress], [Address_DistrictId], [Address_CityId], [Address_StateId], [Address_PostalCode], [Address_CountryId], [BRD], [BRN], [BirthDate], [Birthplace], [CorporateName], [EducationStatus], [FaxNumber], [FinancialMail], [Name], [NationalIdentityNumber], [Occupation], [Surname], [TaxNumber], [TaxOffice], [Website])
VALUES
    (@now, 0, '9999-12-31T23:59:59.9999999', 'seed.corporate@esray.local', '05000000002', 1, 'Seed Member Address 2', 2, 2, 2, '34002', 90, '2020-01-01T00:00:00', 'SEED-BRN', NULL, NULL, 'Seed Corporate', NULL, '02120000000', 'finance@seed.local', NULL, NULL, NULL, NULL, 'SEED-TAX-001', 'Seed Office', 'https://seed.local');

SET @corporateMemberId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Representative]
    ([Name], [Surname], [Gender], [NationalIdentityNumber], [ParentName], [Title], [Phone], [Email], [Occupation], [BirthDate], [Birthplace], [EducationStatus], [RepresentationStartDate], [CorporateId], [Address_OpenAddress], [Address_DistrictId], [Address_CityId], [Address_StateId], [Address_PostalCode], [Address_CountryId])
VALUES
    ('Rep', 'Seed', 0, 222222222, 'Parent Seed', 'Authorized Rep', '05000000003', 'seed.representative@esray.local', 'Lawyer', '1985-01-01T00:00:00', 'Ankara', 3, @now, @corporateMemberId, 'Seed Rep Address', 3, 3, 3, '34003', 90);

SET @representativeId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Income]
    ([Type], [Source], [Description], [Iban], [Amount], [Date], [SafeId])
VALUES
    (0, 'Seed Dues Collection', 'Seed income row', 'TR000000000000000000000002', 500.00, @now, @safeId);

SET @incomeId = CAST(SCOPE_IDENTITY() AS INT);

INSERT INTO [Expense]
    ([Type], [Destination], [Description], [Iban], [Amount], [Date], [SafeId])
VALUES
    (0, 'Seed Vendor', 'Seed expense row', 'TR000000000000000000000003', 150.00, @now, @safeId);

INSERT INTO [Dues]
    ([Period], [DueDate], [Amount], [Status], [MemberId], [IncomeId])
VALUES
    ('2026-01-01T00:00:00', '2026-01-31T00:00:00', 500.00, 1, @individualMemberId, @incomeId);

INSERT INTO [Decision]
    ([Title], [Body], [MeetingId])
VALUES
    ('Seed Decision', 'Seed decision body', @meetingId);

INSERT INTO [IncomingDocuments]
    ([Sender], [RegistrationNumber], [Date], [FolderPath], [Description], [FileNumber], [FileType], [ExtraInformation])
VALUES
    ('Seed Sender', 'IN-__seed_dummy_all_tables__', @now, '/seed/documents/incoming', 'Seed incoming doc', 'IN-001', 3, 'Seed incoming info');

INSERT INTO [InternalDocuments]
    ([RegistrationNumber], [Date], [FolderPath], [Description], [FileNumber], [FileType], [ExtraInformation])
VALUES
    ('INT-__seed_dummy_all_tables__', @now, '/seed/documents/internal', 'Seed internal doc', 'INT-001', 1, 'Seed internal info');

INSERT INTO [OutgoingDocuments]
    ([Receiver], [RegistrationNumber], [Date], [FolderPath], [Description], [FileNumber], [FileType], [ExtraInformation])
VALUES
    ('Seed Receiver', 'OUT-__seed_dummy_all_tables__', @now, '/seed/documents/outgoing', 'Seed outgoing doc', 'OUT-001', 2, 'Seed outgoing info');

INSERT INTO [Administrator]
    ([AuthorizationLevel], [RegisterDate], [Email], [Phone], [Name], [Surname], [NationalIdentityNumber], [Occupation], [BirthDate], [Birthplace], [AssociationId])
VALUES
    (0, @now, 'seed.admin@esray.local', '05000000004', 'Admin', 'Seed', 333333333, 'Manager', '1988-01-01T00:00:00', 'Izmir', @associationId);

INSERT INTO [IndividualMeetingParticipants]
    ([IndividualParticipantsId], [MeetingsId])
VALUES
    (@individualMemberId, @meetingId);

INSERT INTO [RepresentativeMeetingParticipants]
    ([MeetingsId], [RepresentativeParticipantsId])
VALUES
    (@meetingId, @representativeId);
");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.Sql(@"
DELETE FROM [RepresentativeMeetingParticipants]
WHERE [MeetingsId] IN (SELECT [Id] FROM [Meeting] WHERE [Location] = 'Seed Meeting Hall')
  AND [RepresentativeParticipantsId] IN (SELECT [Id] FROM [Representative] WHERE [Email] = 'seed.representative@esray.local');

DELETE FROM [IndividualMeetingParticipants]
WHERE [MeetingsId] IN (SELECT [Id] FROM [Meeting] WHERE [Location] = 'Seed Meeting Hall')
  AND [IndividualParticipantsId] IN (SELECT [Id] FROM [Members] WHERE [Email] = 'seed.individual@esray.local');

DELETE FROM [Decision]
WHERE [Title] = 'Seed Decision';

DELETE FROM [Dues]
WHERE [IncomeId] IN (SELECT [Id] FROM [Income] WHERE [Source] = 'Seed Dues Collection');

DELETE FROM [Expense]
WHERE [Description] = 'Seed expense row';

DELETE FROM [Income]
WHERE [Source] = 'Seed Dues Collection';

DELETE FROM [Administrator]
WHERE [Email] = 'seed.admin@esray.local';

DELETE FROM [OutgoingDocuments]
WHERE [RegistrationNumber] = 'OUT-__seed_dummy_all_tables__';

DELETE FROM [InternalDocuments]
WHERE [RegistrationNumber] = 'INT-__seed_dummy_all_tables__';

DELETE FROM [IncomingDocuments]
WHERE [RegistrationNumber] = 'IN-__seed_dummy_all_tables__';

DELETE FROM [Representative]
WHERE [Email] = 'seed.representative@esray.local';

DELETE FROM [Meeting]
WHERE [Location] = 'Seed Meeting Hall' AND [Agenda] = 'Seed agenda';

DELETE FROM [Safe]
WHERE [AccountNumber] = 'SEED-ACC-0001';

DELETE FROM [Members]
WHERE [Email] IN ('seed.individual@esray.local', 'seed.corporate@esray.local');

DELETE FROM [Association]
WHERE [Name] = '__seed_dummy_all_tables__';
");
        }
    }
}

