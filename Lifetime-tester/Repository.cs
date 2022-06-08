namespace Lifetime_tester;

public class Repository
{
    private readonly ModelTransient _modelTransient;
    private readonly ModelScoped _modelScoped;
    private readonly ModelSingleton _modelSingleton;

    public Repository()
    {
        _modelTransient = new ModelTransient();
        _modelScoped = new ModelScoped();
        _modelSingleton = new ModelSingleton();
    }

    public void Run()
    {
        Console.WriteLine("Running from repository:");
        Console.WriteLine($"Transient: {_modelTransient.Id}");
        Console.WriteLine($"Scoped: {_modelScoped.Id}");
        Console.WriteLine($"Singleton: {_modelSingleton.Id}\n");
    }
}