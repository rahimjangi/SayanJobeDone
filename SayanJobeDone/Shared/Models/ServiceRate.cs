using System.ComponentModel.DataAnnotations.Schema;

namespace SayanJobeDone.Shared.Models;

public class ServiceRate
{
    public int ID { get; set; }
    public int ServiceID { get; set; }
    [ForeignKey("ServiceID")]
    public Service? Service { get; set; }
    public int RateTypeID { get; set; }
    [ForeignKey("RateTypeID")]
    public RateType? RateType { get; set; }
    public decimal RateAmount { get; set; }
}
