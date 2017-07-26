namespace KD.InspectorForm
{
    partial class FormInspector
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Wymagana metoda obsługi projektanta — nie należy modyfikować 
        /// zawartość tej metody z edytorem kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.GB_File = new System.Windows.Forms.GroupBox();
            this.B_ChooseFile = new System.Windows.Forms.Button();
            this.GB_FilePath = new System.Windows.Forms.GroupBox();
            this.L_FilePath = new System.Windows.Forms.Label();
            this.GB_FileDetails = new System.Windows.Forms.GroupBox();
            this.GB_File.SuspendLayout();
            this.GB_FilePath.SuspendLayout();
            this.SuspendLayout();
            // 
            // GB_File
            // 
            this.GB_File.Controls.Add(this.GB_FilePath);
            this.GB_File.Controls.Add(this.B_ChooseFile);
            this.GB_File.Location = new System.Drawing.Point(12, 12);
            this.GB_File.Name = "GB_File";
            this.GB_File.Size = new System.Drawing.Size(528, 82);
            this.GB_File.TabIndex = 0;
            this.GB_File.TabStop = false;
            this.GB_File.Text = "File";
            // 
            // B_ChooseFile
            // 
            this.B_ChooseFile.Location = new System.Drawing.Point(7, 20);
            this.B_ChooseFile.Name = "B_ChooseFile";
            this.B_ChooseFile.Size = new System.Drawing.Size(103, 48);
            this.B_ChooseFile.TabIndex = 0;
            this.B_ChooseFile.Text = "Choose File";
            this.B_ChooseFile.UseVisualStyleBackColor = true;
            // 
            // GB_FilePath
            // 
            this.GB_FilePath.Controls.Add(this.L_FilePath);
            this.GB_FilePath.Location = new System.Drawing.Point(136, 19);
            this.GB_FilePath.Name = "GB_FilePath";
            this.GB_FilePath.Size = new System.Drawing.Size(386, 49);
            this.GB_FilePath.TabIndex = 1;
            this.GB_FilePath.TabStop = false;
            this.GB_FilePath.Text = "File Path";
            // 
            // L_FilePath
            // 
            this.L_FilePath.AutoSize = true;
            this.L_FilePath.Location = new System.Drawing.Point(15, 19);
            this.L_FilePath.Name = "L_FilePath";
            this.L_FilePath.Size = new System.Drawing.Size(45, 13);
            this.L_FilePath.TabIndex = 0;
            this.L_FilePath.Text = "FilePath";
            // 
            // GB_FileDetails
            // 
            this.GB_FileDetails.Location = new System.Drawing.Point(12, 101);
            this.GB_FileDetails.Name = "GB_FileDetails";
            this.GB_FileDetails.Size = new System.Drawing.Size(528, 395);
            this.GB_FileDetails.TabIndex = 1;
            this.GB_FileDetails.TabStop = false;
            this.GB_FileDetails.Text = "File Details";
            // 
            // FormInspector
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(552, 508);
            this.Controls.Add(this.GB_FileDetails);
            this.Controls.Add(this.GB_File);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.Name = "FormInspector";
            this.Text = "KD Inspector Window";
            this.GB_File.ResumeLayout(false);
            this.GB_FilePath.ResumeLayout(false);
            this.GB_FilePath.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_File;
        private System.Windows.Forms.Button B_ChooseFile;
        private System.Windows.Forms.GroupBox GB_FilePath;
        private System.Windows.Forms.Label L_FilePath;
        private System.Windows.Forms.GroupBox GB_FileDetails;
    }
}

