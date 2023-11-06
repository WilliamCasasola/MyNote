using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.DTOs;
using MyNote.Entites;
using MyNote.Inputs;

namespace MyNote.Services
{
	public class ParticipantService
	{
        private readonly MyNoteContext _myNote;
        private IParticipantRepository _participantRepo;

        public ParticipantService(MyNoteContext myNote,
            IParticipantRepository participantRepository)
		{
			_myNote = myNote;
            _participantRepo = participantRepository;
		}

		public List<Participant> getParticipants() {
			return _myNote.Participants.ToList();
		}

        public void CreateParticipant(ParticipantDTO participant)
        {
            _participantRepo.CreateParticipant(participant);
        }

        public ParticipantDTO GetParticipant(string id)
        {
            return _participantRepo.GetParticipant(id);
        }

        public void AddParticipantToMeeting(string participantId, Int64 meetingId)
        {
            _participantRepo.AddParticipantToMeeting(participantId, meetingId);
        }

        public List<NoteDTO> GetNotesOfParticipantInMeeting(string participantId, Int64 meetingId)
        {
            return _participantRepo.GetNotesOfParticipantInMeeting(participantId, meetingId);
        }

        public List<MeetingDTO> GetMeetingsOfParticipant(string participantId)
        {
            return _participantRepo.GetMeetingsOfParticipant(participantId);
        }
    }
}

