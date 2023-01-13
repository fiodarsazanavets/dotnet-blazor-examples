using System.ComponentModel.DataAnnotations;

namespace InbuiltComponentsDemo.Models;

public class Car
{
    [Required]
    [StringLength(16, ErrorMessage = "Character limit exceeded.")]
    public string? Make { get; set; }

    [Required]
    public string? Model { get; set; }

    [Required]
    public string? Classification { get; set; }

    [Range(1, 7, ErrorMessage = "A car can have between 1 and 7 passengers.")]
    public int MaximumPassengers { get; set; }

    [Required]
    [Range(typeof(bool), "true", "true",
        ErrorMessage = "Unapproved designes dissallowed.")]
    public bool IsValidatedDesign { get; set; }

    [Required]
    public DateTime ProductionDate { get; set; }
}
