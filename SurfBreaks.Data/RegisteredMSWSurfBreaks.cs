using System;
using System.Collections.Generic;
using System.Text;

namespace SurfBreaks.Data
{
    //This is a temporary page for surf break data until an API key is received from magicseaweed.com

    public class RegisteredMSWSurfBreaks : IRegisteredMSWSurfBreaks 
    {
        private Dictionary<string, int> surfBreaks;

        public RegisteredMSWSurfBreaks ()
        {
            surfBreaks = new Dictionary<string, int>()
            {
                { "Ocean Beach", 255 },
                { "Laniakea", 3672 },
                { "Uluwatu", 565 },
                { "Maroochydore", 6128 },
                { "Cox Bay", 1122 }
            };
        }

        public Dictionary<string, int> GetAll()
        {
            return surfBreaks;
        }
    }
}
