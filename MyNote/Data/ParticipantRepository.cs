using MyNote.Data.IRepositories;
using MyNote.DBContext;
using MyNote.Entites;

namespace MyNote.Data
{
	public class ParticipantRepository : IParticipantRepository
	{
        private readonly MyNoteContext _myNote;

        public ParticipantRepository(MyNoteContext myNote)
		{
			_myNote = myNote;
		}

		public List<Participant> GetParticipants()
		{
			return _myNote.GetParticipants().ToList();
		}
	}
}

