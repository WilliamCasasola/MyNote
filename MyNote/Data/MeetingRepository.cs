﻿using System;
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

        public void Add(Meeting meeting)
		{
			_myNote.GetMeetings().Add(meeting);
		}

		public void CreateMeetingParticipant(MeetingParticipant meetingParticipant)
		{
			_myNote.GetMeetingParticipants().Add(meetingParticipant);
		}

		public Meeting GetMeeting(int id)
		{
			return _myNote.GetMeetings().Where(m => m.T).FirstOrDefault();			

		}
		
	}
}

