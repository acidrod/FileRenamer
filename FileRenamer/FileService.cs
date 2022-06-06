namespace FileRenamer;

/*
 * Steps: 
 * 1. load all files names in an array of FileInfo.
 * 2. creates a new filename based on the -t and -n parameters
 * 3. rename files one by one looping thru the FileInfo array applying the new filename
*/
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
