namespace LifetimeAPI;

public class ModelTransient
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

public class ModelScoped
{
    public Guid Id { get; set; } = Guid.NewGuid();
}

public class ModelSingleton
{
    public Guid Id { get; set; } = Guid.NewGuid();
}