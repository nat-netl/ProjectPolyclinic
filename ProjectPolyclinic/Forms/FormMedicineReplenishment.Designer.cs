namespace ProjectPolyclinic.Forms
{
    partial class FormMedicineReplenishment
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
            comboBoxEmoloyee = new ComboBox();
            label2 = new Label();
            groupBoxMedicine = new GroupBox();
            dataGridViewMedicine = new DataGridView();
            ColumnMedicine = new DataGridViewComboBoxColumn();
            ColumnCount = new DataGridViewTextBoxColumn();
            buttonSave = new Button();
            buttonCancel = new Button();
            groupBoxMedicine.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).BeginInit();
            SuspendLayout();
            // 
            // comboBoxEmoloyee
            // 
            comboBoxEmoloyee.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBoxEmoloyee.FormattingEnabled = true;
            comboBoxEmoloyee.Location = new Point(117, 40);
            comboBoxEmoloyee.Name = "comboBoxEmoloyee";
            comboBoxEmoloyee.Size = new Size(151, 23);
            comboBoxEmoloyee.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(22, 43);
            label2.Name = "label2";
            label2.Size = new Size(59, 15);
            label2.TabIndex = 6;
            label2.Text = "Работник";
            // 
            // groupBoxMedicine
            // 
            groupBoxMedicine.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            groupBoxMedicine.Controls.Add(dataGridViewMedicine);
            groupBoxMedicine.Location = new Point(22, 87);
            groupBoxMedicine.Name = "groupBoxMedicine";
            groupBoxMedicine.Size = new Size(251, 237);
            groupBoxMedicine.TabIndex = 8;
            groupBoxMedicine.TabStop = false;
            groupBoxMedicine.Text = "Медикаменты";
            // 
            // dataGridViewMedicine
            // 
            dataGridViewMedicine.AllowUserToResizeColumns = false;
            dataGridViewMedicine.AllowUserToResizeRows = false;
            dataGridViewMedicine.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewMedicine.Columns.AddRange(new DataGridViewColumn[] { ColumnMedicine, ColumnCount });
            dataGridViewMedicine.Dock = DockStyle.Fill;
            dataGridViewMedicine.Location = new Point(3, 19);
            dataGridViewMedicine.MultiSelect = false;
            dataGridViewMedicine.Name = "dataGridViewMedicine";
            dataGridViewMedicine.RowHeadersVisible = false;
            dataGridViewMedicine.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewMedicine.Size = new Size(245, 215);
            dataGridViewMedicine.TabIndex = 9;
            // 
            // ColumnMedicine
            // 
            ColumnMedicine.HeaderText = "Медикамент";
            ColumnMedicine.Name = "ColumnMedicine";
            // 
            // ColumnCount
            // 
            ColumnCount.HeaderText = "Количество";
            ColumnCount.Name = "ColumnCount";
            // 
            // buttonSave
            // 
            buttonSave.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            buttonSave.Location = new Point(36, 349);
            buttonSave.Name = "buttonSave";
            buttonSave.Size = new Size(75, 23);
            buttonSave.TabIndex = 9;
            buttonSave.Text = "Сохранить";
            buttonSave.UseVisualStyleBackColor = true;
            buttonSave.Click += buttonSave_Click;
            // 
            // buttonCancel
            // 
            buttonCancel.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
            buttonCancel.Location = new Point(180, 349);
            buttonCancel.Name = "buttonCancel";
            buttonCancel.Size = new Size(75, 23);
            buttonCancel.TabIndex = 10;
            buttonCancel.Text = "Отмена";
            buttonCancel.UseVisualStyleBackColor = true;
            buttonCancel.Click += buttonCancel_Click;
            // 
            // FormMedicineReplenishment
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(296, 428);
            Controls.Add(buttonCancel);
            Controls.Add(buttonSave);
            Controls.Add(groupBoxMedicine);
            Controls.Add(comboBoxEmoloyee);
            Controls.Add(label2);
            Name = "FormMedicineReplenishment";
            Text = "FormMedicineReplenishment";
            Load += FormMedicineReplenishment_Load;
            groupBoxMedicine.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewMedicine).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxEmoloyee;
        private Label label2;
        private GroupBox groupBoxMedicine;
        private DataGridView dataGridViewMedicine;
        private Button buttonSave;
        private Button buttonCancel;
        private DataGridViewComboBoxColumn ColumnMedicine;
        private DataGridViewTextBoxColumn ColumnCount;
    }
}