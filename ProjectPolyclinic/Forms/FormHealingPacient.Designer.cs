namespace ProjectPolyclinic.Forms
{
    partial class FormHealingPacient
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
            label1 = new Label();
            comboBoxMedicament = new ComboBox();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            comboBoxEmoloyee = new ComboBox();
            comboBoxPacient = new ComboBox();
            numericUpDownCount = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(30, 33);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Медикамент";
            // 
            // comboBoxMedicament
            // 
            comboBoxMedicament.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxMedicament.FormattingEnabled = true;
            comboBoxMedicament.Location = new Point(173, 33);
            comboBoxMedicament.Name = "comboBoxMedicament";
            comboBoxMedicament.Size = new Size(187, 23);
            comboBoxMedicament.TabIndex = 1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(30, 73);
            label2.Name = "label2";
            label2.Size = new Size(66, 15);
            label2.TabIndex = 2;
            label2.Text = "Работники";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(30, 112);
            label3.Name = "label3";
            label3.Size = new Size(54, 15);
            label3.TabIndex = 3;
            label3.Text = "Пациент";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(12, 151);
            label4.Name = "label4";
            label4.Size = new Size(155, 15);
            label4.TabIndex = 4;
            label4.Text = "Количество медикаментов";
            // 
            // comboBoxEmoloyee
            // 
            comboBoxEmoloyee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmoloyee.FormattingEnabled = true;
            comboBoxEmoloyee.Location = new Point(173, 70);
            comboBoxEmoloyee.Name = "comboBoxEmoloyee";
            comboBoxEmoloyee.Size = new Size(187, 23);
            comboBoxEmoloyee.TabIndex = 5;
            // 
            // comboBoxPacient
            // 
            comboBoxPacient.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPacient.FormattingEnabled = true;
            comboBoxPacient.Location = new Point(173, 109);
            comboBoxPacient.Name = "comboBoxPacient";
            comboBoxPacient.Size = new Size(187, 23);
            comboBoxPacient.TabIndex = 6;
            // 
            // numericUpDownCount
            // 
            numericUpDownCount.Location = new Point(173, 149);
            numericUpDownCount.Name = "numericUpDownCount";
            numericUpDownCount.Size = new Size(187, 23);
            numericUpDownCount.TabIndex = 8;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(186, 199);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(285, 199);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormHealingPacient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(411, 267);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownCount);
            Controls.Add(comboBoxPacient);
            Controls.Add(comboBoxEmoloyee);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(comboBoxMedicament);
            Controls.Add(label1);
            Name = "FormHealingPacient";
            Text = "v";
            ((System.ComponentModel.ISupportInitialize)numericUpDownCount).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox comboBoxMedicament;
        private Label label2;
        private Label label3;
        private Label label4;
        private ComboBox comboBoxEmoloyee;
        private ComboBox comboBoxPacient;
        private NumericUpDown numericUpDownCount;
        private Button buttonSave;
        private Button buttonCancel;
    }
}