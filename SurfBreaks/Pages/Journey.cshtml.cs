using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace SurfSpots.Pages
{
	public class JourneyModel : PageModel
	{
		private readonly ILogger<JourneyModel> _logger;

		public JourneyModel(ILogger<JourneyModel> logger)
		{
			_logger = logger;
		}

		public void OnGet()
		{
		}
	}
}
