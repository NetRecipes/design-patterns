namespace DesignPatterns.Creational;

public class Singleton
{
    private Singleton() { }

    private static readonly Lazy<Singleton> _instance = new(() => new Singleton());

    public Singleton Instance = _instance.Value;
}
