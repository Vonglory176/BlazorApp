namespace BlazorApp.Models;

// using System.ComponentModel.DataAnnotations; // For Data Annotations (Like Required, Range, EmailAddress, etc.)

public class Product
{
    // [Required]
    public required int Id { get; set; }
    public required string Name { get; set; }
    public double Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; }
}