using AssociationWebAPI.Application.DTOs;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.Mappers;

public static class DefaultDtoEntityMapperExtensions
{
    public static Address ToEntity(this AddressRequestDto dto) => new()
    {
        OpenAddress = dto.OpenAddress,
        DistrictId = dto.DistrictId,
        CityId = dto.CityId,
        StateId = dto.StateId,
        PostalCode = dto.PostalCode,
        CountryId = dto.CountryId
    };

    public static Address ToEntity(this AddressResponseDto dto) => new()
    {
        OpenAddress = dto.OpenAddress,
        DistrictId = dto.DistrictId,
        CityId = dto.CityId,
        StateId = dto.StateId,
        PostalCode = dto.PostalCode,
        CountryId = dto.CountryId
    };

    public static AddressRequestDto ToRequestDto(this Address entity) => new()
    {
        OpenAddress = entity.OpenAddress,
        DistrictId = entity.DistrictId,
        CityId = entity.CityId,
        StateId = entity.StateId,
        PostalCode = entity.PostalCode,
        CountryId = entity.CountryId
    };

    public static AddressResponseDto ToResponseDto(this Address entity) => new()
    {
        OpenAddress = entity.OpenAddress,
        DistrictId = entity.DistrictId,
        CityId = entity.CityId,
        StateId = entity.StateId,
        PostalCode = entity.PostalCode,
        CountryId = entity.CountryId
    };

    public static Administrator ToEntity(this AdministratorRequestDto dto) => new()
    {
        AuthorizationLevel = dto.AuthorizationLevel,
        RegisterDate = dto.RegisterDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Name = dto.Name,
        Surname = dto.Surname,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        AssociationId = dto.AssociationId,
        Association = null!
    };

    public static Administrator ToEntity(this AdministratorResponseDto dto) => new()
    {
        Id = dto.Id,
        AuthorizationLevel = dto.AuthorizationLevel,
        RegisterDate = dto.RegisterDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Name = dto.Name,
        Surname = dto.Surname,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        AssociationId = dto.AssociationId,
        Association = null!
    };

    public static AdministratorRequestDto ToRequestDto(this Administrator entity) => new()
    {
        AuthorizationLevel = entity.AuthorizationLevel,
        RegisterDate = entity.RegisterDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Name = entity.Name,
        Surname = entity.Surname,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        AssociationId = entity.AssociationId
    };

    public static AdministratorResponseDto ToResponseDto(this Administrator entity) => new()
    {
        Id = entity.Id,
        AuthorizationLevel = entity.AuthorizationLevel,
        RegisterDate = entity.RegisterDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Name = entity.Name,
        Surname = entity.Surname,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        AssociationId = entity.AssociationId
    };

    public static Association ToEntity(this AssociationRequestDto dto) => new()
    {
        Name = dto.Name,
        Description = dto.Description,
        Address = dto.Address.ToEntity(),
        Safe = dto.Safe.ToEntity()
    };

    public static Association ToEntity(this AssociationResponseDto dto) => new()
    {
        Id = dto.Id,
        Name = dto.Name,
        Description = dto.Description,
        Address = dto.Address.ToEntity(),
        Safe = new Safe
        {
            Id = dto.SafeId ?? 0,
            AssociationId = dto.Id,
            Association = null!
        },
        Administrators = new List<Administrator>()
    };

    public static AssociationRequestDto ToRequestDto(this Association entity) => new()
    {
        Name = entity.Name,
        Description = entity.Description,
        Address = entity.Address.ToRequestDto(),
        Safe = entity.Safe.ToRequestDto()
    };

    public static AssociationResponseDto ToResponseDto(this Association entity) => new()
    {
        Id = entity.Id,
        Name = entity.Name,
        Description = entity.Description,
        Address = entity.Address.ToResponseDto(),
        SafeId = entity.Safe?.Id,
        AdministratorIds = entity.Administrators.Select(a => a.Id).ToList()
    };

    public static MemberResponseDto ToResponseDto(this Member entity) => new()
    {
        Id = entity.Id,
        RegistrationDate = entity.RegistrationDate,
        Status = entity.Status,
        InactiveDate = entity.InactiveDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Type = entity.Type,
        Address = entity.Address.ToResponseDto(),
        DuesIds = entity.Dues.Select(d => d.Id).ToList()
    };

