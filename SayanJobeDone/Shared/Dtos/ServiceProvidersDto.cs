namespace SayanJobeDone.Shared.Dtos
{
    public class ServiceProvidersDto
    {
        public string Name { get; set; } = string.Empty;
        public List<ServiceDto>? Services { get; set; }
    }
}
