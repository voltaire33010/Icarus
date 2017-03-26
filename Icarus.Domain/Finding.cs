using System;
namespace Icarus.Domain
{
	public class Finding
	{
		public Finding()
		{
			
		}
		public int Id { get; set; }
		public string name { get; set; }
		public string risk{ get; set; }
		public string attack { get; set; }
		public string Description { get; set; }
		public string Impact { get; set; }
		public string Steps { get; set; }
		public string Recomendation { get; set; }
		public string Reference { get; set; }
		public string Asset { get; set; }
		public int ReviewId  { get; set; }



	}
}
