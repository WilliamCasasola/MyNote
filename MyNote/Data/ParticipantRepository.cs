using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.DTOs;
using MyNote.Entites;
using MyNote.Inputs;

namespace MyNote.Data
{
	public class ParticipantRepository : IParticipantRepository
	{
        private readonly MyNoteContext _myNote;

        public ParticipantRepository(MyNoteContext myNote)
		{
			_myNote = myNote;
		}

		public List<Participant> GetParticipants()
		{
			return _myNote.Participants.ToList();
		}

		public void CreateParticipant(ParticipantDTO participant)
		{
			_myNote.Add(new Participant
			{
				Email = participant.GetEmail(),
				Name = participant.GetName(),
				UserName = participant.GetUserName(),
				Password = participant.GetPassword(),
			});
		}

        public ParticipantDTO GetParticipant(string id)
        {
			Participant p = _myNote.Participants
                .Where(p => p.GetId().Equals(id)).FirstOrDefault();
			if(p is not null)
			{
				ParticipantDTO participant = new ParticipantDTO();
				participant.SetId(p.GetId());
				participant.SetEmail(p.GetEmail());
				participant.SetName(p.GetName());
				participant.SetUserName(p.GetUserName());
				participant.SetPassword(p.GetPassword());
				
				return participant;
			}
			else
			{
				return null;
			}
        }

        public void AddParticipantToMeeting(string participantId, Int64 meetingId)
		{
			MeetingParticipant mp = new MeetingParticipant();
			mp.SetIdMeeting(meetingId);
			mp.SetIdParticipant(participantId);
			_myNote.MeetingParticipants.Add(mp);
		}

        public List<MeetingDTO> GetMeetingsOfParticipant(string participantId)
        {            
			List<MeetingParticipant> meetingsP = _myNote.MeetingParticipants.Where(m => m.GetIdParticipant().Equals(participantId)).ToList();
			List<MeetingDTO> meetings = new List<MeetingDTO>();
			foreach(MeetingParticipant mp in meetingsP)
			{
				Meeting m = _myNote.Meetings.Where(m => m.GetId().Equals(mp.GetIdMeeting())).FirstOrDefault();
				MeetingDTO meeting = new MeetingDTO();
				meeting.SetDate(m.GetDate());
				meeting.SetId(m.GetId());
				meeting.SetName(m.GetName());
				meeting.SetT(m.T);
				meetings.Add(meeting);
			}
			return meetings;
        }

        public List<NoteDTO> GetNotesOfParticipantInMeeting(string participantId, Int64 meetingId)
        {
            List<MeetingNote> meetingsN = _myNote.MeetingNotes.Where(m => m.GetIdParticipant().Equals(participantId)
			&& m.GetIdMeeting().Equals(meetingId)).ToList();
            List<NoteDTO> notes = new List<NoteDTO>();
            foreach (MeetingNote mn in meetingsN)
            {
                Note m = _myNote.Notes.Where(m => m.GetId().Equals(mn.GetIdNote())).FirstOrDefault();
                NoteDTO note = new NoteDTO();
                note.SetId(m.GetId());
                note.SetIsGeneral(m.GetIsGeneral());
                note.SetText(m.GetText());
                notes.Add(note);
            }
            return notes;
        }
    }
}

