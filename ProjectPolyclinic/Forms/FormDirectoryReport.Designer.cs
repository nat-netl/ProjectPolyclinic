namespace ProjectPolyclinic.Forms
{
    partial class FormDirectoryReport
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            checkBoxPacients = new CheckBox();
            checkBoxEmployees = new CheckBox();
            checkBoxMedicines = new CheckBox();
            buttonBuild = new Button();
            SuspendLayout();
            // 
            // checkBoxPacients
            // 
            checkBoxPacients.AutoSize = true;
            checkBoxPacients.Location = new Point(50, 44);
            checkBoxPacients.Name = "checkBoxPacients";
            checkBoxPacients.Size = new Size(82, 19);
            checkBoxPacients.TabIndex = 0;
            checkBoxPacients.Text = "Пациенты";
            checkBoxPacients.UseVisualStyleBackColor = true;
            // 
            // checkBoxEmployees
            // 
            checkBoxEmployees.AutoSize = true;
            checkBoxEmployees.Location = new Point(50, 89);
            checkBoxEmployees.Name = "checkBoxEmployees";
            checkBoxEmployees.Size = new Size(72, 19);
            checkBoxEmployees.TabIndex = 1;
            checkBoxEmployees.Text = "Доктора";
            checkBoxEmployees.UseVisualStyleBackColor = true;
            // 
            // checkBoxMedicines
            // 
            checkBoxMedicines.AutoSize = true;
            checkBoxMedicines.Location = new Point(50, 138);
            checkBoxMedicines.Name = "checkBoxMedicines";
            checkBoxMedicines.Size = new Size(104, 19);
            checkBoxMedicines.TabIndex = 2;
            checkBoxMedicines.Text = "Медикаменты";
            checkBoxMedicines.UseVisualStyleBackColor = true;
            // 
            // buttonBuild
            // 
            buttonBuild.Location = new Point(225, 86);
            buttonBuild.Name = "buttonBuild";
            buttonBuild.Size = new Size(105, 23);
            buttonBuild.TabIndex = 3;
            buttonBuild.Text = "Сформировать";
            buttonBuild.UseVisualStyleBackColor = true;
            buttonBuild.Click += buttonBuild_Click;
            // 
            // FormDirectoryReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(362, 197);
            Controls.Add(buttonBuild);
            Controls.Add(checkBoxMedicines);
            Controls.Add(checkBoxEmployees);
            Controls.Add(checkBoxPacients);
            Name = "FormDirectoryReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormDirectoryReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckBox checkBoxPacients;
        private CheckBox checkBoxEmployees;
        private CheckBox checkBoxMedicines;
        private Button buttonBuild;
    }
}