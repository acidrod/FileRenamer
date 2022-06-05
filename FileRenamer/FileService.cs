namespace FileRenamer;

public static class FileService
{
    public static FileInfo[] GetFiles(string path)
    {
        if (string.IsNullOrEmpty(path))
            throw new ArgumentNullException("The path is required.");

        string folder = path[..(path.LastIndexOf(@"\") + 1)];
        int from = path.LastIndexOf(@"\") + 1;
        string fileFilter = path[from..];
        FileInfo[] files = new DirectoryInfo(folder).GetFiles(fileFilter);
        
        return files;
    }
}
