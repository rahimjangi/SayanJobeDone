namespace SayanJobeDone.Shared.Dtos
{
    public class UserDto
    {
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<MobilePhoneDto>? MobilePhones { get; set; }
    }
}
