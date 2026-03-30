namespace AssociationWebAPI.Application.DTOs;

public class OutgoingRequestDto : DocumentRequestDto
{
    public string Receiver { get; set; } = string.Empty;
}

public class OutgoingResponseDto : DocumentResponseDto
{
    public string Receiver { get; set; } = string.Empty;
}

