using AssociationWebAPI.Application.DTOs;
using AssociationWebAPI.Application.Interfaces.Repositories;
using AssociationWebAPI.Application.Interfaces.Services;
using AssociationWebAPI.Application.Mappers;

namespace AssociationWebAPI.Application.Services;

public class AssociationService : IAssociationService
{
    private readonly IAssociationRepository _associationRepository;

    public AssociationService(IAssociationRepository associationRepository)
    {
        _associationRepository = associationRepository;
    }

    public async Task<AssociationRequestDto?> GetAssociationAsync(CancellationToken cancellationToken = default)
    {
        var association = await _associationRepository.GetFirstWithDetailsAsync(cancellationToken);
        return association?.ToRequestDto();
    }
}
