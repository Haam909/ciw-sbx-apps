namespace Catalog;

public record Item(string Sku, string Name, decimal Price);

public static class Items
{
    private static readonly Dictionary<string, Item> BySku = new(StringComparer.OrdinalIgnoreCase)
    {
        ["A-100"] = new("A-100", "Kettle", 24.50m),
        ["B-200"] = new("B-200", "Teapot", 18.00m),
    };

    public static Item? Find(string sku) => BySku.GetValueOrDefault(sku);
}
