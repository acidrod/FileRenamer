namespace FileRenamer;

internal static class Configuration
{
    internal static void RunOptions(Options opt)
    {
        //handle options
        Console.WriteLine($"Path: {opt.FilesPath}");
        Console.WriteLine($"Rename: {opt.ToFileName}");
        Console.WriteLine($"Numeric: {opt.NumericStart}");
    }

    internal static void HandleParseError(IEnumerable<Error> errs)
    {
        //handle errors
    }
}
