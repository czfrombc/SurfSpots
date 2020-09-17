using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SurfBreaks.Data;

namespace SurfBreaks.ViewComponents
{
    public class SurfBreakCountViewComponent : ViewComponent
    {
        private readonly ISurfBreakData surfBreakData;

        public SurfBreakCountViewComponent(ISurfBreakData surfBreakData)
        {
            this.surfBreakData = surfBreakData;
        }

        public IViewComponentResult Invoke()
        {
            var surfBreakCount = surfBreakData.GetCountOfSurfBreaks();
            return View(surfBreakCount);
        }
    }
}
