using System.ComponentModel.DataAnnotations;

namespace BlazorFundamentals.Models;

public class Product
{
    public int Id { get; set; }
    [Required]
    public string Name { get; set; } = string.Empty;
    [Range(1, 100)]
    public double Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; } = new List<Product_Prop>();

    public Category Category { get; set; }
    public DateOnly AvailableFrom { get; set; }
}


public enum Category
{
    Entree, Appetizer, Dessert
}
