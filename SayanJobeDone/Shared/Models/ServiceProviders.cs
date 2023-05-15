namespace SayanJobeDone.Shared.Models
{
    public class ServiceProviders
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Service>? Services { get; set; }
    }
}
