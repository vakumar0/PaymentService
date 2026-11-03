using System;
using PaymentService.Interfaces;
using PaymentService.Models;

namespace PaymentService.Services;

public class CreditCardPayment : IPaymentService
{

    public void CreditPayment(Payment payment)
    {
        payment.Completed();
        Console.WriteLine("payment credited, ${0}", payment.Amount);
    }

    public void DebitPayment(Payment payment)
    {
        payment.Completed();
        Console.WriteLine("Payment debited, ${0}", payment.Amount);
    } 
}
