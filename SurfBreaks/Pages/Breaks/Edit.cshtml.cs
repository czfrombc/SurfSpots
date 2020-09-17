using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.AspNetCore.Mvc.Rendering;
using SurfBreaks.Core;
using SurfBreaks.Data;
using static SurfBreaks.Core.SurfBreak;

namespace SurfBreaks.Pages.Breaks
{
    public class EditModel : PageModel
    {
        private readonly IHtmlHelper htmlHelper;

        private ISurfBreakData surfBreakData { get; }

        [BindProperty]
        public SurfBreak SurfBreak { get; set; }
        public IEnumerable<SelectListItem> SurfBreakTypes { get; set; }

        public EditModel(ISurfBreakData surfBreaks, IHtmlHelper htmlHelper)
        {
            this.surfBreakData = surfBreaks;
            this.htmlHelper = htmlHelper;
        }

        public IActionResult OnGet(int? surfBreakId)
        {
            SurfBreakTypes = htmlHelper.GetEnumSelectList<BreakType>();
            if(surfBreakId.HasValue)
            {
                SurfBreak = surfBreakData.GetSurfBreakById(surfBreakId.Value);
            }   
            else
            {
                SurfBreak = new SurfBreak();
            }
            if (SurfBreak == null)
            {
                return RedirectToPage("./NotFound");
            }
            return Page();
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                SurfBreakTypes = htmlHelper.GetEnumSelectList<BreakType>();
                return Page();
            }

            if (SurfBreak.Id > 0 )
            {
                surfBreakData.Update(SurfBreak);
            }
            else
            {
                surfBreakData.Add(SurfBreak);
            }

            TempData["Message"] = "Surf Break saved!";
            surfBreakData.Commit();
            return RedirectToPage("./Detail", new { surfBreakId = SurfBreak.Id });
        }
    }
}
