namespace FileRenamer;

internal class Options
{
    [Value(0,MetaName = "FilePath", HelpText = @"This argument indicates where are the files to be renamed. (Example: E:\DCIM\100MEDIA\*.jpg)", Required = true)]
    public string FilesPath { get; set; }

    [Option('t', "tofileName", HelpText = "This option will let you configure the new name of the files to be renamed.")]
    public string ToFileName { get; set; } = null!;

    [Option('n', "numericStart", HelpText = "This option will let you configure the starting number for secuencial files. (Example: 0001")]
    public string NumericStart { get; set; } = null!;

    public override string ToString()
    {
        return $"FilePath {FilesPath}, ToFileName {ToFileName}, NumericStart {NumericStart}";
    }
}
