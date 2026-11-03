// See https://aka.ms/new-console-template for more information
using PaymentService;

PaymentManager paymentManager = new PaymentManager();

paymentManager.MakePayment(25, "UPI");
