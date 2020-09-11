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
    /*This page is still in progress.  Waiting for an API key from third party website magicseaweed.com
      to complete the forecast feature */
    
    public class ForecastModel : PageModel
    {
        private readonly ISurfBreakData surfBreakData;
        private IRegisteredMSWSurfBreaks registeredBreaks;

        public SurfBreak SurfBreak { get; set; }
        public int RegisteredId { get; set; }

        public ForecastModel(ISurfBreakData surfBreakData, IRegisteredMSWSurfBreaks registeredBreaks)
        {
            this.surfBreakData = surfBreakData;
            this.registeredBreaks = registeredBreaks;
        }

        public IActionResult OnGet(int surfBreakId)
        {
            SurfBreak = surfBreakData.GetSurfBreakById(surfBreakId);
            RegisteredId = GetRegisteredId(SurfBreak.Name);

            if (SurfBreak == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        private int GetRegisteredId(string name)
        {
            var breaks = registeredBreaks.GetAll();
            var id = breaks.Where(b => b.Key == name).FirstOrDefault().Value;
            return id;
        }
    }
}
