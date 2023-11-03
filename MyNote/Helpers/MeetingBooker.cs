using System;
namespace MyNote.Helpers
{
	public class MeetingBooker
	{
		private ParticipantInvitation invitation;

		public MeetingBooker()
		{
			invitation = new ParticipantInvitation();
		}

		public void CreateInvitation(string title, int participantNumbers,
			int numberTables,
			DateTime date)
		{
			invitation.SetDate(date);
			invitation.SetNumberOfParticipants(participantNumbers);
			invitation.SetNumberOfTables(numberTables);
			invitation.SetTitle(title);
		}

		public void ShowInvitation()
		{
			invitation.GenerateConfirmation();
		}

		private void AvoidMultipleMeetingOneDay()
		{

		}

		private int FindNumberOverlappingeMetings()
		{
			return 1;
		}
	}
}

