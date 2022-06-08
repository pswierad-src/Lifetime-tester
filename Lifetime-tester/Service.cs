namespace Lifetime_tester;

public class Service
{
    private readonly ModelTransient _modelTransient;
    private readonly ModelScoped _modelScoped;
    private readonly ModelSingleton _modelSingleton;

    private readonly Repository _repository;

    public Service()
    {
        _modelTransient = new ModelTransient();
        _modelScoped = new ModelScoped();
        _modelSingleton = new ModelSingleton();
        _repository = new Repository();
    }

    public void Run()
    {
        Console.WriteLine("Running from service:");
        Console.WriteLine($"Transient: {_modelTransient.Id}");
        Console.WriteLine($"Scoped: {_modelScoped.Id}");
        Console.WriteLine($"Singleton: {_modelSingleton.Id}\n");

        _repository.Run();
    }
}