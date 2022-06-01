namespace FileRenamer;

internal static class Configuration
{
    internal static void RunOptions(Options opt)
    {
        //handle options
        try
        {
            var files = FileService.GetFiles(opt.FilesPath);
            int id = 1;

            foreach (var file in files)
            {
                Console.WriteLine($"{id} -> {file.Name}");
                id++;
            }
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Rename: {opt.ToFileName}");
        Console.WriteLine($"Numeric: {opt.NumericStart}");
    }

    internal static void HandleParseError(IEnumerable<Error> errs)
    {
        //handle errors
    }
}
