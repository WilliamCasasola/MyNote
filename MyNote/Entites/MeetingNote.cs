using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingNote")]
    public class MeetingNote
	{
        private int IdMeeting;
        private int IdParticipant;
        private int IdNote;
        

        public MeetingNote()
		{
		}
	}
}

