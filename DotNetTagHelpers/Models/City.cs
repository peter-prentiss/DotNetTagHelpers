using System.ComponentModel.DataAnnotations;

namespace DotNetTagHelpers.Models
{
    public class City
    {
        public string Name { get; set; }
        public string Country { get; set; }

        [DisplayFormat(DataFormatString = "{0:F2}", ApplyFormatInEditMode = true)]
        public int? Population { get; set; }
    }
}