using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System.ComponentModel.DataAnnotations.Schema;

namespace AssociationWebAPI.Domain.Entities
{
    public class Corporate : Member
    {
        public string CorporateName { get; set; } = string.Empty;

        public string TaxOffice { get; set; } = string.Empty;

        public string TaxNumber { get; set; } = string.Empty;

        public string FinancialMail { get; set; } = string.Empty;

        public string BRN { get; set; } = string.Empty;

        public DateTime BRD { get; set; } = DateTime.MaxValue;

        public string FaxNumber { get; set; } = string.Empty;

        public string Website { get; set; } = string.Empty;


        public List<Representative> Representatives { get; set; } = new List<Representative>();
    }
}


