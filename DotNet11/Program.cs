using DotNet11;

var paymentService = new PaymentService();

PaymentResult result = paymentService.ProcessPayment(1500);

string message = result switch
{
    PaymentAccepted accepted => $"Payment successful: {accepted.TransactionId}",
    PaymentDeclined declined => $"Payment failed: {declined.Reason}",
    PaymentRequiresAuthentication authentication => $"Authentication required: {authentication.RedirectUrl}"
};

Console.WriteLine(message);

// We don't need a default branch.
// The interesting distinction is that union cases don't need to inherit from the same base class or share properties.










var fruit = FruitFactory.CreateFruit();
decimal price = fruit switch
{
    Apple => 1.9m,
    Banana => 1.5m
};
Console.WriteLine($"The price of the fruit is: {price}");





















List<int> numbers1 = new List<int>
{
    12,
    16,
    19
};

List<int> numbers2 = [12, 16, 19]; // Collection Expression

List<int> numbers3 = new List<int>(10)
{
    12,
    16,
    19
};

List<int> numbers4 = [with(10), 12, 16, 19];

Console.WriteLine();
LINQFullJoin.Example();