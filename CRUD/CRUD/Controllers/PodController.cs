using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CRUD.Controllers
{
	[ApiController]
	[Route("[controller]")]
	public class PodController : ControllerBase
	{
		private static readonly List<string> PodTypes = new List<string>
		{
			"Fizzy", "Redeo", "Boace"
		};

		private readonly ILogger<PodController> _logger;

		public PodController(ILogger<PodController> logger)
		{
			_logger = logger;
		}

		[HttpGet]
		[Route("")]
		public List<string> GetListPod()
		{
			return PodTypes;
		}

		[HttpGet]
		[Route("details/{id}")]
		public string GetPodDetail(int id)
		{
			return PodTypes[id];
		}
	}
}
