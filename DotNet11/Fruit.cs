namespace DotNet11;

public closed class Fruit { }
public class Apple : Fruit { }
public class Banana : Fruit { }
// public class Cherry : Fruit { }

public class FruitFactory
{
    public static Fruit CreateFruit()
    {
        var random = new Random();
        return random.Next(0, 2) switch
        {
            0 => new Apple(),
            1 => new Banana(),
            _ => throw new InvalidOperationException("Unexpected random value")
        };
    }
}
