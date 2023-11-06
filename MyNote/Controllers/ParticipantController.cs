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
            var response = _participantService.GetParticipant(id);
            return Ok(response);
		}
        
        [HttpGet(Name = "getMeetingsOfParticipantById")]
        public IActionResult GetMeetingsOfParticipant(string participantId)
        {
            var response = _participantService.GetMeetingsOfParticipant(participantId);
            return Ok(response);
        }
         
        [HttpGet(Name = "getNotesOfParticipantInMeeting")]
        public IActionResult GetNotesOfParticipantInMeeting(string participantId, Int16 meetingId)
        {
            var response = _participantService.GetNotesOfParticipantInMeeting(participantId, meetingId);
            return Ok(response);
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
            var response = _meetingService.GetMeeting(id);
            return Ok(response);
        }

        [HttpGet(Name = "getParticipantNotes")]
        public IActionResult GetParticipantNotes(Int64 id)
        {
            var response = _noteService.GetNote(id);
            return Ok(response);
        }

        [HttpGet(Name = "getCalendar")]
        public IActionResult GetCalendar(Int64 id)
        {
            var resopnse = _calendarService.GetCalendar(id);
            return Ok(resopnse);
        }

    }
}

