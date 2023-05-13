namespace SayanJobeDone.Shared.Models
{
    public class ServiceProvider
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<Service>? Services { get; set; }
    }
}
