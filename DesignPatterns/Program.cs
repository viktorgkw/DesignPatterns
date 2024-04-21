using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.SimpleFactory;

Console.WriteLine("Simple Factory:");
var keyboard = KeyboardFactory.CreateKeyboard(true, "60%");
keyboard.GetLayout();


Console.WriteLine("\nFactory Method:");
var marketingManager = new RecruiterManager();
var devManager = new DevelopmentManager();
marketingManager.TakeInterview();
devManager.TakeInterview();


Console.WriteLine("\nAbstract Factory:");
var woodenDoorFactory = new WoodenDoorFactory();
var woodenDoor = woodenDoorFactory.MakeDoor();
var woodenDoorMaker = woodenDoorFactory.GetDoorMaker();
Console.WriteLine($"{woodenDoorMaker.MakeType()}. {woodenDoor.GetDescription()}");

var ironDoorFactory = new IronDoorFactory();
var ironDoor = ironDoorFactory.MakeDoor();
var ironDoorMaker = ironDoorFactory.GetDoorMaker();
Console.WriteLine($"{ironDoorMaker.MakeType()}. {ironDoor.GetDescription()}");


Console.WriteLine("\nBuilder:");
var burger = new BurgerBuilder(4)
    .AddCheese()
    .AddPepperoni()
    .AddTomato()
    .Build();

Console.WriteLine(burger.GetDescription());
Console.WriteLine(burger.HasCheese());
Console.WriteLine(burger.HasLettuce());
Console.WriteLine(burger.HasPepperoni());
Console.WriteLine(burger.HasTomato());

Console.WriteLine("\nPrototype:");
var original = new Dummy("Josh");
Console.WriteLine(original.Name);

var cloned = original.Clone();
cloned.Name = "Stan";
Console.WriteLine(cloned.Name);
