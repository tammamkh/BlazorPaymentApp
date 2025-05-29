// Services/IPaymentService.cs
public interface IPaymentService
{
    Task<bool> ProcessPaymentAsync(string cardNumber, decimal amount);
}
