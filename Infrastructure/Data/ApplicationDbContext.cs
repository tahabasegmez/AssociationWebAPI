using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using AssociationWebAPI.Domain.Entities;

namespace AssociationWebAPI.Infrastructure.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        { 
        }
    
        public DbSet<Association> Association { get; set; }
        public DbSet<Member> Members { get; set; }
        public DbSet<Incoming> IncomingDocuments { get; set; }
        public DbSet<Outgoing> OutgoingDocuments { get; set; }
        public DbSet<Domain.Entities.Internal> InternalDocuments { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Member>()
                .HasDiscriminator(m => m.Type)
                .HasValue<Corporate>(Domain.Enums.MemberType.Corporate)
                .HasValue<Individual>(Domain.Enums.MemberType.Individual);

            modelBuilder.Entity<Corporate>()
                .OwnsOne(c => c.Address);
            
            modelBuilder.Entity<Individual>()
                .OwnsOne(i => i.Address);
            
            modelBuilder.Entity<Representative>()
                .OwnsOne(r => r.Address);

            modelBuilder.Entity<Association>()
                .OwnsOne(a => a.Address);

            modelBuilder.Entity<Association>()
                .HasMany(a => a.Administrators)
                .WithOne(ad => ad.Association)
                .HasForeignKey(a => a.AssociationId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Association>()
                .HasOne(a => a.Safe)
                .WithOne(ad => ad.Association)
                .HasForeignKey<Safe>(s => s.AssociationId);

            modelBuilder.Entity<Safe>()
                .HasMany(s => s.Incomes)
                .WithOne(i => i.Safe)
                .HasForeignKey(i => i.SafeId)
                .OnDelete(DeleteBehavior.NoAction);

            modelBuilder.Entity<Safe>()
                .HasMany(s => s.Expenses)
                .WithOne(e => e.Safe)
                .HasForeignKey(e => e.SafeId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Member>()
                .HasMany(m => m.Dues)
                .WithOne(d => d.Member)
                .HasForeignKey(d => d.MemberId)
                .OnDelete(DeleteBehavior.NoAction);
            
            modelBuilder.Entity<Individual>()
                .HasMany(i => i.Meetings)
                .WithMany(m => m.IndividualParticipants)
                .UsingEntity(j => j.ToTable("IndividualMeetingParticipants"));
            
            modelBuilder.Entity<Corporate>()
                .HasMany(c => c.Representatives)
                .WithOne(r => r.Corporate)
                .HasForeignKey(r => r.CorporateId)
                .OnDelete(DeleteBehavior.Cascade);

            modelBuilder.Entity<Representative>()
                .HasMany(r => r.Meetings)
                .WithMany(m => m.RepresentativeParticipants)
                .UsingEntity(j => j.ToTable("RepresentativeMeetingParticipants"));
        }
    }
}
