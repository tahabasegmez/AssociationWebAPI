using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class DocumentRequestDto
{
    public string RegistrationNumber { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string FolderPath { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string FileNumber { get; set; } = string.Empty;
    public DocumentType FileType { get; set; }
    public string ExtraInformation { get; set; } = string.Empty;
}

public class DocumentResponseDto
{
    public int Id { get; set; }
    public string RegistrationNumber { get; set; } = string.Empty;
    public DateTime Date { get; set; }
    public string FolderPath { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string FileNumber { get; set; } = string.Empty;
    public DocumentType FileType { get; set; }
    public string ExtraInformation { get; set; } = string.Empty;
}