    public static Corporate ToEntity(this CorporateRequestDto dto) => new()
    {
        RegistrationDate = dto.RegistrationDate,
        Status = dto.Status,
        InactiveDate = dto.InactiveDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Type = MemberType.Corporate,
        Address = dto.Address.ToEntity(),
        CorporateName = dto.CorporateName,
        TaxOffice = dto.TaxOffice,
        TaxNumber = dto.TaxNumber,
        FinancialMail = dto.FinancialMail,
        BRN = dto.BRN,
        BRD = dto.BRD,
        FaxNumber = dto.FaxNumber,
        Website = dto.Website,
        Dues = new List<Dues>(),
        Representatives = new List<Representative>()
    };

    public static Corporate ToEntity(this CorporateResponseDto dto) => new()
    {
        Id = dto.Id,
        Type = dto.Type,
        RegistrationDate = dto.RegistrationDate,
        Status = dto.Status,
        InactiveDate = dto.InactiveDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Address = dto.Address.ToEntity(),
        CorporateName = dto.CorporateName,
        TaxOffice = dto.TaxOffice,
        TaxNumber = dto.TaxNumber,
        FinancialMail = dto.FinancialMail,
        BRN = dto.BRN,
        BRD = dto.BRD,
        FaxNumber = dto.FaxNumber,
        Website = dto.Website,
        Dues = new List<Dues>(),
        Representatives = new List<Representative>()
    };

    public static CorporateRequestDto ToRequestDto(this Corporate entity) => new()
    {
        RegistrationDate = entity.RegistrationDate,
        Status = entity.Status,
        InactiveDate = entity.InactiveDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Address = entity.Address.ToRequestDto(),
        CorporateName = entity.CorporateName,
        TaxOffice = entity.TaxOffice,
        TaxNumber = entity.TaxNumber,
        FinancialMail = entity.FinancialMail,
        BRN = entity.BRN,
        BRD = entity.BRD,
        FaxNumber = entity.FaxNumber,
        Website = entity.Website,
        RepresentativeIds = entity.Representatives.Select(r => r.Id).ToList(),
        Dues = entity.Dues.Select(d => d.Id).ToList()
    };

    public static CorporateResponseDto ToResponseDto(this Corporate entity) => new()
    {
        Id = entity.Id,
        Type = entity.Type,
        RegistrationDate = entity.RegistrationDate,
        Status = entity.Status,
        InactiveDate = entity.InactiveDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Address = entity.Address.ToResponseDto(),
        CorporateName = entity.CorporateName,
        TaxOffice = entity.TaxOffice,
        TaxNumber = entity.TaxNumber,
        FinancialMail = entity.FinancialMail,
        BRN = entity.BRN,
        BRD = entity.BRD,
        FaxNumber = entity.FaxNumber,
        Website = entity.Website,
        RepresentativeIds = entity.Representatives.Select(r => r.Id).ToList()
    };

    public static Individual ToEntity(this IndividualRequestDto dto) => new()
    {
        RegistrationDate = dto.RegistrationDate,
        Status = dto.Status,
        InactiveDate = dto.InactiveDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Type = MemberType.Individual,
        Address = dto.Address.ToEntity(),
        Name = dto.Name,
        Surname = dto.Surname,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        EducationStatus = dto.EducationStatus,
        Dues = new List<Dues>(),
        Meetings = new List<Meeting>()
    };

    public static Individual ToEntity(this IndividualResponseDto dto) => new()
    {
        Id = dto.Id,
        Type = dto.Type,
        RegistrationDate = dto.RegistrationDate,
        Status = dto.Status,
        InactiveDate = dto.InactiveDate,
        Email = dto.Email,
        Phone = dto.Phone,
        Address = dto.Address.ToEntity(),
        Name = dto.Name,
        Surname = dto.Surname,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        EducationStatus = dto.EducationStatus,
        Dues = new List<Dues>(),
        Meetings = new List<Meeting>()
    };

    public static IndividualRequestDto ToRequestDto(this Individual entity) => new()
    {
        RegistrationDate = entity.RegistrationDate,
        Status = entity.Status,
        InactiveDate = entity.InactiveDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Type = entity.Type,
        Address = entity.Address.ToRequestDto(),
        Name = entity.Name,
        Surname = entity.Surname,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        EducationStatus = entity.EducationStatus
    };

    public static IndividualResponseDto ToResponseDto(this Individual entity) => new()
    {
        Id = entity.Id,
        Type = entity.Type,
        RegistrationDate = entity.RegistrationDate,
        Status = entity.Status,
        InactiveDate = entity.InactiveDate,
        Email = entity.Email,
        Phone = entity.Phone,
        Address = entity.Address.ToResponseDto(),
        Name = entity.Name,
        Surname = entity.Surname,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        EducationStatus = entity.EducationStatus,
        MeetingIds = entity.Meetings.Select(m => m.Id).ToList()
    };

