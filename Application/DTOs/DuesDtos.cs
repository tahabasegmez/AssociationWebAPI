using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Application.DTOs;

public class DuesRequestDto
{
    public DateTime Period { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public DuesStatus Status { get; set; }
    public int MemberId { get; set; }
    public int IncomeId { get; set; }
}

public class DuesResponseDto
{
    public int Id { get; set; }
    public DateTime Period { get; set; }
    public DateTime DueDate { get; set; }
    public decimal Amount { get; set; }
    public DuesStatus Status { get; set; }
    public int MemberId { get; set; }
    public int IncomeId { get; set; }
}

