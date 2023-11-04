using Microsoft.AspNetCore.Mvc;
using MyNote.Services;

namespace MyNote.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MeetingController : ControllerBase
    {
        private readonly ILogger<MeetingController> _logger;
        private readonly MeetingService _meetingService;

        public MeetingController(ILogger<MeetingController> logger, MeetingService meetingService)
        {
            _logger = logger;
            _meetingService = meetingService;
        }

        [HttpGet(Name = "getMeeting")]
        public IActionResult GetCanceledMeetings(int meetingId)
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getMeetings")]
        public IActionResult Get()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getTodayMeetings")]
        public IActionResult GetTodayMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getPastMeetings")]
        public IActionResult GetPastMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getFutureMeetings")]
        public IActionResult GetFutureMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getCanceledMeetings")]
        public IActionResult GetCanceledMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getPendingMeetings")]
        public IActionResult GetPendingdMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getParticipantsInMeetings")]
        public IActionResult GetParticipantInMeetings()
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getMeetingsofParticipant")]
        public IActionResult GetMeetings(Int16 participantId)
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getMeetingsPerDate")]
        public IActionResult GetMeetingsPerDate(DateTime date)
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }

        [HttpGet(Name = "getMeetingsPerName")]
        public IActionResult GetMeetingsPerName(string name)
        {
            var x = _meetingService.GetMeetings();
            return Ok(x);
        }
    }
}

