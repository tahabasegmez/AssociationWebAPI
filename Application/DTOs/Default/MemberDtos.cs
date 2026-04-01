using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public abstract class MemberRequestDto
{
    public DateTime RegistrationDate { get; set; }
    public MemberStatus Status { get; set; }
    public DateTime InactiveDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public MemberType Type { get; set; }
    public AddressRequestDto Address { get; set; } = new();
    
}

public class MemberResponseDto
{
    public int Id { get; set; }
    public DateTime RegistrationDate { get; set; }
    public MemberStatus Status { get; set; }
    public DateTime InactiveDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public MemberType Type { get; set; }
    public AddressResponseDto Address { get; set; } = new();
    public List<int> DuesIds { get; set; } = new();
}

