using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public class Administrator
    {
        public int Id { get; set; }

        public AuthorizationLevel AuthorizationLevel { get; set; }

        public DateTime RegisterDate { get; set; } = DateTime.Now;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public int NationalIdentityNumber { get; set; }

        public string Occupation { get; set; } = string.Empty;

        public DateTime? BirthDate { get; set; }

        public string? Birthplace { get; set; }


        public int AssociationId { get; set; }

        [ForeignKey(nameof(AssociationId))]
        public required Association Association { get; set; }
    }
}
