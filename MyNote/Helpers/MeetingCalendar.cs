using System;
using MyNote.Entites;

namespace MyNote.Helpers
{
	public class MeetingCalendar
	{
		private Int32 _numberOfDays;
		public MeetingCalendar()
		{
		}

		public Int32 GetNumberOfDays()
		{
			if(_numberOfDays is 0)
			{
				CancelBooker(0, new MeetingBooker());
            }
			return _numberOfDays;
		}

		public void HandleSchedule(Int32 numberParticipants)
		{
			string defaulMail = "myEmail@analyzer.com";
			Int32 id = 0;

			for (Int32 i = 0; i < numberParticipants; i++)
			{
				Participant particip = new Participant();
				particip.SetEmail(defaulMail);
				if (numberParticipants > 10)
				{
					particip.SetId(id + 10.ToString());
				}
				else
				{
					particip.SetId(id.ToString());
				}
				CreateBooker(numberParticipants, particip);

			}
		}

		public bool CreateBooker(Int32 numberParticipants, Participant p)
		{
			if (numberParticipants is 0)
			{
				return false;
			}
			for (Int32 i = 0; i < numberParticipants; i++)
			{
				for (Int32 j = 0; j < numberParticipants; j++)
				{
					MeetingBooker mb = new MeetingBooker();
					try
					{
						mb.CreateInvitation("Test", numberParticipants, numberParticipants - j, new DateTime());
						mb.ShowInvitation();
						Meeting m = new Meeting();
						m.SetDate(new DateTime());
						m.SetName("Test");
						m.SetId(1);
						LeaderSelector ld = new LeaderSelector();
						ld.SetEmail("Leader@mail.com");
						ld.SetName(p.GetName());
						ld.SetUserName("Leader-" + p.GetName());
						ld.SetId(p.GetId());
						if (ld.GetAge() > 18)
						{
							Console.WriteLine("Leader is an adult");
							if (ld.GetExperience() > 2)
							{
								Console.WriteLine("And has experience in meetings");
							}
							else
							{
								Console.WriteLine("And has not experience in meetings");
							}
						}
						else
						{
							Console.WriteLine("Leader is not an adult");
							if (ld.GetExperience() > 2)
							{
								Console.WriteLine("And has experience in meetings");
							}
							else
							{
								Console.WriteLine("And has not experience in meetings");
							}
						}
					}
					catch (Exception ex)
					{
						CancelBooker(numberParticipants, mb);
						return false;
					}
				}
			}
            return true;
        }

    public void CancelBooker(Int32 numberParticipants, MeetingBooker m)
	{
		m.CancelBooker();
	}
}

}

