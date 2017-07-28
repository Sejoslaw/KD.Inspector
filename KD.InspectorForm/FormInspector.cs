using KD.Inspector;
using KD.Inspector.File.Assembly;
using System;
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

                IAssemblyFileInspector inspector = InspectorFactory.GetInspector<IAssemblyFileInspector>();
                inspector.ReadFile(L_FilePath.Text);
            }
        }
    }
}
