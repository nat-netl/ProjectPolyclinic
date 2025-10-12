namespace ProjectPolyclinic.Forms
{
    partial class FormMedicineReport
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
            dateTimePickerDateBegin = new DateTimePicker();
            dateTimePickerDateEnd = new DateTimePicker();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            buttonMakeReport = new Button();
            openFileDialog1 = new OpenFileDialog();
            textBoxFilePath = new TextBox();
            buttonSelectFilePath = new Button();
            comboBoxMedicine = new ComboBox();
            SuspendLayout();
            // 
            // dateTimePickerDateBegin
            // 
            dateTimePickerDateBegin.Location = new Point(122, 116);
            dateTimePickerDateBegin.Name = "dateTimePickerDateBegin";
            dateTimePickerDateBegin.Size = new Size(217, 23);
            dateTimePickerDateBegin.TabIndex = 0;
            // 
            // dateTimePickerDateEnd
            // 
            dateTimePickerDateEnd.Location = new Point(122, 157);
            dateTimePickerDateEnd.Name = "dateTimePickerDateEnd";
            dateTimePickerDateEnd.Size = new Size(217, 23);
            dateTimePickerDateEnd.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(27, 39);
            label1.Name = "label1";
            label1.Size = new Size(87, 15);
            label1.TabIndex = 2;
            label1.Text = "Путь до файла";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(29, 80);
            label2.Name = "label2";
            label2.Size = new Size(85, 15);
            label2.TabIndex = 3;
            label2.Text = "Медикаменты";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(29, 122);
            label3.Name = "label3";
            label3.Size = new Size(74, 15);
            label3.TabIndex = 4;
            label3.Text = "Дата начала";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(29, 163);
            label4.Name = "label4";
            label4.Size = new Size(68, 15);
            label4.TabIndex = 5;
            label4.Text = "Дата конца";
            // 
            // buttonMakeReport
            // 
            buttonMakeReport.Location = new Point(149, 203);
            buttonMakeReport.Name = "buttonMakeReport";
            buttonMakeReport.Size = new Size(108, 23);
            buttonMakeReport.TabIndex = 6;
            buttonMakeReport.Text = "Сформировать";
            buttonMakeReport.UseVisualStyleBackColor = true;
            buttonMakeReport.Click += buttonMakeReport_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxFilePath
            // 
            textBoxFilePath.Location = new Point(122, 35);
            textBoxFilePath.Name = "textBoxFilePath";
            textBoxFilePath.Size = new Size(179, 23);
            textBoxFilePath.TabIndex = 7;
            // 
            // buttonSelectFilePath
            // 
            buttonSelectFilePath.Location = new Point(307, 34);
            buttonSelectFilePath.Name = "buttonSelectFilePath";
            buttonSelectFilePath.Size = new Size(32, 24);
            buttonSelectFilePath.TabIndex = 8;
            buttonSelectFilePath.Text = "...";
            buttonSelectFilePath.UseVisualStyleBackColor = true;
            buttonSelectFilePath.Click += buttonSelectFilePath_Click;
            // 
            // comboBoxMedicine
            // 
            comboBoxMedicine.FormattingEnabled = true;
            comboBoxMedicine.Location = new Point(122, 77);
            comboBoxMedicine.Name = "comboBoxMedicine";
            comboBoxMedicine.Size = new Size(217, 23);
            comboBoxMedicine.TabIndex = 9;
            // 
            // FormMedicineReport
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(387, 254);
            Controls.Add(comboBoxMedicine);
            Controls.Add(buttonSelectFilePath);
            Controls.Add(textBoxFilePath);
            Controls.Add(buttonMakeReport);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(dateTimePickerDateEnd);
            Controls.Add(dateTimePickerDateBegin);
            Name = "FormMedicineReport";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMedicineReport";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DateTimePicker dateTimePickerDateBegin;
        private DateTimePicker dateTimePickerDateEnd;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button buttonMakeReport;
        private OpenFileDialog openFileDialog1;
        private TextBox textBoxFilePath;
        private Button buttonSelectFilePath;
        private ComboBox comboBoxMedicine;
    }
}