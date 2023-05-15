using Microsoft.EntityFrameworkCore;
using SayanJobeDone.Shared.Data.Repository.IRepository;
using SayanJobeDone.Shared.Models;
using System.Linq.Expressions;

namespace SayanJobeDone.Shared.Data.Repository;

public class AddressRepository : IAddressRepository
{
    private readonly ApplicationDbContext _db;

    public AddressRepository(ApplicationDbContext db)
    {
        _db = db;
    }

    public async Task Add(AddressDto entity)
    {
        try
        {
            var cityFromDb = await _db.Cities.FirstOrDefaultAsync(x => x.Id == entity.CityId);
            if (cityFromDb != null)
            {
                entity.CityId = cityFromDb.Id;
                await _db.Addresses.AddAsync(entity);
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

    public async Task<List<AddressDto>> GetAll(Expression<Func<AddressDto, bool>>? filter = null, Func<IQueryable<AddressDto>, IOrderedQueryable<AddressDto>>? orderby = null, string? includeProperties = null)
    {
        try
        {
            var result = await _db.Addresses.ToListAsync();
            return result;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }

    public async Task<AddressDto> GetFirstOrDefault(Expression<Func<AddressDto, bool>>? filter = null, string? includeProperties = null)
    {
        try
        {
            var result = new AddressDto();
            if (filter != null)
            {
                result = await _db.Addresses.FirstOrDefaultAsync(filter);
            }
            return result!;
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
            _db.Addresses.Remove(entity);
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

    public async Task<AddressDto> Update(AddressDto entity)
    {
        try
        {
            var updatedObj = _db.Addresses.Update(entity);
            await _db.SaveChangesAsync();
            return updatedObj.Entity;
        }
        catch (Exception e)
        {

            throw new Exception(e.Message);
        }
    }
}
