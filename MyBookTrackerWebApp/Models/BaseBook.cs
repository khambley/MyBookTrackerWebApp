using Microsoft.AspNetCore.Http;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookTrackerWebApp.Models
{
	public class BaseBook
	{
		public int Id { get; set; }
		public string Title { get; set; }
		public string? Publisher { get; set; }
		public DateTime? PublishDate { get; set; }
		public string? UPCCode { get; set; }
		public string? Summary { get; set; }
		public string? SeriesName { get; set; }
		public int? SeriesNumber { get; set; }
		public List<Creator> Creators { get; set; }
		public DateTime? DateAdded { get; set; }
		public DateTime? CopyrightYear { get; set; }
		public string? CopyrightHolder { get; set; }
		public string? CoverArtist { get; set; }

		List<UserRating> UserRatings { get; set; }

		[NotMapped]
		public IFormFile ImageFile { get; set; }
		public List<ImageFileName> ImageFileNames { get; set; }
		public string? Format { get; set; } //Paperback, Hardcover, Kindle, eBook, Audiobook, Graphic Novel, etc.
		


	}
}
