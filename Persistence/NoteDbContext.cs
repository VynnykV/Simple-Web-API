using Application.Interfaces;
using Domain;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;

namespace Persistence
{
    public class NoteDbContext : IdentityDbContext<User,IdentityRole<int>,int>, INoteDbContext
    {
        public DbSet<Note> Notes { get; set; }
        public NoteDbContext(DbContextOptions<NoteDbContext> options) : base(options) { }
    }
}
