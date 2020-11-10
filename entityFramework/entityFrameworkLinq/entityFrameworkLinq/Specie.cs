using System;
using System.Collections.Generic;

namespace entityframeworkLinq
{
    public class Specie
    {
        public Guid SpecieID { get; set; }
        public string SpecieName { get; set; }
        public ICollection<Animal> Animals { get; set; }
    }
}