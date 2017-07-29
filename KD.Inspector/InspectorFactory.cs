using KD.Inspector.File.Assembly;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Diagnostics.Contracts;

namespace KD.Inspector
{
    /// <summary>
    /// Factory which creates new IInspector.
    /// </summary>
    public class InspectorFactory
    {
        #region Private Variables

        IDictionary<Type, Type> inspectors = new Dictionary<Type, Type>();

        #endregion Private Variables

        #region Public Methods

        /// <summary>
        /// Constructor in which Inspectors are added.
        /// </summary>
        public InspectorFactory()
        {
            inspectors.Add(typeof(IAssemblyFileInspector), typeof(AssemblyFileInspector));
        }

        /// <summary>
        /// Returns the Inspector specified for given generic inspector type.
        /// May return NULL if Key is not recognized.
        /// </summary>
        /// <returns></returns>
        public TInspectorType GetInspector<TInspectorType>() where TInspectorType : IInspector
        {
            Contract.Ensures(Contract.Result<TInspectorType>() != null);

            var inspectorType = typeof(TInspectorType);
            var outputTypePair = inspectors.FirstOrDefault(type => type.Key == inspectorType);
            if (outputTypePair.Key == null || outputTypePair.Value == null) throw new Exception("Cannot resolve type.");

            var outputType = outputTypePair.Value;
            if (!inspectorType.IsAssignableFrom(outputType)) throw new Exception("Cannot resolve type.");

            return (TInspectorType) Activator.CreateInstance(outputType);
        }
        
        #endregion Public Methods

        #region Public Static Methods

        /// <summary>
        /// Returns new instance of Inspector Factory.
        /// </summary>
        /// <returns></returns>
        public static InspectorFactory NewFactory()
        {
            return new InspectorFactory();
        }

        #endregion Public Static Methods
    }
}