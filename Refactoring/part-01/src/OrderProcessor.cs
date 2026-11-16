namespace RefactoringLab;

public class OrderProcessor
{
    private readonly IMessageSender _messageSender;
    private readonly IRepository _repository;

    public OrderProcessor(IRepository repository, IMessageSender messageSender)
    {
        _repository = repository;
        _messageSender = messageSender;    
    }

    public void Process(int orderId, string customerEmail)
    {
        _repository.Save(orderId, DateTime.Now);
        _messageSender.Send(customerEmail, $"Order {orderId} confirmed at {DateTime.Now}");
    }
}

public class SqlOrderRepository : IRepository
{
    public void Save(int orderId, DateTime processedAt) =>
        Console.WriteLine($"[SQL] save order {orderId} @ {processedAt:O}");
}

public class SmtpEmailSender : IMessageSender
{
    public void Send(string to, string body) =>
        Console.WriteLine($"[SMTP] to={to} body={body}");
}

public interface IRepository
{
    void Save(int orderId, DateTime processedAt);
}

public interface IMessageSender
{
    void Send(string to, string body);
}