﻿using System.ComponentModel.DataAnnotations.Schema;

namespace MyNote.Entites
{
    [Table("Meeting")]
	public class Meeting
	{
        public Int64 Id { get; set; }
        public DateTime Date { get; set; }
        public string Name { get; set; }
        public bool T { get; set; }

        public Int64 GetId() { return Id; }
        public void SetId(Int64 id) { Id = id; }

        public DateTime GetDate() { return Date; }
        public void SetDate(DateTime date) { Date = date;  }
        public string GetName() { return Name; }
        public void SetName(string name) { Name = name;  }

    }

   
}

