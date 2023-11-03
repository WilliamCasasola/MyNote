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
        public Int64 Id;
        [Column("idMeeting")]
        public Int64 IdMeeting;
        [Column("idParticipant")]
        public Int64 IdParticipant;
        [Column("idNote")]
        public Int64 IdNote;
        
        public MeetingNote()
		{
		}

        public Int64 GetId()
        {
            return Id;
        }
        
        public Int64 GetIdMeeting()
        {
            return IdMeeting;
        }

        public Int64 GetIdParticipant()
        {
            return IdParticipant;
        }

        public Int64 GetIdNote()
        {
            return IdNote;
        }
    }
}

