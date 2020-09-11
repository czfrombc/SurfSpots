using System;
using System.Collections.Generic;
using System.Text;

namespace SurfBreaks.Data
{
    public interface IRegisteredMSWSurfBreaks
    {
        Dictionary<string, int> GetAll();
    }
}
