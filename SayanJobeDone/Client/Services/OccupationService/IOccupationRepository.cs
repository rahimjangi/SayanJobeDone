﻿using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;

namespace SayanJobeDone.Shared.Services.OccupationService;

public interface IOccupationRepository : IRepository<OccupationDto, Occupation>
{
}
