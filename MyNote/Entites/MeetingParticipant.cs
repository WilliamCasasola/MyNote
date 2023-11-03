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
        public Int64 Id;
        [Column("idMeeting")]
        public Int64 IdMeeting;
        [Column("idParticipant")]
        public Int64 IdParticipant;


        public MeetingParticipant()
        {

        }

        public Int64 GetIdMeeting() { return IdMeeting; }
        public void SetIdMeeting(Int64 idMeeting) { IdMeeting = idMeeting; }
        public Int64 GetIdParticipant() { return IdParticipant; }
        public void SetIdParticipant(Int64 idParticipant) { IdParticipant = idParticipant; }
    }
}

