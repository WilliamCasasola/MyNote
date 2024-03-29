﻿using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.DTOs;
using MyNote.Entites;

namespace MyNote.Services
{
	public class MeetingService
	{
        private readonly IMeetingRepository _meetingRepo;
        private readonly MyNoteContext _myNote;
        public MeetingService(IMeetingRepository meetingRepo, MyNoteContext myNote)
        {
            _myNote = myNote;       
            _meetingRepo = meetingRepo;
		}

        public void CreateMeeting(Meeting meeting)
        {
            _meetingRepo.Add(meeting);
        }

        public void Add(Meeting meeting)
        {
            _myNote.GetMeetings().Add(meeting);
        }

        public List<Meeting> GetMeetings()
        {
            return _myNote.GetMeetings().ToList();
        }

        public MeetingDTO GetMeeting(Int64 id)
        {
            return _meetingRepo.GetMeeting(id);
        }
    }
}

