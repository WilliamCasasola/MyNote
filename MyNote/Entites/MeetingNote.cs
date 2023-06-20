using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingNote")]
    public class MeetingNote
	{
        [Key]
        [Column("id")]
        public int Id;
        [Column("idMeeting")]
        public int IdMeeting;
        [Column("idParticipant")]
        public int IdParticipant;
        [Column("idNote")]
        public int IdNote;
        
        public MeetingNote()
		{
		}

        public int GetId()
        {
            return Id;
        }
        
        public int GetIdMeeting()
        {
            return IdMeeting;
        }

        public int GetIdParticipant()
        {
            return IdParticipant;
        }

        public int GetIdNote()
        {
            return IdNote;
        }
    }
}

