using System;
namespace Galytix.Models
{
	public class CountryGWPPostRequest
	{
		public required string country { get; set; }
		public required List<string> lob { get; set; }
	}
}

