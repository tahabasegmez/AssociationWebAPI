using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;

using AssociationWebAPI.Application.DTOs;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Controllers
{
    [ApiController]
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public MemberController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("corporate/{id}")]
        public IActionResult GetCorporateMember(int id)
        {
            var member = _context.Members
                .OfType<Corporate>()
                .Where(m => m.Id == id)
                .Include(m => m.Address)
                .Include(m => m.Dues)
                .Include(m => m.Representatives)
                .FirstOrDefault();

            if (member == null)
            {
                return NotFound();
            }

            var memberDto = new CorporateResponseDto
            {
                CorporateName = member is Corporate corporate ? corporate.CorporateName : string.Empty,
                RegistrationDate = member.RegistrationDate,
                Status = member.Status,
                InactiveDate = member.InactiveDate,
                Email = member.Email,
                Phone = member.Phone,
                Address = new AddressResponseDto
                {
                    OpenAddress = member.Address.OpenAddress,
                    DistrictId = member.Address.DistrictId,
                    CityId = member.Address.CityId,
                    StateId = member.Address.StateId,
                    PostalCode = member.Address.PostalCode,
                    CountryId = member.Address.CountryId
                },
                RepresentativeIds = member.Representatives.Select(r => r.Id).ToList()
            };

            return Ok(memberDto);
        }

        [HttpPost("individual")]
        public IActionResult CreateIndividualMember([FromBody] IndividualRequestDto memberDto)
        {
            var member = new Individual
            {
                RegistrationDate = memberDto.RegistrationDate,
                Status = memberDto.Status,
                InactiveDate = memberDto.InactiveDate,
                Email = memberDto.Email,
                Phone = memberDto.Phone,
                Type = Domain.Enums.MemberType.Individual,
                Address = new Address
                {
                    OpenAddress = memberDto.Address.OpenAddress,
                    DistrictId = memberDto.Address.DistrictId,
                    CityId = memberDto.Address.CityId,
                    StateId = memberDto.Address.StateId,
                    PostalCode = memberDto.Address.PostalCode,
                    CountryId = memberDto.Address.CountryId,
                },
                Name = memberDto.Name,
                Surname = memberDto.Surname,
                NationalIdentityNumber = memberDto.NationalIdentityNumber,
                Occupation = memberDto.Occupation,
                BirthDate = memberDto.BirthDate,
                Birthplace = memberDto.Birthplace,
                EducationStatus = memberDto.EducationStatus
            };

            return Ok(member);
        }
    }
}
