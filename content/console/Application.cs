using Spectre.Console;

namespace console;

public class Application(IAnsiConsole console) : IApplication
{
    private readonly IAnsiConsole _console = console;

    public async Task<int> Run()
    {
        _console.Markup("[underline red]Hello[/] World!");
        return await Task.FromResult(0);
    }
}

public interface IApplication
{
    Task<int> Run();
}
