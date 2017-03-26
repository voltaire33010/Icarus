using System;
using System.Collections.Generic;
namespace Icarus.Domain
{
	public class Contact
	{
		public Contact()
		{
			Reviews = new List<Review>();
		}
		public int Id { get; set; }
		public String name { get; set; }
		public String email { get; set; }
		public List<Review> Reviews { get; set; }
		public int DepartmentId {get; set;}



	}
}
