// Services/PaymentService.cs
public class PaymentService : IPaymentService
{
    public async Task<bool> ProcessPaymentAsync(string cardNumber, decimal amount)
    {
        // Simulate payment processing delay
        await Task.Delay(1000);

        // Simulate success if card number is valid
        return !string.IsNullOrWhiteSpace(cardNumber) && amount > 0;
    }
}
