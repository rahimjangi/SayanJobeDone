namespace SayanJobeDone.Shared.Models
{
    public class ServiceReceiver
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Service>? ServicesReceived { get; set; }
    }
}
