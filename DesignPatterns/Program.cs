using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.SimpleFactory;

Console.WriteLine("Simple Factory:");
var keyboard = KeyboardFactory.CreateKeyboard(true, "60%");
Console.WriteLine($"Keyboard's Layout -> {keyboard.GetLayout()}\n");


Console.WriteLine("Factory Method:");
var marketingManager = new RecruiterManager();
var devManager = new DevelopmentManager();
marketingManager.TakeInterview();
devManager.TakeInterview();
