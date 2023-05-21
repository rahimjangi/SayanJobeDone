﻿using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.ServiceProvidersService;

public interface IServiceProviderRepository : IRepository<ServiceProvidersDto, ServiceProviders>
{
}
