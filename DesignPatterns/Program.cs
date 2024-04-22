using DesignPatterns.Creational.AbstractFactory;
using DesignPatterns.Creational.Builder;
using DesignPatterns.Creational.FactoryMethod;
using DesignPatterns.Creational.Prototype;
using DesignPatterns.Creational.SimpleFactory;
using DesignPatterns.Creational.Singleton;
using DesignPatterns.Structural.Adapter;
using DesignPatterns.Structural.Bridge;
using DesignPatterns.Structural.Composite;
using DesignPatterns.Structural.Decorator;
using DesignPatterns.Structural.Facade;
using DesignPatterns.Structural.Flyweight;
using DesignPatterns.Structural.Proxy;
using System.ComponentModel.Design;

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


Console.WriteLine("\nSingleton:");
// This is invalid:
// var appConfiguration = new AppConfiguration();
var appConfig1 = AppConfiguration.GetInstance();
var appConfig2 = AppConfiguration.GetInstance();
var appConfig3 = AppConfiguration.GetInstance();
Console.WriteLine(
    appConfig1 == appConfig2 &&
    appConfig1 == appConfig3 &&
    appConfig2 == appConfig3);


Console.WriteLine("\nAdapter:");
var wildDog = new WildDog();
var wildDogAdapter = new WildDogAdapter(wildDog);
var hunter = new Hunter();
hunter.Hunt(wildDogAdapter);


Console.WriteLine("\nBridge:");
var darkTheme = new DarkTheme();
var lightTheme = new LightTheme();

var about = new About(darkTheme);
var careers = new Home(lightTheme);

Console.WriteLine(about.GetContent());
Console.WriteLine(careers.GetContent());


Console.WriteLine("\nComposite:");
var developer = new Dev("Hector", 9999);
var manager = new Manager("Doco", 11111);

var organization = new Organization();
organization.AddEmployee(developer);
organization.AddEmployee(manager);

Console.WriteLine($"Net Salary of Employees in Organization is {organization.GetNetSalaries():c}");


Console.WriteLine("\nDecorator:");
var myCoffee = new SimpleCoffee();
Console.WriteLine($"{myCoffee.GetCost():c}");
Console.WriteLine(myCoffee.GetDescription());

var milkCoffee = new MilkCoffee(myCoffee);
Console.WriteLine($"{milkCoffee.GetCost():c}");
Console.WriteLine(milkCoffee.GetDescription());

var whipCoffee = new WhipCoffee(milkCoffee);
Console.WriteLine($"{whipCoffee.GetCost():c}");
Console.WriteLine(whipCoffee.GetDescription());

var vanillaCoffee = new VanillaCoffee(whipCoffee);
Console.WriteLine($"{vanillaCoffee.GetCost():c}");
Console.WriteLine(vanillaCoffee.GetDescription());


Console.WriteLine("\nFacade:");
var computer = new ComputerFacade(new Computer());
computer.TurnOn();
computer.TurnOff();


Console.WriteLine("\nFlyweight:");
var teaMaker = new TeaMaker();
var teaShop = new TeaShop(teaMaker);

teaShop.TakeOrder("less sugar", 1);
teaShop.TakeOrder("more milk", 2);
teaShop.TakeOrder("without sugar", 5);

teaShop.Serve();


Console.WriteLine("\nProxy:");
var securedDoor = new SecuredDoor(new LabDoor());
securedDoor.Open();
securedDoor.Open("invalid");
securedDoor.Open("$ecr@t");
securedDoor.Close();
