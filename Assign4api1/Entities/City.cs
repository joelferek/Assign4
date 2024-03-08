using System.ComponentModel.DataAnnotations;

namespace Assign4api1.Entities
{
    public class City
    {
        [Key]
        public int EventID { get; set; }

        [MaxLength(50)]
        public string EventName { get; set; }

        [MaxLength(50)]
        public string EventPrice { get; set; }

        public int CityID { get; set; }
        [MaxLength(50)]
        public string CityName { get; set; }

        [MaxLength(50)]
        public string AvgTemp { get; set; }
    }
}

