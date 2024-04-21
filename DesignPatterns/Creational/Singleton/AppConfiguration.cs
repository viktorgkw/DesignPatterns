namespace DesignPatterns.Creational.Singleton;

public class AppConfiguration
{
    private static AppConfiguration _instance;

    private AppConfiguration()
    {
        // Don't let outside instanciations!
    }

    public static AppConfiguration GetInstance()
    {
        _instance ??= new AppConfiguration();
        return _instance;
    }
}
