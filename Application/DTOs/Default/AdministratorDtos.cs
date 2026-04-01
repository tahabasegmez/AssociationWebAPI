using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class AdministratorRequestDto
{
    public AuthorizationLevel AuthorizationLevel { get; set; }
    public DateTime RegisterDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public int NationalIdentityNumber { get; set; }
    public string Occupation { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    public string? Birthplace { get; set; }
    public int AssociationId { get; set; }
}

public class AdministratorResponseDto
{
    public int Id { get; set; }
    public AuthorizationLevel AuthorizationLevel { get; set; }
    public DateTime RegisterDate { get; set; }
    public string Email { get; set; } = string.Empty;
    public string Phone { get; set; } = string.Empty;
    public string Name { get; set; } = string.Empty;
    public string Surname { get; set; } = string.Empty;
    public int NationalIdentityNumber { get; set; }
    public string Occupation { get; set; } = string.Empty;
    public DateTime? BirthDate { get; set; }
    public string? Birthplace { get; set; }
    public int AssociationId { get; set; }
}

