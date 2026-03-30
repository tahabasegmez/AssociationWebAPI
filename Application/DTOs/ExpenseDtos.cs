using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class ExpenseRequestDto
{
    public ExpenseType Type { get; set; }
    public string Destination { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int SafeId { get; set; }
}

public class ExpenseResponseDto
{
    public int Id { get; set; }
    public ExpenseType Type { get; set; }
    public string Destination { get; set; } = string.Empty;
    public string Description { get; set; } = string.Empty;
    public string Iban { get; set; } = string.Empty;
    public decimal Amount { get; set; }
    public DateTime Date { get; set; }
    public int SafeId { get; set; }
}

