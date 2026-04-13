using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AssociationWebAPI.Application.Interfaces.Services;
using AssociationWebAPI.Application.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace AssociationWebAPI.Controllers
{
    [ApiController]
    [Route("api")]
    public class AssociationController : ControllerBase
    {
        private readonly IAssociationService _associationService;

        public AssociationController(IAssociationService associationService)
        {
            _associationService = associationService;
        }

        [HttpGet("association")]
        public async Task<IActionResult> GetAssociation(CancellationToken cancellationToken)
        {
            var association = await _associationService.GetAssociationAsync(cancellationToken);

            if (association is null)
            {
                return NotFound();
            }

            return Ok(association);
        }
    }
}