    public static Decision ToEntity(this DecisionRequestDto dto) => new()
    {
        Title = dto.Title,
        Body = dto.Body,
        MeetingId = dto.MeetingId,
        Meeting = null!
    };

    public static Decision ToEntity(this DecisionResponseDto dto) => new()
    {
        Id = dto.Id,
        Title = dto.Title,
        Body = dto.Body,
        MeetingId = dto.MeetingId,
        Meeting = null!
    };

    public static DecisionRequestDto ToRequestDto(this Decision entity) => new()
    {
        Title = entity.Title,
        Body = entity.Body,
        MeetingId = entity.MeetingId
    };

    public static DecisionResponseDto ToResponseDto(this Decision entity) => new()
    {
        Id = entity.Id,
        Title = entity.Title,
        Body = entity.Body,
        MeetingId = entity.MeetingId
    };

    public static Dues ToEntity(this DuesRequestDto dto) => new()
    {
        Period = dto.Period,
        DueDate = dto.DueDate,
        Amount = dto.Amount,
        Status = dto.Status,
        MemberId = dto.MemberId,
        Member = null!,
        IncomeId = dto.IncomeId,
        Income = null!
    };

    public static Dues ToEntity(this DuesResponseDto dto) => new()
    {
        Id = dto.Id,
        Period = dto.Period,
        DueDate = dto.DueDate,
        Amount = dto.Amount,
        Status = dto.Status,
        MemberId = dto.MemberId,
        Member = null!,
        IncomeId = dto.IncomeId,
        Income = null!
    };

    public static DuesRequestDto ToRequestDto(this Dues entity) => new()
    {
        Period = entity.Period,
        DueDate = entity.DueDate,
        Amount = entity.Amount,
        Status = entity.Status,
        MemberId = entity.MemberId,
        IncomeId = entity.IncomeId
    };

    public static DuesResponseDto ToResponseDto(this Dues entity) => new()
    {
        Id = entity.Id,
        Period = entity.Period,
        DueDate = entity.DueDate,
        Amount = entity.Amount,
        Status = entity.Status,
        MemberId = entity.MemberId,
        IncomeId = entity.IncomeId
    };

    public static Expense ToEntity(this ExpenseRequestDto dto) => new()
    {
        Type = dto.Type,
        Destination = dto.Destination,
        Description = dto.Description,
        Iban = dto.Iban,
        Amount = dto.Amount,
        Date = dto.Date,
        SafeId = dto.SafeId,
        Safe = null!
    };

    public static Expense ToEntity(this ExpenseResponseDto dto) => new()
    {
        Id = dto.Id,
        Type = dto.Type,
        Destination = dto.Destination,
        Description = dto.Description,
        Iban = dto.Iban,
        Amount = dto.Amount,
        Date = dto.Date,
        SafeId = dto.SafeId,
        Safe = null!
    };

    public static ExpenseRequestDto ToRequestDto(this Expense entity) => new()
    {
        Type = entity.Type,
        Destination = entity.Destination,
        Description = entity.Description,
        Iban = entity.Iban,
        Amount = entity.Amount,
        Date = entity.Date,
        SafeId = entity.SafeId
    };

    public static ExpenseResponseDto ToResponseDto(this Expense entity) => new()
    {
        Id = entity.Id,
        Type = entity.Type,
        Destination = entity.Destination,
        Description = entity.Description,
        Iban = entity.Iban,
        Amount = entity.Amount,
        Date = entity.Date,
        SafeId = entity.SafeId
    };

    public static Income ToEntity(this IncomeRequestDto dto) => new()
    {
        Type = dto.Type,
        Source = dto.Source,
        Description = dto.Description,
        Iban = dto.Iban,
        Amount = dto.Amount,
        Date = dto.Date,
        SafeId = dto.SafeId,
        Safe = null!,
        Dues = null
    };

    public static Income ToEntity(this IncomeResponseDto dto) => new()
    {
        Id = dto.Id,
        Type = dto.Type,
        Source = dto.Source,
        Description = dto.Description,
        Iban = dto.Iban,
        Amount = dto.Amount,
        Date = dto.Date,
        SafeId = dto.SafeId,
        Safe = null!,
        Dues = null
    };

    public static IncomeRequestDto ToRequestDto(this Income entity) => new()
    {
        Type = entity.Type,
        Source = entity.Source,
        Description = entity.Description,
        Iban = entity.Iban,
        Amount = entity.Amount,
        Date = entity.Date,
        SafeId = entity.SafeId
    };

