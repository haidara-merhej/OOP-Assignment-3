namespace RefactoringLab;

public class EmailNotification : INotification
{
    private readonly UrgentBehavior? _urgent;
    private readonly ScheduledBehavior? _scheduled;

    public EmailNotification(UrgentBehavior? urgent = null, ScheduledBehavior? scheduled = null)
    {
        _urgent = urgent;
        _scheduled = scheduled;
    }

    public void Send(string to, string message)
    {
        if(_urgent != null)
            message = _urgent.MarkAsUrgent(message);

        if(_scheduled != null)
            Console.WriteLine($"[email scheduled {_scheduled.SendAt:g}] {to}: {message}");
        else
            Console.WriteLine($"[email] {to}: {message}");
    }
}

public class SmsNotification : INotification
{
 private readonly UrgentBehavior? _urgent;
    private readonly ScheduledBehavior? _scheduled;

    public SmsNotification(UrgentBehavior? urgent = null, ScheduledBehavior? scheduled = null)
    {
        _urgent = urgent;
        _scheduled = scheduled;
    }

    public void Send(string to, string message)
    {
        if(_urgent != null)
            message = _urgent.MarkAsUrgent(message);

        if(_scheduled != null)
            Console.WriteLine($"[sms scheduled {_scheduled.SendAt:g}] {to}: {message}");
        else
            Console.WriteLine($"[sms] {to}: {message}");
    }
}

public class WhatsAppNotification : INotification
{
 private readonly UrgentBehavior? _urgent;
    private readonly ScheduledBehavior? _scheduled;

    public WhatsAppNotification(UrgentBehavior? urgent = null, ScheduledBehavior? scheduled = null)
    {
        _urgent = urgent;
        _scheduled = scheduled;
    }

    public void Send(string to, string message)
    {
        if(_urgent != null)
            message = _urgent.MarkAsUrgent(message);

        if(_scheduled != null)
            Console.WriteLine($"[whatsApp scheduled {_scheduled.SendAt:g}] {to}: {message}");
        else
            Console.WriteLine($"[whatsApp] {to}: {message}");
    }
}


public interface INotification
{
    void Send(string to, string message);
}

public class UrgentBehavior
{
    public string MarkAsUrgent(string message)
    {
        return $"[URGENT] {message}";
    }
}

public class ScheduledBehavior
{
    public DateTime SendAt { get; }

    public ScheduledBehavior(DateTime sendAt)
    {
        SendAt = sendAt;
    }
}