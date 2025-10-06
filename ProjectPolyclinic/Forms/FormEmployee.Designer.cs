namespace ProjectPolyclinic.Forms
{
    partial class FormEmployee
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
            comboBoxPost = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBoxFirstName = new TextBox();
            textBoxLastName = new TextBox();
            buttonSave = new Button();
            buttonCancel = new Button();
            SuspendLayout();
            // 
            // comboBoxPost
            // 
            comboBoxPost.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxPost.FormattingEnabled = true;
            comboBoxPost.Location = new Point(102, 101);
            comboBoxPost.Name = "comboBoxPost";
            comboBoxPost.Size = new Size(260, 23);
            comboBoxPost.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 34);
            label1.Name = "label1";
            label1.Size = new Size(31, 15);
            label1.TabIndex = 1;
            label1.Text = "Имя";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(27, 68);
            label2.Name = "label2";
            label2.Size = new Size(58, 15);
            label2.TabIndex = 2;
            label2.Text = "Фамилия";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(27, 104);
            label3.Name = "label3";
            label3.Size = new Size(69, 15);
            label3.TabIndex = 3;
            label3.Text = "Должность";
            // 
            // textBoxFirstName
            // 
            textBoxFirstName.Location = new Point(102, 31);
            textBoxFirstName.Name = "textBoxFirstName";
            textBoxFirstName.Size = new Size(260, 23);
            textBoxFirstName.TabIndex = 4;
            // 
            // textBoxLastName
            // 
            textBoxLastName.Location = new Point(102, 68);
            textBoxLastName.Name = "textBoxLastName";
            textBoxLastName.Size = new Size(260, 23);
            textBoxLastName.TabIndex = 5;
            // 
            // buttonSave
            // 
            buttonSave.Location = new Point(102, 171);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(87, 23);
            buttonSave.TabIndex = 6;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += ButtonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Location = new Point(245, 171);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(87, 23);
            buttonCancel.TabIndex = 7;
            buttonCancel.Text = "Отменить";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += ButtonCancel_Click;
            // 
            // FormEmployee
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(405, 266);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(textBoxLastName);
            Controls.Add(textBoxFirstName);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxPost);
            Name = "FormEmployee";
            Text = "Сотрудник";
            Load += FormEmployee_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxPost;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBoxFirstName;
        private TextBox textBoxLastName;
        private Button buttonSave;
        private Button buttonCancel;
    }
}