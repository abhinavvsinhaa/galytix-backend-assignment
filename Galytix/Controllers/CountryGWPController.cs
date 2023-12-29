using System;
using Galytix.Models;
using Galytix.Services;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Galytix.Controllers
{
	[ApiController]
	[Route("api/gwp/avg")]
	public class CountryGWPController: ControllerBase
	{
		private readonly ICSVService _csvService;
		public CountryGWPController(ICSVService csvService)
		{
			_csvService = csvService;
		}

		public static double ConvertToDecimal(string s)
		{
			return string.IsNullOrEmpty(s) ? 0.0 : double.Parse(s);
		}

		[HttpPost]
		public Task<IActionResult> Post([FromBody]CountryGWPPostRequest body)
		{
            
			List<double> averages = new();

			for (int i = 0; i < body.lob.Count; i++)
			{
                var countries = _csvService.ReadCSV<CountryGWP>();

				foreach (var country in countries)
				{
					if (country.Country == body.country && country.LineOfBusiness == body.lob[i])
					{
						//Console.WriteLine("matched");
						double sum = ConvertToDecimal(country.Y2000) +
									ConvertToDecimal(country.Y2001) +
									ConvertToDecimal(country.Y2002) +
									ConvertToDecimal(country.Y2003) +
									ConvertToDecimal(country.Y2004) +
									ConvertToDecimal(country.Y2005) +
									ConvertToDecimal(country.Y2006) +
									ConvertToDecimal(country.Y2007) +
									ConvertToDecimal(country.Y2008) +
									ConvertToDecimal(country.Y2009) +
									ConvertToDecimal(country.Y2010) +
									ConvertToDecimal(country.Y2011) +
									ConvertToDecimal(country.Y2012) +
									ConvertToDecimal(country.Y2013) +
									ConvertToDecimal(country.Y2014) +
									ConvertToDecimal(country.Y2015);
						
						double avg = sum / 15;

						//Console.WriteLine(avg);
						averages.Add(avg);
						break;
					}
				}
			}

			return Task.FromResult<IActionResult>(Ok(averages));
        }
	}
}

