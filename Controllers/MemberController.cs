
using AssociationWebAPI.Application.Interfaces.Services;
using Microsoft.AspNetCore.Mvc;
using AssociationWebAPI.Application.DTOs;

namespace AssociationWebAPI.Controllers
{
    [ApiController]
    [Route("api/member")]
    public class MemberController : ControllerBase
    {
        private readonly IMemberService _memberService;

        public MemberController(IMemberService memberService)
        {
            _memberService = memberService;
        }

        [HttpGet("corporate/{id}")]
        public async Task<IActionResult> GetCorporateMember([FromRoute] int id, CancellationToken cancellationToken)
        {
            var member = await _memberService.GetCorporateMemberAsync(id, cancellationToken);

            if (member == null)
            {
                return NotFound();
            }
            
            return Ok(member);
        }

        [HttpGet("individual/{id}")]
        public async Task<IActionResult> GetIndividualMember([FromRoute] int id, CancellationToken cancellationToken)
        {
            var member = await _memberService.GetIndividualMemberAsync(id, cancellationToken);

            if (member == null)
            {
                return NotFound();
            }

            return Ok(member);
        }

        [HttpPost("individual")]
        public async Task<IActionResult> CreateIndividualMember([FromBody] IndividualRequestDto memberDto, CancellationToken cancellationToken)
        {
            if (memberDto == null)
            {
                return BadRequest();
            }

            var member = await _memberService.CreateIndividualMemberAsync(memberDto, cancellationToken);
            return CreatedAtAction(nameof(GetIndividualMember), new { id = member.Id }, member);
        }
    }
}
