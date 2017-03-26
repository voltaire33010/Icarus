using System;
using System.Collections.Generic;
namespace Icarus.Domain
{
	public class Review
	{
		public Review()
		{
			Findings = new List<Finding>();
		}

		int Id { get; set; }
		List<Finding> Findings { get; set; }
	}
}
