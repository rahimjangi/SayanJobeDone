using AutoMapper;
using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data;
using SayanJobeDone.Shared.Dtos;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Services.AddressService;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _db;
    private readonly Mapper _mapper;

    public AddressRepository(ApplicationDbContext db, Mapper mapper)
    {
        _db = db;
        _mapper = mapper;
    }

    public async Task Add(AddressDto entity)
    {
        try
        {
            var address = _mapper.Map<Address>(entity);
            var country = await _db.Countries.FirstOrDefaultAsync(x => x.Id == entity.CountryId);
            address.Country = country;
            var cityFromDb = await _db.Cities.FirstOrDefaultAsync(x => x.Id == entity.CityId);
            if (cityFromDb != null)
            {
                entity.CityId = cityFromDb.Id;
                await _db.Addresses.AddAsync(address);
                await _db.SaveChangesAsync();
            }
            else
            {
                throw new Exception("City does not exists!");
            }
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<List<AddressDto>>> GetAll(Expression<Func<Address, bool>>? filter = null, Func<IQueryable<Address>, IOrderedQueryable<Address>>? orderby = null, string? includeProperties = null)
    {
        ServiceResponse<List<AddressDto>> sr = new ServiceResponse<List<AddressDto>>();
        try
        {
            var result = await _db.Addresses.ToListAsync();
            var addressDtos = _mapper.Map<List<AddressDto>>(result);
            sr.Data = addressDtos;
            sr.Message = "Success";
            sr.Status = true;
            return sr;

        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<AddressDto>> GetFirstOrDefault(Expression<Func<Address, bool>>? filter = null, string? includeProperties = null)
    {
        ServiceResponse<AddressDto> sr = new ServiceResponse<AddressDto>();
        try
        {
            var result = new AddressDto();
            if (filter != null)
            {
                result = _mapper.Map<AddressDto>(await _db.Addresses.FirstOrDefaultAsync(filter));
            }
            sr.Data = result;
            sr.Status = true;
            sr.Message = "Success";
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }

    }

    public async Task Remove(AddressDto entity)
    {
        try
        {
            _db.Addresses.Remove(_mapper.Map<Address>(entity));
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {
            throw new Exception(e.Message);

        }
    }

    public async Task RemoveRange(IEnumerable<AddressDto> entities)
    {
        try
        {
            _db.RemoveRange(entities);
            await _db.SaveChangesAsync();
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<ServiceResponse<AddressDto>> Update(AddressDto entity)
    {
        ServiceResponse<AddressDto> sr = new ServiceResponse<AddressDto>();
        try
        {
            var updatedObj = _db.Addresses.Update(_mapper.Map<Address>(entity));
            await _db.SaveChangesAsync();
            var result = _mapper.Map<AddressDto>(updatedObj.Entity);
            sr.Status = true;
            sr.Data = result;
            sr.Message = "Success";
            return sr;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
