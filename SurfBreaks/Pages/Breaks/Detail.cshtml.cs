using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using SurfBreaks.Core;
using SurfBreaks.Data;

namespace SurfBreaks.Pages.Breaks
{
    public class DetailModel : PageModel
    {
        public SurfBreak SurfBreak { get; set; }
        private readonly ISurfBreakData surfBreakData;

        [TempData]
        public string Message { get; set; }

        public DetailModel(ISurfBreakData surfBreakData)
        {
            this.surfBreakData = surfBreakData;
        }

        public IActionResult OnGet(int surfBreakId)
        {
            SurfBreak = surfBreakData.GetSurfBreakById(surfBreakId);
            if(SurfBreak == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }
    }
}
