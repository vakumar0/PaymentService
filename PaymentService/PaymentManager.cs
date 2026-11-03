using System;
using PaymentService.Interfaces;
using PaymentService.Models;
using PaymentService.Services;

namespace PaymentService;

public class PaymentManager
{
    public void MakePayment(decimal amount, string paymentType)
    {
        Payment payment = new Payment(amount);

        IPaymentService paymentService = paymentType switch
        {
            "UPI" => new UPIPayment(),
            "CreditCard" => new CreditCardPayment(),
            _ => throw new Exception("Payment type does not exists")
        };

        paymentService.CreditPayment(payment);
        // paymentService.DebitPayment(payment);
    }
}
