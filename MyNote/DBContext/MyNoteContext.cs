using System.Reflection;
using Microsoft.EntityFrameworkCore;
using MyNote.Entites;

namespace MyNote.DBContext
{
	public class MyNoteContext : DbContext
	{
		protected readonly IConfiguration Configuration;
		public MyNoteContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

        public MyNoteContext()
        {
         
        }
        public DbSet<Meeting> _meetings;

		public DbSet<Meeting> GetMeetings()
		{
			return _meetings;
		}

		public void SetMeetings(DbSet<Meeting> meetings)
		{
			_meetings = meetings;
		}

        private DbSet<Note> _notes;

        public DbSet<Note> Notes {
            get {
                return _notes;
            } set {
                _notes = value;
            }
        }

        public DbSet<Note> GetNotes()
        {
            return _notes;
        }

        public void SetMeetings(DbSet<Note> notes)
        {
            _notes = notes;
        }

        public DbSet<Participant> _participants;

        public DbSet<Participant> GetParticipants()
        {
            return _participants;
        }

        public void SetParticipantss(DbSet<Participant> participants)
        {
            _participants = participants;
        }

        public DbSet<MeetingNote> _meetingNotes;

        public DbSet<MeetingNote> GetMeetingNotes()
        {
            return _meetingNotes;
        }

        public void SetMeetingNotess(DbSet<MeetingNote> meetingNotes)
        {
            _meetingNotes = meetingNotes;
        }

        public DbSet<MeetingParticipant> _meetingParticipants;

        public DbSet<MeetingParticipant> GetMeetingParticipants()
        {
            return _meetingParticipants;
        }

        public void SetMeetings(DbSet<MeetingParticipant> meetingParticipants)
        {
            _meetingParticipants = meetingParticipants;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Filename=MyNote.db", options =>
            {
                options.MigrationsAssembly(Assembly.GetExecutingAssembly().FullName);
            });
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Map table names
            modelBuilder.Entity<Note>().ToTable("Note");
            //     .Property(e => e.GetId())
            //    .HasConversion<int>();

            modelBuilder.Entity<Note>(entity =>
            {
                entity.Property(e => e.Text).HasColumnName("text");
                entity.Property(e => e.IsGeneral).HasColumnName("isGeneral");
                entity.Property(e => e.Id).HasColumnName("Id");

            });
                                

                //entity.HasKey(e => e.GetId());

           /* modelBuilder.Entity<Meeting>().ToTable("Meeting");
            modelBuilder.Entity<Meeting>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MeetingNote>().ToTable("MeetingNote");
            modelBuilder.Entity<MeetingNote>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<MeetingParticipant>().ToTable("MeetingParticipant");
            modelBuilder.Entity<MeetingParticipant>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });

            modelBuilder.Entity<Participant>().ToTable("Participant");
            modelBuilder.Entity<Participant>(entity =>
            {
                entity.HasKey(e => e.BlogId);
                entity.HasIndex(e => e.Title).IsUnique();
                entity.Property(e => e.DateTimeAdd).HasDefaultValueSql("CURRENT_TIMESTAMP");
            });*/
            base.OnModelCreating(modelBuilder);
        }    
    }
}

