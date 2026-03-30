namespace AssociationWebAPI.Application.DTOs;

public class SafeRequestDto
{
    public string Iban { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public string BankName { get; set; } = string.Empty;
    public string BranchName { get; set; } = string.Empty;
    public string AccountHolder { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public int AssociationId { get; set; }
}

public class SafeResponseDto
{
    public int Id { get; set; }
    public string Iban { get; set; } = string.Empty;
    public decimal Balance { get; set; }
    public string BankName { get; set; } = string.Empty;
    public string BranchName { get; set; } = string.Empty;
    public string AccountHolder { get; set; } = string.Empty;
    public string AccountNumber { get; set; } = string.Empty;
    public int AssociationId { get; set; }
    public List<int> IncomeIds { get; set; } = new();
    public List<int> ExpenseIds { get; set; } = new();
}

