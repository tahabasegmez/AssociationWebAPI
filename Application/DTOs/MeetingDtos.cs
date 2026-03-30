namespace AssociationWebAPI.Application.DTOs;

public class MeetingRequestDto
{
    public DateTime Date { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public string FolderPath { get; set; } = string.Empty;
    public List<int> IndividualParticipantIds { get; set; } = new();
    public List<int> RepresentativeParticipantIds { get; set; } = new();
}

public class MeetingResponseDto
{
    public int Id { get; set; }
    public DateTime Date { get; set; }
    public string Location { get; set; } = string.Empty;
    public string Agenda { get; set; } = string.Empty;
    public string FolderPath { get; set; } = string.Empty;
    public List<int> IndividualParticipantIds { get; set; } = new();
    public List<int> RepresentativeParticipantIds { get; set; } = new();
    public List<int> DecisionIds { get; set; } = new();
}

