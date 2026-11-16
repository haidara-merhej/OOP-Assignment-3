# Part 01 — answers

---

## ShippingCostCalculator

- What was the problem?

The original `ShippingCostCalculator` used a `switch` statement to
determine the shipping cost based on the carrier name. This made the
class tightly coupled to the supported carriers and required modifying
it whenever a new carrier was added.

- What did you change?

I introduced the `IShippingCarrier` interface and implemented it in
separate carrier classes (`AramexCarrier`, `FedExCarrier`, and
`DHLCarrier`). Each carrier is now responsible for calculating its own
shipping cost, while `ShippingCostCalculator` depends on the
abstraction.

---

## OrderProcessor

- What was the problem?

The original `OrderProcessor` created its concrete dependencies
(`SqlOrderRepository` and `SmtpEmailSender`) inside the `Process`
method. This tightly coupled the processor to specific implementations
and made testing or replacing those dependencies difficult.

- What did you change?

I introduced the `IOrderRepository` and `IMessageSender` interfaces and
passed their implementations to `OrderProcessor` through constructor
injection.

---

## Notifications

- What was the problem?

The original notification design relied on inheritance to represent
combinations such as urgent email, scheduled SMS, and urgent scheduled
email. Adding more channels or behaviors would cause a large number of
subclasses.

- What did you change?

I refactored the design to use the `INotification` interface for
notification channels and composed optional behaviors through
`UrgentBehavior` and `ScheduledBehavior`.

`EmailNotification` and `SmsNotification` can now use these behaviors
independently or together. This makes it possible to support different
combinations without creating a separate class for every combination.

---

## Verification

I verified that the refactored notification implementations preserve the
original output behavior.

## Adding a New Shipping Carrier

I added `UpsCarrier` by implementing `IShippingCarrier`. No existing
carrier or calculator class needed to be modified.

This demonstrates that the design is open to extension without requiring
changes to existing code.

## Adding a New Notification Channel

I added `WhatsAppNotification` by implementing `INotification` and
composing it with the existing optional behaviors.

I tested the new channel to verify that it supports normal, urgent,
scheduled, and urgent scheduled notifications.

## Principles Applied

-   **Open/Closed Principle (OCP):** New shipping carriers and
    notification channels can be added without modifying existing
    high-level classes.
-   **Dependency Inversion Principle (DIP):** `OrderProcessor` depends
    on interfaces rather than concrete implementations.
-   **Composition over Inheritance:** Notification behaviors are
    composed instead of creating subclasses for every possible
    combination.
