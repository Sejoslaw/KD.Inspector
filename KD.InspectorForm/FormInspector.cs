using System;
using System.Reflection;
using System.Windows.Forms;

namespace KD.InspectorForm
{
    public partial class FormInspector : Form
    {
        public FormInspector()
        {
            InitializeComponent();
        }

        private void B_ChooseFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            if (fileDialog.ShowDialog() == DialogResult.OK)
            {
                string path = fileDialog.FileName;
                L_FilePath.Text = path;

                Assembly readedAssembly = Assembly.LoadFile(L_FilePath.Text);

                TV_FileDetails.BeginUpdate();
                TV_FileDetails.Nodes.Clear();

                Type[] types = readedAssembly.GetTypes();
                foreach (Type type in types)
                {
                    var firstLayer = TV_FileDetails.Nodes;
                    firstLayer.Add(type.Name);
                    var firstLayerCount = firstLayer.Count;

                    var secondLayer = firstLayer[firstLayerCount - 1].Nodes;
                    secondLayer.Add("Fields");
                    foreach (FieldInfo field in type.GetFields())
                    {
                        var thirdLayer = secondLayer[secondLayer.Count - 1].Nodes;
                        string fieldString =
                            (field.IsPublic ? "public " : "private ") +
                            (field.IsStatic ? "static " : "") +
                            field.ReflectedType + " " +
                            field.Name;
                        thirdLayer.Add(field.Name);
                    }

                    secondLayer.Add("Methods");
                    foreach (MethodInfo method in type.GetMethods())
                    {
                        var thirdLayer = secondLayer[secondLayer.Count - 1].Nodes;
                        string methodString =
                            (method.IsPublic ? "public " : "private ") +
                            (method.IsStatic ? "static " : "") +
                            method.ReturnType + " " +
                            method.Name + "(" + GetMethodArguments(method) + ")" +
                            ";";
                        thirdLayer.Add(methodString);
                    }
                }
                TV_FileDetails.EndUpdate();
            }
        }

        private string GetMethodArguments(MethodInfo method)
        {
            string args = "";
            ParameterInfo[] argsTypes = method.GetParameters();
            if (argsTypes.Length < 1) return "";
            for (int i = 0; i < argsTypes.Length - 1; ++i) args += argsTypes[i] + ", ";
            args += argsTypes[argsTypes.Length - 1];
            return args;
        }
    }
}