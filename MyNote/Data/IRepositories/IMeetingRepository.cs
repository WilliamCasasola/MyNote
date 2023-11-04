using MyNote.DTOs;
using MyNote.Entites;

namespace MyNote.Data.IRepositories
{
	public interface IMeetingRepository
	{
		void Add(Meeting meeting);
		MeetingDTO GetMeeting(Int64 id);
    }
}

