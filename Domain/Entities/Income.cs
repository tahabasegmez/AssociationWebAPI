using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public class Income
    {
        public int Id { get; set; }

        public IncomeType Type { get; set; }

        public string Source { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;

        public string Iban { get; set; } = string.Empty;

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; }

        public DateTime Date { get; set; }


        public Dues? Dues { get; set; }

        public int SafeId { get; set; }

        [ForeignKey(nameof(SafeId))]
        public required Safe Safe { get; set; } 
    }
}


