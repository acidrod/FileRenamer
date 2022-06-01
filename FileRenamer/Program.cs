//Usage example FileRenamer "E:\DCIM\100MEDIA\*.jpg" -t DJI_ -n 0001 ==> DJI_0001.JPG

namespace FileRenamer;

class Program
{
    public static void Main(string[] args)
    {
        Parser.Default.ParseArguments<Options>(args)
            .WithParsed(o => Configuration.RunOptions(o))
            .WithNotParsed((e) => Configuration.HandleParseError(e));
    }
}
