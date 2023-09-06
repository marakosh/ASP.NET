using System.Collections;
using System.Reflection;
using Microsoft.EntityFrameworkCore;
using Turbo_az.Areas.Api.Data;
using Turbo_az.Areas.Api.Models;
using Turbo_az.Areas.Api.Models.Interfaces;

namespace Turbo_az.Areas.Api.Services;

public class SelectionService
{
    
    private readonly TurboDbContext _context;
    
    public SelectionService(TurboDbContext context) => _context = context;
    
    
    public List<Car> GetCars(DbSet<Car> cars, int id = -1)
    {
        var result = cars
            .Include(x => x.FuelType)
            .Include(x => x.TransmissionType)
            .Include(x => x.BodyType)
            .Include(x => x.City)
            .Include(x => x.ShowRoom)
            .Include(x => x.Color)
            .Include(x => x.WheelDriveType)
            .Select(x => new Car
            {
                Id = x.Id,
                Make = x.Make,
                Model = x.Model,
                ImgUrl = x.ImgUrl,
                ProductionDate = x.ProductionDate,
                Price = x.Price,
                FuelType = x.FuelType,
                TransmissionType = x.TransmissionType,
                BodyType = x.BodyType,
                City = x.City,
                ShowRoom = x.ShowRoom,
                Color = x.Color,
                WheelDriveType = x.WheelDriveType
            }).ToList();
        
        return id != -1 
            ? result.Where(x => x.Id == id).ToList() 
            : result;
    }
}