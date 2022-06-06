namespace FileRenamer;

internal static class Configuration
{
    /*
    * Steps: 
    * 1. load all files names in an array of FileInfo.
    * 2. creates a new filename based on the -t and -n parameters
    * 3. rename files one by one looping thru the FileInfo array applying the new filename
    */

    public static void RunOptions(Options opt)
    {
        //handle options
        try
        {
            var files = FileService.GetFiles(opt.FilesPath);

            //foreach (var file in files)
            //{
            //    int numericalStart = int.Parse(opt.NumericStart);
            //    var newFileName = FileService.GetNewFileName(file.Name,opt.ToFileName, numericalStart);
            //}
        }
        catch (Exception ex)
        {
            Console.WriteLine(ex.Message);
        }

        Console.WriteLine($"Rename: {opt.ToFileName}");
        Console.WriteLine($"Numeric: {opt.NumericStart}");
    }

    public static void HandleParseError(IEnumerable<Error> errs)
    {
        //handle errors
    }
}
