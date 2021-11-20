using Application.Interfaces;
using Domain;
using Microsoft.EntityFrameworkCore;

namespace Persistence
{
    public class NoteDbContext : DbContext, INoteDbContext
    {
        public DbSet<User> Users { get; set; }
        public DbSet<Note> Notes { get; set; }
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options) =>
            Database.EnsureCreated();
    }
}
