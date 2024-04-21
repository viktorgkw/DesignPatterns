using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.SimpleFactory;

Console.WriteLine("Simple Factory:");
var keyboard = KeyboardFactory.CreateKeyboard(true, "60%");
Console.WriteLine($"Keyboard's Layout -> {keyboard.GetLayout()}");


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
