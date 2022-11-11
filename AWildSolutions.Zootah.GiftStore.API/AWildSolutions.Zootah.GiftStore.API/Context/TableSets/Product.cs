namespace AWildSolutions.Zootah.GiftStore.API.Context.TableSets;

public class Product
{
    public Guid Id { get; set; }
    public string Name { get; set; }
    public double Price { get; set; }
    public string Description { get; set; }
    public string SubText { get; set; }
    public Guid ProductTypeId { get; set; }
}