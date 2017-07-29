using System.Diagnostics.Contracts;
using System.IO;

namespace KD.Inspector.File.Assembly
{
    class AssemblyFileInspector : IAssemblyFileInspector
    {
        FileInfo FileInfo { get; set; }

        System.Reflection.Assembly Assembly { get; set; }

        public System.Reflection.Assembly GetAssembly()
        {
            return null;
        }

        public FileInfo GetFileInfo()
        {
            Contract.Ensures(Contract.Result<FileInfo>() != null);

            return FileInfo;
        }

        public void ReadFile(string path)
        {
            FileInfo = new FileInfo(path);
            Assembly = System.Reflection.Assembly.ReflectionOnlyLoadFrom(path);
        }
    }
}