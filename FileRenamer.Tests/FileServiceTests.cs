namespace FileRenamer.Tests;

[TestFixture]
public class FileServiceTests
{
    private string _currentDirectory;

    public FileServiceTests()
    {
        _currentDirectory = AppDomain.CurrentDomain.BaseDirectory;
    }


    [TestCase]
    public void When_PathExists_Expects_GetFilesNotNull()
    {
        //Arrange 

        //Act
        FileInfo[] current = FileService.GetFiles(_currentDirectory);

        //Assert
        Assert.That(current, Is.Not.Null);
    }

    [TestCase]
    public void When_PathExists_Expects_GetFilesNotEmpty()
    {
        //Arrange

        //Act
        FileInfo[] current = FileService.GetFiles(_currentDirectory);

        //Assert
        Assert.That(current, Is.Not.Null);
    }

    [TestCase]
    public void When_PathExists_Expects_GetFilesToHaveFileRenamerDllPresent()
    {
        //Arrange
        FileInfo[] current = FileService.GetFiles(_currentDirectory);

        //Act
        var findDll = current
            .Where(f => f.Name.Equals("FileRenamer.dll", StringComparison.CurrentCultureIgnoreCase));

        //Assert
        Assert.That(findDll, Is.Not.Null);
    }

    [TestCase("")]
    [TestCase(null)]
    public void When_PathIsNullOrEmpty_Expects_ArgumentNullException(string givenPath)
    {
        string path = givenPath;
        Assert.Throws<ArgumentNullException>(() => FileService.GetFiles(path));
    }

    [TestCase]
    public void When_AllArgumentsArePassedShouldReturnAValidNewFileName()
    {
        //Arrange
        string originalFile = "DJI_0234.jpg";
        string newFileName = "Scene_";
        int numericalStartPoint = 10;

        string expected = "Scene_0010.jpg";

        //Act
        var Actual = FileService.GetNewFileName(originalFile, newFileName, numericalStartPoint);

        Assert.That(Actual, Is.EqualTo(expected));
        Console.WriteLine(Actual);
    }
}
