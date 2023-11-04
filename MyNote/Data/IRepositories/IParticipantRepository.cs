using MyNote.DTOs;
using MyNote.Entites;
using MyNote.Inputs;

namespace MyNote.Data.IRepositories
{
	public interface IParticipantRepository
	{
        public List<Participant> GetParticipants();
        public void CreateParticipant(ParticipantDTO participant);
        public ParticipantDTO GetParticipant(string id);
        public void AddParticipantToMeeting(string participantId, Int64 meetingId);
        public List<MeetingDTO> GetMeetingsOfParticipant(string participantId);
        public List<NoteDTO> GetNotesOfParticipantInMeeting(string participantId, Int64 meetingId);
    }
}

