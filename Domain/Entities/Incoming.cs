using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Domain.Entities
{
    public class Incoming : Document
    {
        public string Sender { get; set; } = string.Empty;
    }
}
