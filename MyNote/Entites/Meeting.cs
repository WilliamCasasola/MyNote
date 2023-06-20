using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("Meeting")]
	public class Meeting
	{
        [Key]
        [Column("id")]
        public int Id;
        [Column("date")]
        public DateTime Date;
        [Column("name")]
        public string Name;
        public bool T;

        public Meeting()
		{
		}

        public int GetId() { return Id; }
        public void SetId(int id) { Id = id; }

        public DateTime GetDate() { return Date; }
        public void SetDate(DateTime date) { Date = date;  }
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name;  }

    }

   
}

