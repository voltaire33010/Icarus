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

		public int Id { get; set; }
		public string name { get; set; }
		public Contact contact { get; set; }
		public List<Pentester> Pentesters { get; set; }
		public List<Finding> Findings { get; set; }
		public int ProjectId { get; set;}
	}
}
