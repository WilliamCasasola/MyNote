using Microsoft.AspNetCore.Mvc;
using MyNote.Entites;
using MyNote.Services;

namespace MyNote.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly ILogger<NoteController> _logger;
        private readonly NoteService _noteService;

        public NoteController(ILogger<NoteController> logger)
        {
            _logger = logger;
            _noteService = new NoteService();
        }

        [HttpGet(Name = "getNotes")]
        public ActionResult Get()
        {
            return Ok(_noteService.GetNotesData());
        }
    }
}
