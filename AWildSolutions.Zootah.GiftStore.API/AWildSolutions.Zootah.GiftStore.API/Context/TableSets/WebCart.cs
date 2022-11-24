namespace AWildSolutions.Zootah.GiftStore.API.Context.TableSets;

public class WebCart
{
    public Guid Id { get; set; }
    public List<Product> Items { get; set; }
}