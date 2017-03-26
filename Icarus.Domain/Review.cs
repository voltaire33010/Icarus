using System;
using System.Collections.Generic;
namespace Icarus.Domain
{
	public class Review
	{
		public Review()
		{
			Findings = new List<Finding>();
			Pentesters = new List<Pentester>();
		}

		int Id { get; set; }
		string name { get; set; }
		Contact contact { get; set; }
		List<Pentester> Pentesters { get; set; }
		List<Finding> Findings { get; set; }
	}
}
