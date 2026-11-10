namespace DotNet11;

public class LINQFullJoin
{
    public static void Example()
    {
        var products = new[]
        {
            new Product("A100", "Keyboard"),
            new Product("B200", "Mouse"),
            new Product("C300", "Monitor")
        };

        var sales = new[]
        {
            new Sale("B200", 5),
            new Sale("C300", 2),
            new Sale("D400", 3)
        };

        var result = products.FullJoin(
            sales,
            product => product.Id,
            sale => sale.Id,
            (product, sale) => new
            {
                Id = product?.Id ?? sale!.Id,
                ProductName = product?.Name ?? "Unknown",
                QuantitySold = sale?.Quantity ?? 0
            });

        foreach (var item in result)
        {
            Console.WriteLine($"{item.Id,-5} | {item.ProductName,-10} | {item.QuantitySold}");
        }
    }

    record Product(string Id, string Name);
    record Sale(string Id, int Quantity);
}