    public static IncomeResponseDto ToResponseDto(this Income entity) => new()
    {
        Id = entity.Id,
        Type = entity.Type,
        Source = entity.Source,
        Description = entity.Description,
        Iban = entity.Iban,
        Amount = entity.Amount,
        Date = entity.Date,
        SafeId = entity.SafeId,
        DuesId = entity.Dues?.Id
    };

    public static Meeting ToEntity(this MeetingRequestDto dto) => new()
    {
        Date = dto.Date,
        Location = dto.Location,
        Agenda = dto.Agenda,
        FolderPath = dto.FolderPath,
        IndividualParticipants = new List<Individual>(),
        RepresentativeParticipants = new List<Representative>(),
        Decisions = new List<Decision>()
    };

    public static Meeting ToEntity(this MeetingResponseDto dto) => new()
    {
        Id = dto.Id,
        Date = dto.Date,
        Location = dto.Location,
        Agenda = dto.Agenda,
        FolderPath = dto.FolderPath,
        IndividualParticipants = new List<Individual>(),
        RepresentativeParticipants = new List<Representative>(),
        Decisions = new List<Decision>()
    };

    public static MeetingRequestDto ToRequestDto(this Meeting entity) => new()
    {
        Date = entity.Date,
        Location = entity.Location,
        Agenda = entity.Agenda,
        FolderPath = entity.FolderPath,
        IndividualParticipantIds = entity.IndividualParticipants.Select(i => i.Id).ToList(),
        RepresentativeParticipantIds = entity.RepresentativeParticipants.Select(r => r.Id).ToList()
    };

    public static MeetingResponseDto ToResponseDto(this Meeting entity) => new()
    {
        Id = entity.Id,
        Date = entity.Date,
        Location = entity.Location,
        Agenda = entity.Agenda,
        FolderPath = entity.FolderPath,
        IndividualParticipantIds = entity.IndividualParticipants.Select(i => i.Id).ToList(),
        RepresentativeParticipantIds = entity.RepresentativeParticipants.Select(r => r.Id).ToList(),
        DecisionIds = entity.Decisions.Select(d => d.Id).ToList()
    };

    public static Representative ToEntity(this RepresentativeRequestDto dto) => new()
    {
        Name = dto.Name,
        Surname = dto.Surname,
        Gender = dto.Gender,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        ParentName = dto.ParentName,
        Title = dto.Title,
        Phone = dto.Phone,
        Email = dto.Email,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        EducationStatus = dto.EducationStatus,
        RepresentationStartDate = dto.RepresentationStartDate,
        CorporateId = dto.CorporateId,
        Corporate = null!,
        Address = dto.Address.ToEntity(),
        Meetings = new List<Meeting>()
    };

    public static Representative ToEntity(this RepresentativeResponseDto dto) => new()
    {
        Id = dto.Id,
        Name = dto.Name,
        Surname = dto.Surname,
        Gender = dto.Gender,
        NationalIdentityNumber = dto.NationalIdentityNumber,
        ParentName = dto.ParentName,
        Title = dto.Title,
        Phone = dto.Phone,
        Email = dto.Email,
        Occupation = dto.Occupation,
        BirthDate = dto.BirthDate,
        Birthplace = dto.Birthplace,
        EducationStatus = dto.EducationStatus,
        RepresentationStartDate = dto.RepresentationStartDate,
        CorporateId = dto.CorporateId,
        Corporate = null!,
        Address = dto.Address.ToEntity(),
        Meetings = new List<Meeting>()
    };

    public static RepresentativeRequestDto ToRequestDto(this Representative entity) => new()
    {
        Name = entity.Name,
        Surname = entity.Surname,
        Gender = entity.Gender,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        ParentName = entity.ParentName,
        Title = entity.Title,
        Phone = entity.Phone,
        Email = entity.Email,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        EducationStatus = entity.EducationStatus,
        RepresentationStartDate = entity.RepresentationStartDate,
        CorporateId = entity.CorporateId,
        Address = entity.Address.ToRequestDto()
    };

    public static RepresentativeResponseDto ToResponseDto(this Representative entity) => new()
    {
        Id = entity.Id,
        Name = entity.Name,
        Surname = entity.Surname,
        Gender = entity.Gender,
        NationalIdentityNumber = entity.NationalIdentityNumber,
        ParentName = entity.ParentName,
        Title = entity.Title,
        Phone = entity.Phone,
        Email = entity.Email,
        Occupation = entity.Occupation,
        BirthDate = entity.BirthDate,
        Birthplace = entity.Birthplace,
        EducationStatus = entity.EducationStatus,
        RepresentationStartDate = entity.RepresentationStartDate,
        CorporateId = entity.CorporateId,
        Address = entity.Address.ToResponseDto(),
        MeetingIds = entity.Meetings.Select(m => m.Id).ToList()
    };

