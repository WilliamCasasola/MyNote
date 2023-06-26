using Microsoft.AspNetCore.Mvc;
using MyNote.Services;

namespace MyNote.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly ILogger<NoteController> _logger;
        private readonly NoteService _noteService;

        public NoteController(ILogger<NoteController> logger, NoteService noteService)
        {
            _logger = logger;
            _noteService = noteService;
        }

        [HttpGet(Name = "getNotes")]
        public IActionResult Get()
        {
            var x =  _noteService.GetNotesData();
            return Ok(x);
        }
    }
}
