namespace ProjectPolyclinic.Forms
{
    partial class FormHealingPacientDistributionReport
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
            dateTimePicker = new DateTimePicker();
            labelFileName = new Label();
            label2 = new Label();
            buttonSelectFileName = new Button();
            buttonCreate = new Button();
            SuspendLayout();
            // 
            // dateTimePicker
            // 
            dateTimePicker.Location = new Point(137, 86);
            dateTimePicker.Name = "dateTimePicker";
            dateTimePicker.Size = new Size(200, 23);
            dateTimePicker.TabIndex = 0;
            // 
            // labelFileName
            // 
            labelFileName.AutoSize = true;
            labelFileName.Location = new Point(230, 39);
            labelFileName.Name = "labelFileName";
            labelFileName.Size = new Size(36, 15);
            labelFileName.TabIndex = 1;
            labelFileName.Text = "Файл";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(81, 92);
            label2.Name = "label2";
            label2.Size = new Size(32, 15);
            label2.TabIndex = 2;
            label2.Text = "Дата";
            // 
            // buttonSelectFileName
            // 
            buttonSelectFileName.Location = new Point(137, 35);
            buttonSelectFileName.Name = "buttonSelectFileName";
            buttonSelectFileName.Size = new Size(75, 23);
            buttonSelectFileName.TabIndex = 3;
            buttonSelectFileName.Text = "Выбрать";
            buttonSelectFileName.UseVisualStyleBackColor = true;
            buttonSelectFileName.Click += buttonSelectFileName_Click;
            // 
            // buttonCreate
            // 
            buttonCreate.Location = new Point(155, 134);
            buttonCreate.Name = "buttonCreate";
            buttonCreate.Size = new Size(111, 23);
            buttonCreate.TabIndex = 4;
            buttonCreate.Text = "Сформировать";
            buttonCreate.UseVisualStyleBackColor = true;
            buttonCreate.Click += buttonCreate_Click;
            // 
            // FormHealingPacientDistributionReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(375, 182);
            Controls.Add(buttonCreate);
            Controls.Add(buttonSelectFileName);
            Controls.Add(label2);
            Controls.Add(labelFileName);
            Controls.Add(dateTimePicker);
            Name = "FormHealingPacientDistributionReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormHealingPacientDistributionReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePicker;
        private Label labelFileName;
        private Label label2;
        private Button buttonSelectFileName;
        private Button buttonCreate;
    }
}