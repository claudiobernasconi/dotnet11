namespace DotNet11;

public record PaymentAccepted(Guid TransactionId);
public record PaymentDeclined(string Reason);
public record PaymentRequiresAuthentication(string RedirectUrl);
// public record PaymentPending();

public union PaymentResult(
    PaymentAccepted,
    PaymentDeclined,
    PaymentRequiresAuthentication
);

public class PaymentService
{
    public PaymentResult ProcessPayment(decimal amount)
    {
        if (amount <= 0)
        {
            return new PaymentDeclined("Invalid payment amount");
        }

        if (amount > 1000)
        {
            return new PaymentRequiresAuthentication("https://payment.example.com/auth");
        }

        return new PaymentAccepted(Guid.NewGuid());
    }
}

// The method returns PaymentResult, not object, dynamic, or a generic response wrapper.
