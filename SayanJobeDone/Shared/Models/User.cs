namespace SayanJobeDone.Shared.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;
        public List<MobilePhone>? MobilePhones { get; set; }
    }
}
