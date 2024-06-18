using console;
using Microsoft.Extensions.DependencyInjection;

var serviceProvider = new ServiceCollection()
    .AddDependencyInjection()
    .BuildServiceProvider();

var app = serviceProvider.GetRequiredService<IApplication>();
return await app.Run();
