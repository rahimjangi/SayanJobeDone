namespace SayanJobeDone.Shared.Dtos;

public class ServiceRateDto
{
    public int Id { get; set; }
    public int ServiceID { get; set; }
    public int RateTypeID { get; set; }
    public decimal RateAmount { get; set; }
}
