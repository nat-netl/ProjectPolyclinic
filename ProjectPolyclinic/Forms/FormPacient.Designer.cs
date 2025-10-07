using ProjectPolyclinic.Repositories;

namespace ProjectPolyclinic.Forms
{
    public partial class FormPacient : Form
    {
        private System.ComponentModel.IContainer components = null;

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
            textBoxPacientName = new TextBox();
            label2 = new Label();
            textBoxPacientDisease = new TextBox();
            label3 = new Label();
            numericUpDownAge = new NumericUpDown();
            buttonSave = new Button();
            buttonCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(34, 36);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 0;
            label1.Text = "Имя";
            label1.Click += label1_Click;
            // 
            // textBoxPacientName
            // 
            textBoxPacientName.Location = new Point(115, 33);
            textBoxPacientName.Name = "textBoxPacientName";
            textBoxPacientName.Size = new Size(230, 23);
            textBoxPacientName.TabIndex = 1;
            textBoxPacientName.TextChanged += textBox1_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(34, 87);
            label2.Name = "label2";
            label2.Size = new Size(52, 15);
            label2.TabIndex = 2;
            label2.Text = "Болезнь";
            // 
            // textBoxPacientDisease
            // 
            textBoxPacientDisease.Location = new Point(115, 84);
            textBoxPacientDisease.Name = "textBoxPacientDisease";
            textBoxPacientDisease.Size = new Size(230, 23);
            textBoxPacientDisease.TabIndex = 3;
            textBoxPacientDisease.TextChanged += textBoxPacientDisease_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(34, 136);
            label3.Name = "label3";
            label3.Size = new Size(50, 15);
            label3.TabIndex = 5;
            label3.Text = "Возраст";
            // 
            // numericUpDownAge
            // 
            numericUpDownAge.Location = new Point(115, 134);
            numericUpDownAge.Name = "numericUpDownAge";
            numericUpDownAge.Size = new Size(120, 23);
            numericUpDownAge.TabIndex = 6;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(51, 201);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(184, 201);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormPacient
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(376, 283);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(numericUpDownAge);
            Controls.Add(label3);
            Controls.Add(textBoxPacientDisease);
            Controls.Add(label2);
            Controls.Add(textBoxPacientName);
            Controls.Add(label1);
            Name = "FormPacient";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Пациент";
            Load += FormPacients_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDownAge).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox textBoxPacientName;
        private Label label2;
        private TextBox textBoxPacientDisease;
        private Label label3;
        private NumericUpDown numericUpDownAge;
        private Button buttonSave;
        private Button buttonCancel;
    }
}