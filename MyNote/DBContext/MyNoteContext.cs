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


        public DbSet<Meeting> Meetings
        {
            get
            {
                return _meetings;
            }
            set
            {
                _meetings = value;
            }
        }

        public DbSet<Meeting> GetMeetings()
        {
            return Meetings;
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
            return Notes;
        }


        public DbSet<Participant> _participants;

        public DbSet<Participant> Participants
        {
            get
            {
                return _participants;
            }
            set
            {
                _participants = value;
            }
        }

        public DbSet<Participant> GetParticipants()
        {
            return Participants;
        }

        public DbSet<MeetingNote> _meetingNotes;

        public DbSet<MeetingNote> MeetingNotes
        {
            get
            {
                return _meetingNotes;
            }
            set
            {
                _meetingNotes = value;
            }
        }

        public DbSet<MeetingNote> GetMeetingNotes()
        {
            return MeetingNotes;
        }

        public DbSet<MeetingParticipant> _meetingParticipants;

        public DbSet<MeetingParticipant> MeetingParticipants
        {
            get
            {
                return _meetingParticipants;
            }
            set
            {
                _meetingParticipants = value;
            }
        }

        public DbSet<MeetingParticipant> GetMeetingParticipants()
        {
            return MeetingParticipants;
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

            modelBuilder.Entity<Note>().HasKey(e => e.Id);
            modelBuilder.Entity<Meeting>().HasKey(e => e.Id);
            modelBuilder.Entity<Participant>().HasKey(e => e.Id);
            modelBuilder.Entity<MeetingNote>().HasKey(e => e.Id);
            modelBuilder.Entity<MeetingParticipant>().HasKey(e => e.Id);


          
            base.OnModelCreating(modelBuilder);
        }    
    }
}

