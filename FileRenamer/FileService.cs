namespace FileRenamer;

internal static class FileService
{
    internal static FileInfo[] GetFiles(string path)
    {
        //Ejemplo de directorio E:\DCIM\100MEDIA\*.jpg
        string folder = path[..(path.LastIndexOf(@"\") + 1)];
        int from = path.LastIndexOf(@"\") + 1;
        string fileFilter = path[from..];
        FileInfo[] files = new DirectoryInfo(folder).GetFiles(fileFilter);
        
        return files;
    }
}
