using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MyBookTrackerWebApp.Models
{
	public class Novel : BaseBook
	{
		public int? NumberOfPages { get; set; }
		public string? ISBN { get; set; }
		public int PrintingNumber { get; set; }


	}
}
