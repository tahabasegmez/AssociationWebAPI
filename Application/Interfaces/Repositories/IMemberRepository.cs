using AssociationWebAPI.Domain.Entities;

namespace AssociationWebAPI.Application.Interfaces.Repositories;

public interface IMemberRepository : IGenericRepository<Member>
{
    Task<Corporate?> GetCorporateByIdAsync(int id, CancellationToken cancellationToken = default);
    Task<Individual?> GetIndividualByIdAsync(int id, CancellationToken cancellationToken = default);
}
