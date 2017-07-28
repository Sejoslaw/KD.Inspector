using System;
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
            return null;
        }

        public void ReadFile(string path)
        {
            FileInfo = new FileInfo(path);
        }
    }
}