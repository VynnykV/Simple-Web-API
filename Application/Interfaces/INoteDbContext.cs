using Domain;
using Microsoft.EntityFrameworkCore;
using System.Threading;
using System.Threading.Tasks;

namespace Application.Interfaces
{
    public interface INoteDbContext
    {
        
        DbSet<Note> Notes { get; set; }
        Task<int> SaveChangesAsync(CancellationToken cancellationToken);
    }
}
