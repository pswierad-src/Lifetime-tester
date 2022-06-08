namespace Lifetime_tester;

public class Runner
{
    private readonly ModelTransient _modelTransient;
    private readonly ModelScoped _modelScoped;
    private readonly ModelSingleton _modelSingleton;

    public Runner(ModelTransient modelTransient, ModelScoped modelScoped, ModelSingleton modelSingleton)
    {
        _modelTransient = modelTransient;
        _modelScoped = modelScoped;
        _modelSingleton = modelSingleton;
    }

    public void Run()
    {
        Console.WriteLine("Object lifetime example.");
        Console.WriteLine("Visualises how transient, scoped and singletons behave.\n");

        do
        {
            var service = new Service();

            service.Run();
            
            Console.WriteLine("Type q to finish or whatever to go again.");
            
        } while (Console.ReadLine() != "q");
    }
}