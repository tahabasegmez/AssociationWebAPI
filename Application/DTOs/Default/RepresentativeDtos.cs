using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class RepresentativeRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public int NationalIdentityNumber { get; set; }
    public string ParentName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Occupation { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Birthplace { get; set; } = string.Empty;
    public EducationStatus EducationStatus { get; set; }
    public DateTime RepresentationStartDate { get; set; }
    public int CorporateId { get; set; }
    public AddressRequestDto Address { get; set; } = new();
}

public class RepresentativeResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public Gender Gender { get; set; }
    public int NationalIdentityNumber { get; set; }
    public string ParentName { get; set; } = string.Empty;
    public string Title { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Email { get; set; } = string.Empty;
    public string Occupation { get; set; } = string.Empty;
    public DateTime BirthDate { get; set; }
    public string Birthplace { get; set; } = string.Empty;
    public EducationStatus EducationStatus { get; set; }
    public DateTime RepresentationStartDate { get; set; }
    public int CorporateId { get; set; }
    public AddressResponseDto Address { get; set; } = new();
    public List<int> MeetingIds { get; set; } = new();
}

