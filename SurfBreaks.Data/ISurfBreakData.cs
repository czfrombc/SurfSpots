using System.Collections.Generic;
using System.Text;
using SurfBreaks.Core;

namespace SurfBreaks.Data
{
    public interface ISurfBreakData
	{
		IEnumerable<SurfBreak> GetSurfBreakByName(string name);
		SurfBreak GetSurfBreakById(int id);
		SurfBreak Update(SurfBreak updatedSurfBreak);
		SurfBreak Add(SurfBreak newSurfBreak);
		SurfBreak Delete(int id);
		int GetCountOfSurfBreaks();
		int Commit();
	}
}
 