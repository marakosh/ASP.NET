using System.ComponentModel.DataAnnotations;
using Turbo_az.Areas.Api.Models.Interfaces;

namespace Turbo_az.Areas.Api.Models;

public class City: IEntity
{
    public int Id { get; set; }

    [RegularExpression(@"^[a-zA-Z\s]+$")] public string Name { get; set; }
}