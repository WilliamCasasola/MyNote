using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.DTOs;
using MyNote.Entites;

namespace MyNote.Data
{
	public class MeetingRepository : IMeetingRepository
	{
		private readonly MyNoteContext _myNote;
		public MeetingRepository(MyNoteContext myNote)
		{
			_myNote = myNote;
		}

        public void Add(Meeting meeting)
		{
			_myNote.Meetings.Add(meeting);
		}

		public void CreateMeetingParticipant(MeetingParticipant meetingParticipant)
		{
			_myNote.GetMeetingParticipants().Add(meetingParticipant);
		}

		public MeetingDTO GetMeeting(Int64 id)
		{
			Meeting meeting = _myNote.GetMeetings().Where(m => m.GetId().Equals(id)).FirstOrDefault();
			if (meeting is not null) {
				MeetingDTO meetingDTO = new MeetingDTO();
				meeting.SetId(meeting.GetId());
				meeting.SetDate(meeting.GetDate());
				meeting.SetName(meeting.GetName());
				return meetingDTO;
			}
			return null;
		}
		
	}
}

