using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class LocationData
    {
        public int ID { get; set; }
        public int MobilePhoneID { get; set; }
        [ForeignKey("MobilePhoneID")]
        public MobilePhone? MobilePhone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
