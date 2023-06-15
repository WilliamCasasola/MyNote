using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("Meeting")]
	public class Meeting
	{
        private int Id;
        private DateTime Date;
        private string Name;
        public Meeting()
		{
		}

        public int GetId() { return Id; }
        public void SetId(int id) { Id = id; }

        public DateTime GetDate() { return Date; }
        public void SetDate(DateTime date) { Date = date;  }
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name;  }


    }

    [Table("MeetingParticipant")]
    public class MeetingParticipant
    {
        private int IdMeeting;
        private int IdParticipant;


        public MeetingParticipant()
        {

        }

        public int GetIdMeeting() { return IdMeeting; }
        public void SetIdMeeting(int idMeeting) { IdMeeting = idMeeting; }
        public int GetIdParticipant() { return IdParticipant; }
        public void SetIdParticipant(int idParticipant) { IdParticipant = idParticipant; }
    }
}