    public static Safe ToEntity(this SafeRequestDto dto) => new()
    {
        Iban = dto.Iban,
        Balance = dto.Balance,
        BankName = dto.BankName,
        BranchName = dto.BranchName,
        AccountHolder = dto.AccountHolder,
        AccountNumber = dto.AccountNumber,
        AssociationId = dto.AssociationId,
        Association = null!,
        Incomes = new List<Income>(),
        Expenses = new List<Expense>()
    };

    public static Safe ToEntity(this SafeResponseDto dto) => new()
    {
        Id = dto.Id,
        Iban = dto.Iban,
        Balance = dto.Balance,
        BankName = dto.BankName,
        BranchName = dto.BranchName,
        AccountHolder = dto.AccountHolder,
        AccountNumber = dto.AccountNumber,
        AssociationId = dto.AssociationId,
        Association = null!,
        Incomes = new List<Income>(),
        Expenses = new List<Expense>()
    };

    public static SafeRequestDto ToRequestDto(this Safe entity) => new()
    {
        Iban = entity.Iban,
        Balance = entity.Balance,
        BankName = entity.BankName,
        BranchName = entity.BranchName,
        AccountHolder = entity.AccountHolder,
        AccountNumber = entity.AccountNumber,
        AssociationId = entity.AssociationId
    };

    public static SafeResponseDto ToResponseDto(this Safe entity) => new()
    {
        Id = entity.Id,
        Iban = entity.Iban,
        Balance = entity.Balance,
        BankName = entity.BankName,
        BranchName = entity.BranchName,
        AccountHolder = entity.AccountHolder,
        AccountNumber = entity.AccountNumber,
        AssociationId = entity.AssociationId,
        IncomeIds = entity.Incomes.Select(i => i.Id).ToList(),
        ExpenseIds = entity.Expenses.Select(e => e.Id).ToList()
    };

    public static DocumentResponseDto ToResponseDto(this Document entity) => new()
    {
        Id = entity.Id,
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation
    };

    public static Incoming ToEntity(this IncomingRequestDto dto) => new()
    {
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation,
        Sender = dto.Sender
    };

    public static Incoming ToEntity(this IncomingResponseDto dto) => new()
    {
        Id = dto.Id,
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation,
        Sender = dto.Sender
    };

    public static IncomingRequestDto ToRequestDto(this Incoming entity) => new()
    {
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation,
        Sender = entity.Sender
    };

    public static IncomingResponseDto ToResponseDto(this Incoming entity) => new()
    {
        Id = entity.Id,
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation,
        Sender = entity.Sender
    };

    public static Outgoing ToEntity(this OutgoingRequestDto dto) => new()
    {
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation,
        Receiver = dto.Receiver
    };

    public static Outgoing ToEntity(this OutgoingResponseDto dto) => new()
    {
        Id = dto.Id,
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation,
        Receiver = dto.Receiver
    };

    public static OutgoingRequestDto ToRequestDto(this Outgoing entity) => new()
    {
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation,
        Receiver = entity.Receiver
    };

    public static OutgoingResponseDto ToResponseDto(this Outgoing entity) => new()
    {
        Id = entity.Id,
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation,
        Receiver = entity.Receiver
    };

    public static global::AssociationWebAPI.Domain.Entities.Internal ToEntity(this InternalRequestDto dto) => new()
    {
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation
    };

    public static global::AssociationWebAPI.Domain.Entities.Internal ToEntity(this InternalResponseDto dto) => new()
    {
        Id = dto.Id,
        RegistrationNumber = dto.RegistrationNumber,
        Date = dto.Date,
        FolderPath = dto.FolderPath,
        Description = dto.Description,
        FileNumber = dto.FileNumber,
        FileType = dto.FileType,
        ExtraInformation = dto.ExtraInformation
    };

    public static InternalRequestDto ToRequestDto(this global::AssociationWebAPI.Domain.Entities.Internal entity) => new()
    {
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation
    };

    public static InternalResponseDto ToResponseDto(this global::AssociationWebAPI.Domain.Entities.Internal entity) => new()
    {
        Id = entity.Id,
        RegistrationNumber = entity.RegistrationNumber,
        Date = entity.Date,
        FolderPath = entity.FolderPath,
        Description = entity.Description,
        FileNumber = entity.FileNumber,
        FileType = entity.FileType,
        ExtraInformation = entity.ExtraInformation
    };
}
