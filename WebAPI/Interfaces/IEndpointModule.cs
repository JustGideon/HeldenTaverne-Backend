namespace JustGideon.DSA5CharacterManager.WebAPI.Interfaces;

internal interface IEndpointModule
{
    void AddRoutes(IEndpointRouteBuilder app);
}

public static class EndpointModule
{
    public static List<Type> TypesImplementingInterface(Type desiredType)
    {
        return AppDomain.CurrentDomain.GetAssemblies()
            .SelectMany(assembly => assembly.GetTypes())
            .Where(type => desiredType.IsAssignableFrom(type) && type.IsClass).ToList();
    }

    public static void Test1()
    {
        var endpointModuleTypes = TypesImplementingInterface(typeof(IEndpointModule));
    }
}