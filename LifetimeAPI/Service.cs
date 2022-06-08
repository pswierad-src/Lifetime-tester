namespace LifetimeAPI;

public class Service
{
    private readonly ModelTransient _modelTransient;
    private readonly ModelScoped _modelScoped;
    private readonly ModelSingleton _modelSingleton;

    private readonly Repository _repository;

    public Service(ModelTransient modelTransient, ModelScoped modelScoped, ModelSingleton modelSingleton, Repository repository)
    {
        _modelTransient = modelTransient;
        _modelScoped = modelScoped;
        _modelSingleton = modelSingleton;
        _repository = repository;
    }

    public void Run()
    {
        Console.WriteLine($"\nCalled from service: ");
        Console.WriteLine($"Transient: {_modelTransient.Id}");
        Console.WriteLine($"Scoped: {_modelScoped.Id}");
        Console.WriteLine($"Singleton: {_modelSingleton.Id}\n");
        
        _repository.Run();
    }
}