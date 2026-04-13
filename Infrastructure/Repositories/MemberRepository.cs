using AssociationWebAPI.Application.Interfaces.Repositories;
using AssociationWebAPI.Domain.Entities;
using AssociationWebAPI.Infrastructure.Data;
using Microsoft.EntityFrameworkCore;

namespace AssociationWebAPI.Infrastructure.Repositories;

public class MemberRepository : GenericRepository<Member>, IMemberRepository
{
    public MemberRepository(ApplicationDbContext context) : base(context)
    {
    }

    public async Task<Corporate?> GetCorporateByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.Members
            .OfType<Corporate>()
            .Where(m => m.Id == id)
            .Include(m => m.Address)
            .Include(m => m.Dues)
            .Include(m => m.Representatives)
            .FirstOrDefaultAsync(cancellationToken);
    }

    public async Task<Individual?> GetIndividualByIdAsync(int id, CancellationToken cancellationToken = default)
    {
        return await Context.Members
            .OfType<Individual>()
            .Where(m => m.Id == id)
            .Include(m => m.Address)
            .Include(m => m.Dues)
            .Include(m => m.Meetings)
            .FirstOrDefaultAsync(cancellationToken);
    }
}
