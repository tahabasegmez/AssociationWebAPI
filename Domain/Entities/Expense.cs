using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Domain.Entities
{
    public class Expense
    {
        public int Id { get; set; }

        public ExpenseType Type { get; set; }

        public string Destination { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Iban { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }


        public int SafeId { get; set; }

        [ForeignKey(nameof(SafeId))]
        public required Safe Safe { get; set; }
    }
}


