namespace SayanJobeDone.Shared.Dtos
{
    public class ServiceReceiverDto
    {
        public string Name { get; set; } = string.Empty;
        public List<ServiceDto>? ServicesReceived { get; set; }
    }
}
