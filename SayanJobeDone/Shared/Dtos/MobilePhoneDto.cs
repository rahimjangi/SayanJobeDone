namespace SayanJobeDone.Shared.Dtos
{
    public class MobilePhoneDto
    {
        public int Id { get; set; }
        public string Identifier { get; set; } = string.Empty;
        public string DeviceModel { get; set; } = string.Empty;
        public string OperatingSystem { get; set; } = string.Empty;
        public int UserID { get; set; }

        public List<LocationDataDto>? LocationData { get; set; }
    }
}
