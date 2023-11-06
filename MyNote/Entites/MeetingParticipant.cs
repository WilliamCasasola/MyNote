using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingParticipant")]
    public class MeetingParticipant
    {
        public Int64 Id { get; set; }
        public Int64 IdMeeting { get; set; }
        public string IdParticipant { get; set; }

        public Int64 GetIdMeeting() { return IdMeeting; }
        public void SetIdMeeting(Int64 idMeeting) { IdMeeting = idMeeting; }
        public string GetIdParticipant() { return IdParticipant; }
        public void SetIdParticipant(string idParticipant) { IdParticipant = idParticipant; }
    }
}

