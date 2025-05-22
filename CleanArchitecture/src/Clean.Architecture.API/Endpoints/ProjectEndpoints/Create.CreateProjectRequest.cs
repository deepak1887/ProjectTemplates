using System.ComponentModel.DataAnnotations;

namespace Clean.Architecture.API.Endpoints.ProjectEndpoints;

public class CreateProjectRequest
{
  public const string Route = "/Projects";

  [Required]
  public string? Name { get; set; }
}
