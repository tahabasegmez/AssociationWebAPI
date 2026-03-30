using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;

namespace AssociationWebAPI.Domain.Entities
{
    public class Safe
    {
        public int Id { get; set; }

        public string Iban { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Balance { get; set; } = decimal.Zero;

        public string BankName { get; set; } = string.Empty;

        public string BranchName { get; set; } = string.Empty;

        public string AccountHolder { get; set; } = string.Empty;

        public string AccountNumber { get; set; } = string.Empty;


        public int AssociationId { get; set; }

        [ForeignKey(nameof(AssociationId))]
        public required Association Association { get; set; }
        public List<Income> Incomes { get; set; } = new List<Income>();

        public List<Expense> Expenses { get; set; } = new List<Expense>();
    }
}
