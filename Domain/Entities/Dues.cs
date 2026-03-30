using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Data.SqlTypes;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public class Dues
    {
        public int Id { get; set; }

        public DateTime Period { get; set; } 

        public DateTime DueDate { get; set; }

        [Column(TypeName = "decimal(18,2)")]
        public decimal Amount { get; set; } 

        public DuesStatus Status { get; set; }


        public int MemberId { get; set; }

        [ForeignKey(nameof(MemberId))]
        public required Member Member { get; set; }

        public int IncomeId { get; set; }

        [ForeignKey(nameof(IncomeId))]
        public required Income Income { get; set; }
    }
}


