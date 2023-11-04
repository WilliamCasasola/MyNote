using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingParticipant")]
    public class MeetingParticipant
    {
        [Key]
        [Column("id")]
        public Int64 Id;
        [Column("idMeeting")]
        public Int64 IdMeeting;
        [Column("idParticipant")]
        public string IdParticipant;


        public MeetingParticipant()
        {

        }

        public Int64 GetIdMeeting() { return IdMeeting; }
        public void SetIdMeeting(Int64 idMeeting) { IdMeeting = idMeeting; }
        public string GetIdParticipant() { return IdParticipant; }
        public void SetIdParticipant(string idParticipant) { IdParticipant = idParticipant; }
    }
}

