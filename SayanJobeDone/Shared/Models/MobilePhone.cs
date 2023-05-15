using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models
{
    public class MobilePhone
    {
        public int Id { get; set; }
        public string Identifier { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public int UserID { get; set; }
        [ForeignKey("UserID")]
        public User? User { get; set; }
        public List<LocationData>? LocationData { get; set; }
    }
}
