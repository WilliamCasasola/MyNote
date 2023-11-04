using MyNote.DTOs;

namespace MyNote.Data.IRepositories
{
	public interface ICalendarRepository
	{
        CalendarDTO GetCalendar(Int64 id);
    }
}

