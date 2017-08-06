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
                Type[] types = readedAssembly.GetTypes();
                foreach (Type type in types)
                {
                    TV_FileDetails.BeginUpdate();

                    var firstLayer = TV_FileDetails.Nodes;
                    var firstLayerCount = firstLayer.Count - 1;

                    firstLayer.Add(type.Name);

                    var secondLayer = firstLayer[firstLayerCount].Nodes;
                    secondLayer.Add("Fields");
                    foreach (FieldInfo field in type.GetFields())
                    {
                        var thirdLayer = secondLayer[secondLayer.Count - 1].Nodes;
                        
                        thirdLayer.Add(field.Name);
                    }

                    secondLayer.Add("Methods");
                    foreach (MethodInfo method in type.GetMethods())
                    {
                        var thirdLayer = secondLayer[secondLayer.Count - 1].Nodes;
                        string methodString = 
                            (method.IsPublic ? "public " : "private ") + 
                            (method.IsStatic ? "static " : "") + 
                            (method.ReturnType.ToString() + " ") + 
                            method.Name + "(" + 
                    }

                    TV_FileDetails.EndUpdate();
                }
            }
        }
    }
}