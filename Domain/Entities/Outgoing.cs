using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssociationWebAPI.Domain.Entities
{
    public class Outgoing : Document
    {
        public string Receiver { get; set; } = string.Empty;
    }
}
