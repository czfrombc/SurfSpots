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
    public class DeleteModel : PageModel
    {
        private readonly ISurfBreakData surfBreakData;

        public SurfBreak SurfBreak { get; set; }

        public DeleteModel(ISurfBreakData surfBreakData)
        {
            this.surfBreakData = surfBreakData;
        }

        public IActionResult OnGet(int surfBreakId)
        {
            SurfBreak = surfBreakData.GetSurfBreakById(surfBreakId);
            if (SurfBreak == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost (int surfBreakId)
        {
            var surfBreak = surfBreakData.Delete(surfBreakId);
            surfBreakData.Commit();

            if (surfBreak == null)
            {
                return RedirectToPage("./NotFound");
            }
            //TempData["Message"] = $"{surfBreak.Name} deleted";
            return RedirectToPage("./List");
        }
    }
}
