using System;
using System.Collections.Generic;
namespace Icarus.Domain
{
	public class Project
	{
		public Project()
		{
			Reviews = new List<Review>();
		}

		int Id { get; set; }
		string name { get; set; }
		Contact contact { get; set; }
		List<Review> Reviews { get; set; }

	}
}
