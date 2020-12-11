using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace WebApplication1.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class WeatherForecastController : ControllerBase
	{
		private static readonly string[] Summaries = new[]
		{
			"Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
		};

		private readonly ILogger<WeatherForecastController> _logger;

		public WeatherForecastController(ILogger<WeatherForecastController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public ActionResult Get()
		{
			// AD0001 Warning with either of those lines:
			return this.ValidationProblem("Problem");
			//return this.ValidationProblem("Problem", null, null, null, null,null);

			// No AD001 Warning with this usage only:
			// return this.ValidationProblem("Problem", null, null, null, null, new ModelStateDictionary());
			
		}
	}
}
