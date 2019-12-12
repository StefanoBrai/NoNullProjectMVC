using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace WebApplication1.Models
{
    public partial class NoNullProjectContext : DbContext
    {
        public NoNullProjectContext()
        {
        }

        public NoNullProjectContext(DbContextOptions<NoNullProjectContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Availability> Availabilities { get; set; }
        public virtual DbSet<Bid> Bid { get; set; }
        public virtual DbSet<Candidature> Candidature { get; set; }
        public virtual DbSet<Company> Companies { get; set; }
        public virtual DbSet<CompanyReference> CompanyReference { get; set; }
        public virtual DbSet<Destination> Destinations { get; set; }
        public virtual DbSet<GeneralArea> GeneralArea { get; set; }
        public virtual DbSet<Professionist> Professionists { get; set; }
        public virtual DbSet<Project> Projects { get; set; }
        public virtual DbSet<Request> Requests { get; set; }
        public virtual DbSet<Skill> Skills { get; set; }
        public virtual DbSet<TrackRequest> TrackRequests { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. See http://go.microsoft.com/fwlink/?LinkId=723263 for guidance on storing connection strings.
                optionsBuilder.UseSqlServer("Server=127.0.0.1;Database=NoNullProject;user=sa;password=SQL_server0%");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Availability>(entity =>
            {
                entity.HasKey(e => e.Avaid);

                entity.ToTable("Availabilities", "NoNull");

                entity.Property(e => e.Avaid).HasColumnName("avaid");

                entity.Property(e => e.BeginningDate)
                    .HasColumnName("beginningdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.DestinationId).HasColumnName("destinationid");

                entity.Property(e => e.EndingDate)
                    .HasColumnName("endingdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Availabilities)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Availabilities_Destinations");

                entity.HasOne(d => d.Prof)
                    .WithMany(p => p.Availabilities)
                    .HasForeignKey(d => d.ProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ava_Prof");
            });

            modelBuilder.Entity<Bid>(entity =>
            {
                entity.ToTable("Bid", "NoNull");

                entity.Property(e => e.BidId).HasColumnName("bidid");

                entity.Property(e => e.Acceptation).HasColumnName("acceptation");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(120);

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.Property(e => e.ReqId).HasColumnName("reqid");

                entity.Property(e => e.SendData)
                    .HasColumnName("senddata")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Prof)
                    .WithMany(p => p.Bid)
                    .HasForeignKey(d => d.ProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bid_Prof");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.Bid)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Bid_Req");
            });

            modelBuilder.Entity<Candidature>(entity =>
            {
                entity.ToTable("Candidature", "NoNull");

                entity.Property(e => e.CandidatureId).HasColumnName("candidatureid");

                entity.Property(e => e.Acceptation).HasColumnName("acceptation");

                entity.Property(e => e.Message)
                    .IsRequired()
                    .HasColumnName("message")
                    .HasMaxLength(120);

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.Property(e => e.ReqId).HasColumnName("reqid");

                entity.Property(e => e.SendData)
                    .HasColumnName("senddata")
                    .HasColumnType("datetime");

                entity.HasOne(d => d.Prof)
                    .WithMany(p => p.Candidature)
                    .HasForeignKey(d => d.ProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidature_Prof");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.Candidature)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Candidature_Req");
            });

            modelBuilder.Entity<Company>(entity =>
            {
                entity.HasKey(e => e.CompId);

                entity.ToTable("Companies", "NoNull");

                entity.Property(e => e.CompId).HasColumnName("compid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(60);

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(15);

                entity.Property(e => e.DestinationId).HasColumnName("destinationid");

                entity.Property(e => e.GeneralareaId).HasColumnName("generalareaid");

                entity.Property(e => e.Mission)
                    .IsRequired()
                    .HasColumnName("mission")
                    .HasMaxLength(120);

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(80);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(15);

                entity.Property(e => e.Type)
                    .IsRequired()
                    .HasColumnName("type")
                    .HasMaxLength(20);

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_Destinations");

                entity.HasOne(d => d.Generalarea)
                    .WithMany(p => p.Companies)
                    .HasForeignKey(d => d.GeneralareaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Company_GeneralArea");
            });

            modelBuilder.Entity<CompanyReference>(entity =>
            {
                entity.HasKey(e => e.RefId);

                entity.ToTable("CompanyReference", "NoNull");

                entity.Property(e => e.RefId).HasColumnName("refid");

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompId).HasColumnName("compid");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(10);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(20);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(40);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(24);

                entity.HasOne(d => d.Comp)
                    .WithMany(p => p.CompanyReference)
                    .HasForeignKey(d => d.CompId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Ref_Comp");
            });

            modelBuilder.Entity<Destination>(entity =>
            {
                entity.HasKey(e => e.DestinationId);

                entity.ToTable("Destinations", "NoNull");

                entity.Property(e => e.DestinationId).HasColumnName("destinationid");

                entity.Property(e => e.MacroArea).HasColumnName("macroarea");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);

                entity.HasOne(d => d.MacroareaNavigation)
                    .WithMany(p => p.InverseMacroareaNavigation)
                    .HasForeignKey(d => d.MacroArea)
                    .HasConstraintName("FK_Dest_Dest");
            });

            modelBuilder.Entity<GeneralArea>(entity =>
            {
                entity.ToTable("GeneralArea", "NoNull");

                entity.Property(e => e.GeneralareaId).HasColumnName("generalareaid");

                entity.Property(e => e.Name)
                    .IsRequired()
                    .HasColumnName("name")
                    .HasMaxLength(20);
            });

            modelBuilder.Entity<Professionist>(entity =>
            {
                entity.HasKey(e => e.ProfId);

                entity.ToTable("Professionists", "NoNull");

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.Property(e => e.Address)
                    .IsRequired()
                    .HasColumnName("address")
                    .HasMaxLength(60);

                entity.Property(e => e.Birthdate)
                    .HasColumnName("birthdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.City)
                    .IsRequired()
                    .HasColumnName("city")
                    .HasMaxLength(15);

                entity.Property(e => e.DestinationId).HasColumnName("destinationid");

                entity.Property(e => e.Firstname)
                    .IsRequired()
                    .HasColumnName("firstname")
                    .HasMaxLength(10);

                entity.Property(e => e.Lastname)
                    .IsRequired()
                    .HasColumnName("lastname")
                    .HasMaxLength(20);

                entity.Property(e => e.Mail)
                    .IsRequired()
                    .HasColumnName("mail")
                    .HasMaxLength(40);

                entity.Property(e => e.MaxAvailability)
                    .IsRequired()
                    .HasColumnName("maxavailability")
                    .HasMaxLength(40);

                entity.Property(e => e.MinAvailability)
                    .IsRequired()
                    .HasColumnName("minavailability")
                    .HasMaxLength(20);

                entity.Property(e => e.Phone)
                    .IsRequired()
                    .HasColumnName("phone")
                    .HasMaxLength(24);

                entity.Property(e => e.Postalcode)
                    .HasColumnName("postalcode")
                    .HasMaxLength(10);

                entity.Property(e => e.Profession)
                    .IsRequired()
                    .HasColumnName("profession")
                    .HasMaxLength(60);

                entity.Property(e => e.Region)
                    .HasColumnName("region")
                    .HasMaxLength(15);

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Professionists)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Prof_Destinations");
            });

            modelBuilder.Entity<Project>(entity =>
            {
                entity.HasKey(e => e.ProjId);

                entity.ToTable("Projects", "NoNull");

                entity.Property(e => e.ProjId).HasColumnName("projid");

                entity.Property(e => e.CompId).HasColumnName("compid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(120);

                entity.Property(e => e.GeneralareaId).HasColumnName("generalareaid");

                entity.HasOne(d => d.Comp)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.CompId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proj_Comp");

                entity.HasOne(d => d.Generalarea)
                    .WithMany(p => p.Projects)
                    .HasForeignKey(d => d.GeneralareaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Proj_GeneralArea");
            });

            modelBuilder.Entity<Request>(entity =>
            {
                entity.HasKey(e => e.ReqId)
                    .HasName("PK_REqeusts");

                entity.ToTable("Requests", "NoNull");

                entity.Property(e => e.ReqId).HasColumnName("reqid");

                entity.Property(e => e.BeginningDate)
                    .HasColumnName("beginningdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.CompId).HasColumnName("compid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(120);

                entity.Property(e => e.DestinationId).HasColumnName("destinationid");

                entity.Property(e => e.EndingDate)
                    .HasColumnName("endingdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.ProjId).HasColumnName("projid");

                entity.Property(e => e.SkillId).HasColumnName("skillid");

                entity.HasOne(d => d.Comp)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.CompId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Req_Comp");

                entity.HasOne(d => d.Destination)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.DestinationId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Req_Destinations");

                entity.HasOne(d => d.Proj)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.ProjId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Req_Proj");

                entity.HasOne(d => d.Skill)
                    .WithMany(p => p.Requests)
                    .HasForeignKey(d => d.SkillId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Req_Skill");
            });

            modelBuilder.Entity<Skill>(entity =>
            {
                entity.HasKey(e => e.SkillId);

                entity.ToTable("Skills", "NoNull");

                entity.Property(e => e.SkillId).HasColumnName("skillid");

                entity.Property(e => e.Description)
                    .IsRequired()
                    .HasColumnName("description")
                    .HasMaxLength(120);

                entity.Property(e => e.GeneralareaId).HasColumnName("generalareaid");

                entity.Property(e => e.Level).HasColumnName("level");

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.Property(e => e.Detail)
                    .IsRequired()
                    .HasColumnName("detail")
                    .HasMaxLength(120);

                entity.HasOne(d => d.Generalarea)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.GeneralareaId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_GeneralArea");

                entity.HasOne(d => d.Prof)
                    .WithMany(p => p.Skills)
                    .HasForeignKey(d => d.ProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Skills_Profs");
            });

            modelBuilder.Entity<TrackRequest>(entity =>
            {
                entity.HasKey(e => e.TrackId);

                entity.ToTable("TrackRequests", "NoNull");

                entity.Property(e => e.TrackId).HasColumnName("trackid");

                entity.Property(e => e.BeginningDate)
                    .HasColumnName("beginningdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Compcomment)
                    .HasColumnName("compcomment")
                    .HasMaxLength(120);

                entity.Property(e => e.EndingDate)
                    .HasColumnName("endingdate")
                    .HasColumnType("datetime");

                entity.Property(e => e.Profcomment)
                    .HasColumnName("profcomment")
                    .HasMaxLength(120);

                entity.Property(e => e.ProfId).HasColumnName("profid");

                entity.Property(e => e.ReqId).HasColumnName("reqid");

                entity.HasOne(d => d.Prof)
                    .WithMany(p => p.TrackRequests)
                    .HasForeignKey(d => d.ProfId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Track_Prof");

                entity.HasOne(d => d.Req)
                    .WithMany(p => p.TrackRequests)
                    .HasForeignKey(d => d.ReqId)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Track_Req");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
