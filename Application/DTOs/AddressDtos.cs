namespace AssociationWebAPI.Application.DTOs;

public class AddressRequestDto
{
    public string OpenAddress { get; set; } = string.Empty;
    public int DistrictId { get; set; }
    public int CityId { get; set; }
    public int StateId { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public int CountryId { get; set; }
}

public class AddressResponseDto
{
    public string OpenAddress { get; set; } = string.Empty;
    public int DistrictId { get; set; }
    public int CityId { get; set; }
    public int StateId { get; set; }
    public string PostalCode { get; set; } = string.Empty;
    public int CountryId { get; set; }
}

