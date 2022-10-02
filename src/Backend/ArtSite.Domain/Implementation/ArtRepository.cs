using ArtSite.Data;
using ArtSite.Data.Models;
using ArtSite.Domain.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace ArtSite.Domain.Implementation;

public class ArtRepository : IArtRepository
{
    private readonly ArtSiteDbContext _context;

    public ArtRepository(string connectionString)
    {
        _context = new ArtSiteDbContext(connectionString);
    }

    public async ValueTask CreateAndSave(Art entity)
    {
        await _context.Arts.AddAsync(entity);
        await _context.SaveChangesAsync();
    }

    public async ValueTask<IList<Art>> GetAll()
    {
        var arts = await _context.Arts
            .AsNoTracking()
            .ToListAsync();

        return arts;
    }

    public async ValueTask<Art> GetById(Guid id)
    {
        var art = await _context.Arts.FirstOrDefaultAsync(a => a.Id == id);

        return art;
    }
}
