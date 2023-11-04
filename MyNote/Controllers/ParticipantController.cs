using System;
using MyNote.DTOs;
using MyNote.Inputs;
using MyNote.Services;

namespace MyNote.Controllers
{
	public class ParticipantController
	{
        private readonly CalendarService _calendarService;
        private readonly MeetingService _meetingService;
        private readonly NoteService _noteService;
        private readonly ParticipantService _participantService;

        public ParticipantController(
			CalendarService calendarService,
			MeetingService meetingService,
			NoteService noteService,
			ParticipantService participantService)
		{
			_calendarService = calendarService;
			_meetingService = meetingService;
			_noteService = noteService;
			_participantService = participantService;
		}

		public ParticipantDTO GetParticipant(string id)
		{
			return _participantService.GetParticipant(id);
		}

        public List<MeetingDTO> GetMeetingsOfParticipant(string participantId)
        {
            return _participantService.GetMeetingsOfParticipant(participantId);
        }

        public List<NoteDTO> GetNotesOfParticipantInMeeting(string participantId, Int64 meetingId)
        {
            return _participantService.GetNotesOfParticipantInMeeting(participantId, meetingId);
        }

        public void CreateParticipant(ParticipantDTO participant)
        {
            _participantService.CreateParticipant(participant);
        }

        public MeetingDTO GetMeeting(Int64 id)
        {
            return _meetingService.GetMeeting(id);
        }

        public NoteDTO GetNote(Int64 id)
        {
            return _noteService.GetNote(id);
        }

        public CalendarDTO GetCalendar(Int64 id)
        {

            return _calendarService.GetCalendar(id);
        }

    }
}

