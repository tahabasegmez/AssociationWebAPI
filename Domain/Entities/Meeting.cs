using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AssociationWebAPI.Domain.Entities
{
    public class Meeting
    {
        public int Id { get; set; }

        public DateTime Date { get; set; }

        public string Location { get; set; } = string.Empty;

        public string Agenda { get; set; } = string.Empty;

        public string FolderPath { get; set; } = string.Empty;


        public List<Individual> IndividualParticipants { get; set; } = new List<Individual>();

        public List<Representative> RepresentativeParticipants { get; set; } = new List<Representative>();
        
        public List<Decision> Decisions { get; set; } = new List<Decision>();
    }
}
