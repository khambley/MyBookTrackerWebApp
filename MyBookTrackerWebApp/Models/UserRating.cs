using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookTrackerWebApp.Models
{
	public class UserRating
	{
		public int Id { get; set; }
		public decimal? Stars { get; set; }
		public string Comments { get; set; }
		public int NovelId { get; set; }
		public Novel Novel { get; set; }
		public int ComicBookId { get; set; }
		public ComicBook ComicBook { get; set; }

	}
}
