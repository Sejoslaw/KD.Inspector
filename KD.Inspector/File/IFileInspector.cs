using System.IO;

namespace KD.Inspector.File
{
    /// <summary>
    /// Inspector specified for Files.
    /// </summary>
    public interface IFileInspector : IInspector
    {
        void ReadFile(string path);

        FileInfo GetFileInfo();
    }
}