namespace Billing;

public record Line(decimal UnitPrice, int Quantity);

public static class Invoice
{
    public static decimal Total(IEnumerable<Line> lines) =>
        lines.Sum(l => l.UnitPrice * l.Quantity);
}
