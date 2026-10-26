using Billing;

public class InvoiceTests
{
    [Fact]
    public void Totals_price_times_quantity() =>
        Assert.Equal(53.00m, Invoice.Total([new(24.50m, 2), new(4.00m, 1)]));

    [Fact]
    public void An_empty_invoice_totals_zero() => Assert.Equal(0m, Invoice.Total([]));
}
