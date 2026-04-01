namespace AssociationWebAPI.Application.DTOs;

public class DecisionRequestDto
{
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public int MeetingId { get; set; }
}

public class DecisionResponseDto
{
    public int Id { get; set; }
    public string Title { get; set; } = string.Empty;
    public string Body { get; set; } = string.Empty;
    public int MeetingId { get; set; }
}

