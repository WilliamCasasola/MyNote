using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.DTOs;

namespace MyNote.Data
{
	public class CalendarRepository : ICalendarRepository
	{
        private readonly MyNoteContext _myNote;
		public CalendarRepository(MyNoteContext myNote)
		{
            _myNote = myNote;
		}

        public CalendarDTO GetCalendar(Int64 id)
        {
            CalendarDTO calendar = new CalendarDTO();
            calendar.SetId(id);
            return calendar;
        }
    }
}

