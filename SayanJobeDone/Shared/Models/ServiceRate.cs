using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models;

public class ServiceRateDto
{
    public int ID { get; set; }
    public int ServiceID { get; set; }
    [ForeignKey("ServiceID")]
    public ServiceDto? Service { get; set; }
    public int RateTypeID { get; set; }
    [ForeignKey("RateTypeID")]
    public RateTypeDto? RateType { get; set; }
    public decimal RateAmount { get; set; }
}
