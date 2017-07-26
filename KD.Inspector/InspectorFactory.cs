using KD.Inspector.File;
using KD.Inspector.File.Assembly;
using System.Collections.Generic;
using System.Diagnostics.Contracts;
using System.Linq;

namespace KD.Inspector
{
    /// <summary>
    /// Factory which creates new IInspector.
    /// </summary>
    public class InspectorFactory
    {
        static IDictionary<string, IInspector> inspectors = new Dictionary<string, IInspector>();

        /// <summary>
        /// Private constructor.
        /// </summary>
        private InspectorFactory()
        {
            inspectors.Add("Assembly", new AssemblyFileInspector());
        }

        /// <summary>
        /// Returns the Inspector specified for given Key.
        /// May return NULL if Key is not recognized.
        /// </summary>
        /// <param name="inspectorType"></param>
        /// <returns></returns>
        public static IInspector GetInspector(string inspectorType)
        {
            Contract.Ensures(Contract.Result<IInspector>() != null);
            if (inspectors.ContainsKey(inspectorType))
                return inspectors.FirstOrDefault(key => key.Key == inspectorType).Value;
            else
                return null;
        }
    }
}