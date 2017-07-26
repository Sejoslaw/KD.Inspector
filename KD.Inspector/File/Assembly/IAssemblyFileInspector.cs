namespace KD.Inspector.File.Assembly
{
    /// <summary>
    /// Inspector specified for Assembly Files.
    /// </summary>
    public interface IAssemblyFileInspector : IFileInspector
    {
        /// <summary>
        /// Returns system Assembly.
        /// </summary>
        /// <returns></returns>
        System.Reflection.Assembly GetAssembly();
    }
}