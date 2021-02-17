using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookTrackerWebApp.Models
{
	public class ComicBook : BaseBook
	{
		public int? IssueNumber { get; set; }
		public string? CoverVariant { get; set; }

	}
}
