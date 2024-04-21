using DesignPatterns.Creational.SimpleFactory;

Console.WriteLine("Hello Design Patterns!\n");

var keyboard = KeyboardFactory.CreateKeyboard(true, "60%");
Console.WriteLine($"Keyboard's Layout -> {keyboard.GetLayout()}\n");
