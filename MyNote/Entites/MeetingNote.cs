using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingNote")]
    public class MeetingNote
	{
        public Int64 Id { get; set; }
        public Int64 IdMeeting { get; set; }
        public Int64 IdParticipant { get; set; }
        public Int64 IdNote { get; set; }
       
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

