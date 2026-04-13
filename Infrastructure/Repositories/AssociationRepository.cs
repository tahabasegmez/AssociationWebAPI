using AssociationWebAPI.Application.Interfaces.Repositories;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Infrastructure.Repositories;

public class AssociationRepository : GenericRepository<Association>, IAssociationRepository
{
    public AssociationRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Association?> GetFirstWithDetailsAsync(CancellationToken cancellationToken = default)
    {
        return await Context.Association
            .Include(a => a.Address)
            .Include(a => a.Safe)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
