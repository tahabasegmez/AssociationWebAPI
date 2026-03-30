using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssociationWebAPI.Domain.Entities
{
    public class Decision
    {
        public int Id { get; set; }

        public string Title { get; set; } = string.Empty;

        public string Body { get; set; } = string.Empty;


        public int MeetingId { get; set; }

        [ForeignKey("MeetingId")]
        public required Meeting Meeting { get; set; }
    }
}
