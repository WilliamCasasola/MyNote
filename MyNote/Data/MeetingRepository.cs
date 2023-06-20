using System;
using MyNote.Data.IRepositories;
using MyNote.DBContext;
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

		public void CreateMeeting(Meeting meeting)
		{
			_myNote.GetMeetings().Add(meeting);
		}

		public void CreateMeetingParticipant(MeetingParticipant meetingParticipant)
		{
			_myNote.GetMeetingParticipants().Add(meetingParticipant);
		}

		public Meeting GetMeeting(int id)
		{
			return _myNote.GetMeetings().Where(m =>IsIdEqual(m, id)).FirstOrDefault();			

		}

		public bool IsIdEqual(Meeting m, int id)
		{
			return m.Id == id;
		}
	}
}

