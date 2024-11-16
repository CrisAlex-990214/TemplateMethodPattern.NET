// See https://aka.ms/new-console-template for more information
using TemplateMethodPattern;

Console.WriteLine("DIGITAL PRODUCT");
new DigitalProduct().CreateOrder(new Order { AddressId = 2, ProductId = 1, Quantity = 2 });

Console.WriteLine("PHYSICAL PRODUCT");
new PhysicalProduct().CreateOrder(new Order { AddressId = 1, ProductId = 3, Quantity = 1 });

Console.ReadKey();
