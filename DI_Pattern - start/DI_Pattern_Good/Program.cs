using DI_Pattern_Good;


IContact contact = new EmailSender();
Order order = new Order(contact);
order.ContactCustomer(1, "Your shipment will be delivered tomorrow at 4pm.");

Console.WriteLine("Press any key");
Console.ReadKey();