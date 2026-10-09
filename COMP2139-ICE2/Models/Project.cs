
namespace COMP2139_ICE2.Models;

using System.ComponentModel.DataAnnotations;

public class Project
{
    public int ProjectId { get; set; }

    [Required]
    public required string Name { get; set; }

    public string? Description { get; set; }

    [DataType(DataType.Date)]
    public DateTime StartDate { get; set; }

    [DataType(DataType.Date)]
    public DateTime EndDate { get; set; }

    public string? Status { get; set; }

    public ICollection<ProjectTask> ProjectTasks { get; set; } = new List<ProjectTask>();
}