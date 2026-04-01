namespace AssociationWebAPI.Application.DTOs;

public class AssociationRequestDto
{
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public AddressRequestDto Address { get; set; } = new();
    public SafeRequestDto Safe { get; set; } = new();
}

public class AssociationResponseDto
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public AddressResponseDto Address { get; set; } = new();
    public int? SafeId { get; set; }
    public List<int> AdministratorIds { get; set; } = new();
}

