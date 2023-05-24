using SayanJobeDone.Shared.Dtos;
using System.Web.Mvc;

namespace SayanJobeDone.Client.ViewModels;

public class AddressVM
{
    public List<AddressDto>? Addresses { get; set; } = new List<AddressDto>();
    public AddressDto? AddressDto { get; set; } = new AddressDto();
    public List<SelectListItem>? Cities { get; set; } = new List<SelectListItem>();
    public List<SelectListItem>? Countries { get; set; } = new List<SelectListItem>();

}
