
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Infrastructure.Data;
using Microsoft.AspNetCore.Mvc;
using AssociationWebAPI.Application.DTOs;
using Microsoft.EntityFrameworkCore;
using AssociationWebAPI.Application.Mappers;

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
        public IActionResult GetCorporateMember([FromRoute] int id)
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

            var memberDto = DefaultDtoEntityMapperExtensions.ToResponseDto(member);
            
            return Ok(memberDto);
        }

        [HttpGet("individual/{id}")]
        public IActionResult GetIndividualMember([FromRoute] int id)
        {
            var member = _context.Members
                .OfType<Individual>()
                .Where(m => m.Id == id)
                .Include(m => m.Address)
                .FirstOrDefault();

            if (member == null)
            {
                return NotFound();
            }

            var memberDto = DefaultDtoEntityMapperExtensions.ToResponseDto(member);

            return Ok(memberDto);
        }

        [HttpPost("individual")]
        public IActionResult CreateIndividualMember([FromBody] IndividualRequestDto memberDto)
        {
            var member = DefaultDtoEntityMapperExtensions.ToEntity(memberDto);

            _context.Members.Add(member); 
            _context.SaveChanges();
            return CreatedAtAction(nameof(GetIndividualMember), new { id = member.Id }, member);
        }
    }
}
