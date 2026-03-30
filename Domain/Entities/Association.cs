using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AssociationWebAPI.Domain.Entities
{
    public class Association
    {
        public int Id { get; set; } = 1;

        public string Name { get; set; } = string.Empty;

        public string Description { get; set; } = string.Empty;


        public List<Administrator> Administrators { get; set; } = new List<Administrator>();

        public required Safe Safe { get; set; }

        public required Address Address { get; set; }
    }
}
