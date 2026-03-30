using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class IndividualRequestDto : MemberRequestDto
{

    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public int NationalIdentityNumber { get; set; }
    public string Occupation { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Birthplace { get; set; } = string.Empty;
    public EducationStatus EducationStatus { get; set; }
}

public class IndividualResponseDto
{
    public int Id { get; set; }
    public MemberType Type { get; set; }
    public DateTime RegistrationDate { get; set; }
    public MemberStatus Status { get; set; }
    public DateTime InactiveDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public AddressResponseDto Address { get; set; } = new();
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public int NationalIdentityNumber { get; set; }
    public string Occupation { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Birthplace { get; set; } = string.Empty;
    public EducationStatus EducationStatus { get; set; }
    public List<int> MeetingIds { get; set; } = new();
}

