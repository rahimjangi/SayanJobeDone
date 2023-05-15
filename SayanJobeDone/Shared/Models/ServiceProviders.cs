namespace SayanJobeDone.Shared.Models
{
    public class ServiceProvidersDto
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public List<ServiceDto>? Services { get; set; }
    }
}
