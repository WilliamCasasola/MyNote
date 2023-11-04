using MyNote.Data.IRepositories;
using MyNote.DTOs;

namespace MyNote.Services
{
	public class CalendarService
    {
        private ICalendarRepository _calendarRepo;
        public CalendarService(ICalendarRepository calendarRepo)
        {
            _calendarRepo = calendarRepo;
        }

        public CalendarDTO GetCalendar(Int64 id)
        {
            if (UseCalendarFromDB())
            {
                return _calendarRepo.GetCalendar(id);
            }
            else
            {
                return GenerateCalendar();
            }
        }

        private CalendarDTO GenerateCalendar()
        {
            return new CalendarDTO();
        }

        private bool UseCalendarFromDB()
        {
            //toDo implementation
            return true;
        }
    } 
}

