using Microsoft.AspNetCore.Mvc;
using MyNote.Inputs;
using MyNote.Services;

namespace MyNote.Controllers
{
    [ApiController]
    [Route("api/[controller]/[action]")]
    public class ParticipantController : ControllerBase
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

        [HttpGet(Name = "getParticipant")]
        public IActionResult GetParticipant(string id)
		{
			return Ok(_participantService.GetParticipant(id));
		}

        [HttpGet(Name = "getMeetingsOfParticipantById")]
        public IActionResult GetMeetingsOfParticipant(string participantId)
        {
            return Ok(_participantService.GetMeetingsOfParticipant(participantId));
        }

        [HttpGet(Name = "getNotesOfParticipantInMeeting")]
        public IActionResult GetNotesOfParticipantInMeeting(string participantId, Int64 meetingId)
        {
            return Ok(_participantService.GetNotesOfParticipantInMeeting(participantId, meetingId));
        }

        [HttpPost(Name = "createParticipant")]
        public IActionResult CreateParticipant(ParticipantDTO participant)
        {
            _participantService.CreateParticipant(participant);
            return Ok();
        }

        [HttpGet(Name = "getMeetingById")]
        public IActionResult GetMeeting(Int64 id)
        {
            return Ok(_meetingService.GetMeeting(id));
        }

        [HttpGet(Name = "getParticipantNotes")]
        public IActionResult GetParticipantNotes(Int64 id)
        {
            return Ok(_noteService.GetNote(id));
        }

        [HttpGet(Name = "getCalendar")]
        public IActionResult GetCalendar(Int64 id)
        {
            return Ok(_calendarService.GetCalendar(id));
        }

    }
}

