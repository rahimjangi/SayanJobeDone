﻿using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.RateTypeService;

public interface IRateTypeRepository : IRepository<RateTypeDto, RateType>
{
}