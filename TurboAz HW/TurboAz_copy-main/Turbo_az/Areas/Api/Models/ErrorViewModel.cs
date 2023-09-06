using Turbo_az.Areas.Api.Models.Interfaces;

namespace Turbo_az.Areas.Api.Models;

public class ErrorViewModel: IEntity
{
    public string Message { get; set; }
    public string StackTrace { get; set; }
}