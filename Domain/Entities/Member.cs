using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Enums;

namespace AssociationWebAPI.Domain.Entities
{
    public abstract class Member
    {
        public int Id { get; set; }

        public DateTime RegistrationDate { get; set; }

        public MemberStatus Status { get; set; }

        public DateTime InactiveDate { get; set; } = DateTime.MaxValue;

        public string Email { get; set; } = string.Empty;

        public string Phone { get; set; } = string.Empty;

        public MemberType Type { get; set; }


        public required Address Address { get; set; }

        public List<Dues> Dues { get; set; } = new List<Dues>();
    }
}



