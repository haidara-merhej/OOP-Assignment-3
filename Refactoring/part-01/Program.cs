using RefactoringLab;

var shipping = new ShippingCostCalculator();

Console.WriteLine($"Aramex 2kg → {shipping.Calculate(new AramexCarrier(), 2)}");
Console.WriteLine($"FedEx 2kg  → {shipping.Calculate(new FedExCarrier(), 2)}");
Console.WriteLine($"Ups 2kg  → {shipping.Calculate(new UpsCarrier(), 2)}");
Console.WriteLine();

var processor = new OrderProcessor(new SqlOrderRepository(), new SmtpEmailSender());
processor.Process(1001, "customer@example.com");
Console.WriteLine();

new EmailNotification(new UrgentBehavior(), new ScheduledBehavior(DateTime.Today.AddHours(18)))
    .Send("customer@example.com", "Your order ships tomorrow");
new SmsNotification(new UrgentBehavior())
    .Send("+201000000000", "OTP 4821");

new WhatsAppNotification(null, new ScheduledBehavior(DateTime.Today.AddHours(18)))
    .Send("customer@example.com", "Your order ships tomorrow");
