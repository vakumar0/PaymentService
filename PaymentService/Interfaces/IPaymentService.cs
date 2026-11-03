using System;
using PaymentService.Models;

namespace PaymentService.Interfaces;

public interface IPaymentService
{
    public void CreditPayment(Payment payment);

    public void DebitPayment (Payment payment);
}
