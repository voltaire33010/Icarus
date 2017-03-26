using System;
using System.Collections.Generic;
namespace Icarus.Domain
{
	public class Department
	{
		public Department()
		{
			Contacts = new List<Contact>();
		}

		public int Id { get; set; }
		public string name { get; set; }
		public List<Contact> Contacts {get; set;}

	}
}
