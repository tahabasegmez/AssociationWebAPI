using AssociationWebAPI.Domain.Entities;

namespace AssociationWebAPI.Application.Interfaces.Repositories;

public interface IAssociationRepository : IGenericRepository<Association>
{
    Task<Association?> GetFirstWithDetailsAsync(CancellationToken cancellationToken = default);
}
