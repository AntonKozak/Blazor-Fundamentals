namespace BlazorFundamentals.Models;

public class Product
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    public double Price { get; set; }
    public bool IsActive { get; set; }
    public IEnumerable<Product_Prop> ProductProperties { get; set; } = new List<Product_Prop>();
}
