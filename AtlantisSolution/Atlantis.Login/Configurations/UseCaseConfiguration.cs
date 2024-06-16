namespace Configurations;

public static class UseCaseConfiguration
{
    public static IServiceCollection AddUseCase(this IServiceCollection service)
    {
        //service.AddMediatR(typeof(CreateCategory));
        service.AddRepository();
        return service;
    }

    public static IServiceCollection AddRepository(this IServiceCollection service)
    {
        //service.AddTransient<ICategoryRepository, CategoryRepository>();
        //service.AddTransient<IUnityOfWork, UnityOfWork>();
        return service;
    }
}