using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Dtos
{
    public class LocationDataDto
    {
        public int Id { get; set; }
        public int MobilePhoneID { get; set; }
        [ForeignKey("MobilePhoneID")]
        public MobilePhoneDto? MobilePhone { get; set; }
        public double Latitude { get; set; }
        public double Longitude { get; set; }
        public DateTime Timestamp { get; set; }
    }
}
