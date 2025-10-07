namespace ProjectPolyclinic.Forms
{
    partial class FormMedicine
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
            checkedListBoxTypes = new CheckedListBox();
            label1 = new Label();
            textBoxName = new TextBox();
            label2 = new Label();
            label3 = new Label();
            richTextBoxDescription = new RichTextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // checkedListBoxTypes
            // 
            checkedListBoxTypes.FormattingEnabled = true;
            checkedListBoxTypes.Location = new Point(146, 25);
            checkedListBoxTypes.Name = "checkedListBoxTypes";
            checkedListBoxTypes.Size = new Size(223, 94);
            checkedListBoxTypes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 25);
            label1.Name = "label1";
            label1.Size = new Size(119, 15);
            label1.TabIndex = 2;
            label1.Text = "Типы медикаментов";
            // 
            // textBoxName
            // 
            textBoxName.Location = new Point(146, 143);
            textBoxName.Name = "textBoxName";
            textBoxName.Size = new Size(223, 23);
            textBoxName.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(72, 146);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 4;
            label2.Text = "Название";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(72, 191);
            label3.Name = "label3";
            label3.Size = new Size(62, 15);
            label3.TabIndex = 5;
            label3.Text = "Описание";
            // 
            // richTextBoxDescription
            // 
            richTextBoxDescription.Location = new Point(146, 191);
            richTextBoxDescription.Name = "richTextBoxDescription";
            richTextBoxDescription.Size = new Size(223, 155);
            richTextBoxDescription.TabIndex = 6;
            richTextBoxDescription.Text = "";
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(157, 374);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 7;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(274, 374);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 8;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormMedicine
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(442, 442);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(richTextBoxDescription);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(textBoxName);
            Controls.Add(label1);
            Controls.Add(checkedListBoxTypes);
            Name = "FormMedicine";
            Text = "v";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private CheckedListBox checkedListBoxTypes;
        private Label label1;
        private TextBox textBoxName;
        private Label label2;
        private Label label3;
        private RichTextBox richTextBoxDescription;
        private Button buttonSave;
        private Button buttonCancel;
    }
}