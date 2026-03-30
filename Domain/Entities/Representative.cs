using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public class Representative
    {
        public int Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public Gender Gender { get; set; }

        public int NationalIdentityNumber { get; set; }

        public string ParentName { get; set; } = string.Empty;

        public string Title { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public string Email { get; set; } = string.Empty; 

        public string Occupation { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; } = DateTime.MaxValue;

        public string Birthplace { get; set; } = string.Empty;

        public EducationStatus EducationStatus { get; set; } = EducationStatus.NoInformation;

        public DateTime RepresentationStartDate { get; set; } = DateTime.MaxValue;


        public int CorporateId { get; set; }

        [ForeignKey(nameof(CorporateId))]
        public required Corporate Corporate { get; set; }

        public required Address Address { get; set; }

        public List<Meeting> Meetings { get; set; } = new List<Meeting>();
    }
}
