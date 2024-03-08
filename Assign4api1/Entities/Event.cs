using System.ComponentModel.DataAnnotations;

namespace Assign4api1.Entities
{
    public class Event
    {
        [Key]
        public int EventID { get; set; }

        [MaxLength(50)]
        public string EventName { get; set; }

        [MaxLength(50)]
        public string EventPrice { get; set; }
    }
}
