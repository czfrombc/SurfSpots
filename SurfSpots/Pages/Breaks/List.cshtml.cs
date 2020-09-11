using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Configuration;
using SurfBreaks.Core;
using SurfBreaks.Data;

namespace SurfBreaks.Pages.Breaks
{
    public class ListModel : PageModel
    {
		private readonly IConfiguration config;
		private readonly ISurfBreakData surfBreakData;

		public string Message { get; set; }
		public IEnumerable<SurfBreak> SurfBreaks { get; set; }

		[BindProperty(SupportsGet = true)]
		public string SearchTerm { get; set; }

		public ListModel(IConfiguration config, ISurfBreakData surfBreakData)
		{
			this.config = config;
			this.surfBreakData = surfBreakData;
		}

        public void OnGet()
        {
            Message = config["Message"];
			SurfBreaks = (IEnumerable<SurfBreak>)surfBreakData.GetSurfBreakByName(SearchTerm);
        }
    }
}
