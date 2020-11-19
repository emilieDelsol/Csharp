using System;

namespace entityframeworkLinq
{
    public class Animal
    {
        public Guid AnimalID { get; set; }
        public string AnimalName { get; set; }
        public  Specie SpecieId { get; set; }
    }
}