using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookTrackerWebApp.Models
{
	public class Creator
	{
		public int Id { get; set; }
		public string Name { get; set; }
		public DateTime? Birthdate { get; set; }
		public CreatorType CreatorType { get; set; }

	}
}
