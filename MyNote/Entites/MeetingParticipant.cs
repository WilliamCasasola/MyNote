using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("MeetingParticipant")]
    public class MeetingParticipant
    {
        [Key]
        [Column("id")]
        public int Id;
        [Column("idMeeting")]
        public int IdMeeting;
        [Column("idParticipant")]
        public int IdParticipant;


        public MeetingParticipant()
        {

        }

        public int GetIdMeeting() { return IdMeeting; }
        public void SetIdMeeting(int idMeeting) { IdMeeting = idMeeting; }
        public int GetIdParticipant() { return IdParticipant; }
        public void SetIdParticipant(int idParticipant) { IdParticipant = idParticipant; }
    }
}

