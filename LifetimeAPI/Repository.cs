namespace LifetimeAPI;

public class Repository
{
    private readonly ModelTransient _modelTransient;
    private readonly ModelScoped _modelScoped;
    private readonly ModelSingleton _modelSingleton;

    public Repository(ModelTransient modelTransient, ModelScoped modelScoped, ModelSingleton modelSingleton)
    {
        _modelTransient = modelTransient;
        _modelScoped = modelScoped;
        _modelSingleton = modelSingleton;
    }

    public void Run()
    {
        Console.WriteLine($"\nCalled from repository: ");
        Console.WriteLine($"Transient: {_modelTransient.Id}");
        Console.WriteLine($"Scoped: {_modelScoped.Id}");
        Console.WriteLine($"Singleton: {_modelSingleton.Id}\n");
    }
}