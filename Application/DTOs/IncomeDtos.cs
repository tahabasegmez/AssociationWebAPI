using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class IncomeRequestDto
{
    public IncomeType Type { get; set; }
    public string Source { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int SafeId { get; set; }
}

public class IncomeResponseDto
{
    public int Id { get; set; }
    public IncomeType Type { get; set; }
    public string Source { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int SafeId { get; set; }
    public int? DuesId { get; set; }
}

