using System;

namespace PaymentService.Models;

public class Payment
{
    public decimal Amount {get;}

    public PaymentStatus Status {get; private set;}

    public Payment(decimal amount)
    {
        if(amount <= 0)
        {
            throw new ArgumentException("Amount should be greated than 0");
        }

        Amount = amount;
        Status = PaymentStatus.Pending;
    }

    public void Completed()
    {
        if(Status != PaymentStatus.Pending)
        {
            throw new Exception("Payment should be in pending state");
        }

        Status = PaymentStatus.Completed;
    }

    public void Failed()
    {
        if(Status != PaymentStatus.Pending)
        {
            throw new Exception("Payment should be in pending state");
        }

        Status = PaymentStatus.Failed;
    }
}
