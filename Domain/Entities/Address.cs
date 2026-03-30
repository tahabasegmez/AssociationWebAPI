using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Domain.Entities
{
    [Owned]
    public class Address
    {
        public string OpenAddress { get; set; } = string.Empty;

        public int DistrictId { get; set; }

        public int CityId { get; set; }

        public int StateId { get; set; }

        public string PostalCode { get; set; } = string.Empty;

        public int CountryId { get; set; }
    }
}
