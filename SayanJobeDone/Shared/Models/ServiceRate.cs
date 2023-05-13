namespace SayanJobeDone.Shared.Models;

public class ServiceRate
{
    public int ID { get; set; }
    public int ServiceID { get; set; }
    public Service? Service { get; set; }
    public RateType? RateType { get; set; }
    public decimal RateAmount { get; set; }
}
