using Catalog;

public class ItemsTests
{
    [Fact]
    public void Finds_an_item_by_sku_in_any_case() =>
        Assert.Equal("Kettle", Items.Find("a-100")?.Name);

    [Fact]
    public void An_unknown_sku_is_not_found() => Assert.Null(Items.Find("Z-999"));
}
