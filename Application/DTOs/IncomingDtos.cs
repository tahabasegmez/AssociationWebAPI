namespace AssociationWebAPI.Application.DTOs;

public class IncomingRequestDto : DocumentRequestDto
{
    public string Sender { get; set; } = string.Empty;
}

public class IncomingResponseDto : DocumentResponseDto
{
    public string Sender { get; set; } = string.Empty;
}

