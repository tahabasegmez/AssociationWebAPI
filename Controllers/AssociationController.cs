using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Infrastructure.Data;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssociationWebAPI.Controllers
{
    public class AssociationController : ControllerBase
    {
        private readonly ApplicationDbContext _context;

        public AssociationController(ApplicationDbContext context)
        {
            _context = context;
        }

        [HttpGet("association")]
        public IActionResult GetAssociation()
        {
            var association = _context.Association.FirstOrDefault();
            if (association == null)
            {
                return NotFound();
            }
            var associationDto = new AssociationRequestDto
            {
                Name = association.Name,
                Description = association.Description,
                Address = new AddressRequestDto
                {
                    OpenAddress = association.Address.OpenAddress,
                    DistrictId = association.Address.DistrictId,
                    CityId = association.Address.CityId,
                    StateId = association.Address.StateId,
                    PostalCode = association.Address.PostalCode,
                    CountryId = association.Address.CountryId
                },
                Safe = new SafeRequestDto
                {
                    Balance = association.Safe.Balance,
                }
            };
            return Ok(associationDto);
        }
    }
}
