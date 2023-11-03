using System;
namespace MyNote.Helpers
{
	public class ParticipantInvitation
	{		
		private Int32 _numberOfParticipants;
		private Int32 _numberOfTables;
		private DateTime _date;
		private string _title;

		public DateTime GetDate()
		{
			return _date;
		}

		public void SetDate(DateTime date)
		{
			this._date = date;
		}

        public Int32 GetNumberOfParticipants()
        {
            return _numberOfParticipants;
        }

        public void SetNumberOfParticipants(Int32 numberOfParticipants)
        {
            this._numberOfParticipants = numberOfParticipants;
        }

        public Int32 GetNumberOfTables()
        {
            return _numberOfTables;
        }

        public void SetNumberOfTables(Int32 numberOfTables)
        {
            this._numberOfTables = numberOfTables;
        }

        public string GetTitle()
        {
            return _title;
        }

        public void SetTitle(string title)
        {
            this._title = title;
        }

        public string GenerateConfirmation()
        {
            return "The date " + _date + " there would be the meeting " + _title +
                " for " + _numberOfParticipants + "participants and ther will be "
                + _numberOfTables + " places reserved for you";
        }
    }
}

