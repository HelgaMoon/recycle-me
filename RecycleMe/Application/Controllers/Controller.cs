using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace Application.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class Controller : ControllerBase
	{
		private readonly ILogger<Controller> _logger;

		public Controller(ILogger<Controller> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		public int Get()
		{
			return 1;
		}
	}
}
