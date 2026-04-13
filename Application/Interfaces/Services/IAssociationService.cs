using AssociationWebAPI.Application.DTOs;

namespace AssociationWebAPI.Application.Interfaces.Services;

public interface IAssociationService
{
    Task<AssociationRequestDto?> GetAssociationAsync(CancellationToken cancellationToken = default);
}
