using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Domain.Entities
{
    public class Individual : Member
    {
        public string Name { get; set; } = string.Empty;

        public string Surname { get; set; } = string.Empty;

        public int NationalIdentityNumber { get; set; }

        public string Occupation { get; set; } = string.Empty;

        public DateTime BirthDate { get; set; }

        public string Birthplace { get; set; } = string.Empty;

        public EducationStatus EducationStatus { get; set; } = EducationStatus.NoInformation;

        public List<Meeting> Meetings { get; set; } = new List<Meeting>();
    }
}


