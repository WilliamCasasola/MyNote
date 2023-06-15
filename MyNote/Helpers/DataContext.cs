using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using MyNote.Entites;

namespace MyNote.Helpers
{
	public class DataContext : DbContext
	{
		protected readonly IConfiguration Configuration;
		public DataContext(IConfiguration configuration)
		{
			Configuration = configuration;
		}

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sqlite database
            options.UseSqlite(Configuration.GetConnectionString("WebApiDatabase"));
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

        public DbSet<Note> _notes;

        public DbSet<Note> GetNots()
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

        public void SetMeetings(DbSet<Participant> participants)
        {
            _participants = participants;
        }
    }
}

