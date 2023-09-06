using Turbo_az.Areas.Api.Models.Interfaces;

namespace Turbo_az.Areas.Api.Models;

public class FuelType: IEntity
{
    public int Id { get; set; }

    public string Name { get; set; }
}