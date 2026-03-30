using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class CorporateRequestDto
{
    public DateTime RegistrationDate { get; set; }
    public MemberStatus Status { get; set; }
    public DateTime InactiveDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public AddressRequestDto Address { get; set; } = new();
    public string CorporateName { get; set; } = string.Empty;
    public string TaxOffice { get; set; } = string.Empty;
    public string TaxNumber { get; set; } = string.Empty;
    public string FinancialMail { get; set; } = string.Empty;
    public string BRN { get; set; } = string.Empty;
    public DateTime BRD { get; set; }
    public string FaxNumber { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public List<int> RepresentativeIds { get; set; } = new();
    public List<int> Dues { get; set; } = new();
}

public class CorporateResponseDto
{
    public int Id { get; set; }
    public MemberType Type { get; set; }
    public DateTime RegistrationDate { get; set; }
    public MemberStatus Status { get; set; }
    public DateTime InactiveDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public AddressResponseDto Address { get; set; } = new();
    public string CorporateName { get; set; } = string.Empty;
    public string TaxOffice { get; set; } = string.Empty;
    public string TaxNumber { get; set; } = string.Empty;
    public string FinancialMail { get; set; } = string.Empty;
    public string BRN { get; set; } = string.Empty;
    public DateTime BRD { get; set; }
    public string FaxNumber { get; set; } = string.Empty;
    public string Website { get; set; } = string.Empty;
    public List<int> RepresentativeIds { get; set; } = new();
}

