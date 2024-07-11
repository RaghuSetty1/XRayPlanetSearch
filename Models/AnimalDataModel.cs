using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApp.Models
{
    public class AnimalDataModel
    {
        public string Name { get; set; }
        public string ImagePath { get; set; }
        public AnimalDetails BiologicalAspect { get; set; }
        public AnimalDetails ArchitecturalAspect { get; set; }
        public AnimalDetails PhicicalAspect { get; set; }
        public AnimalDetails OtherImportantAspect { get; set; }
    }

    public class AnimalDetails
    {
        public string Detail { get; set; }
        public List<string> Links { get; set; }

        public AnimalDetails()
        {
            Links = new List<string>();
        }
    }
}