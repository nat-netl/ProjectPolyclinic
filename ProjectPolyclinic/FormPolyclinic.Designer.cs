namespace ProjectPolyclinic
{
    partial class FormPolyclinic
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            menuStrip = new MenuStrip();
            спарвочникиToolStripMenuItem = new ToolStripMenuItem();
            EmployeesToolStripMenuItem = new ToolStripMenuItem();
            PacientsToolStripMenuItem = new ToolStripMenuItem();
            MedicamentsToolStripMenuItem = new ToolStripMenuItem();
            операцииToolStripMenuItem = new ToolStripMenuItem();
            GiveMedicamentsToolStripMenuItem = new ToolStripMenuItem();
            ReplanishmentMedicamentsToolStripMenuItem = new ToolStripMenuItem();
            отчетыToolStripMenuItem = new ToolStripMenuItem();
            menuStrip.SuspendLayout();
            SuspendLayout();
            // 
            // menuStrip
            // 
            menuStrip.Items.AddRange(new ToolStripItem[] { спарвочникиToolStripMenuItem, операцииToolStripMenuItem, отчетыToolStripMenuItem });
            menuStrip.Location = new Point(0, 0);
            menuStrip.Name = "menuStrip";
            menuStrip.Size = new Size(784, 24);
            menuStrip.TabIndex = 0;
            menuStrip.Text = "menuStrip1";
            // 
            // спарвочникиToolStripMenuItem
            // 
            спарвочникиToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { EmployeesToolStripMenuItem, PacientsToolStripMenuItem, MedicamentsToolStripMenuItem });
            спарвочникиToolStripMenuItem.Name = "спарвочникиToolStripMenuItem";
            спарвочникиToolStripMenuItem.Size = new Size(94, 20);
            спарвочникиToolStripMenuItem.Text = "Спарвочники";
            // 
            // EmployeesToolStripMenuItem
            // 
            EmployeesToolStripMenuItem.Name = "EmployeesToolStripMenuItem";
            EmployeesToolStripMenuItem.Size = new Size(152, 22);
            EmployeesToolStripMenuItem.Text = "Доктора";
            EmployeesToolStripMenuItem.Click += EmployeesToolStripMenuItem_Click;
            // 
            // PacientsToolStripMenuItem
            // 
            PacientsToolStripMenuItem.Name = "PacientsToolStripMenuItem";
            PacientsToolStripMenuItem.Size = new Size(152, 22);
            PacientsToolStripMenuItem.Text = "Пациенты";
            PacientsToolStripMenuItem.Click += PacientsToolStripMenuItem_Click;
            // 
            // MedicamentsToolStripMenuItem
            // 
            MedicamentsToolStripMenuItem.Name = "MedicamentsToolStripMenuItem";
            MedicamentsToolStripMenuItem.Size = new Size(152, 22);
            MedicamentsToolStripMenuItem.Text = "Медикаменты";
            MedicamentsToolStripMenuItem.Click += MedicamentsToolStripMenuItem_Click;
            // 
            // операцииToolStripMenuItem
            // 
            операцииToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { GiveMedicamentsToolStripMenuItem, ReplanishmentMedicamentsToolStripMenuItem });
            операцииToolStripMenuItem.Name = "операцииToolStripMenuItem";
            операцииToolStripMenuItem.Size = new Size(75, 20);
            операцииToolStripMenuItem.Text = "Операции";
            // 
            // GiveMedicamentsToolStripMenuItem
            // 
            GiveMedicamentsToolStripMenuItem.Name = "GiveMedicamentsToolStripMenuItem";
            GiveMedicamentsToolStripMenuItem.Size = new Size(227, 22);
            GiveMedicamentsToolStripMenuItem.Text = "Выданные медикаменты";
            GiveMedicamentsToolStripMenuItem.Click += GiveMedicamentsToolStripMenuItem_Click;
            // 
            // ReplanishmentMedicamentsToolStripMenuItem
            // 
            ReplanishmentMedicamentsToolStripMenuItem.Name = "ReplanishmentMedicamentsToolStripMenuItem";
            ReplanishmentMedicamentsToolStripMenuItem.Size = new Size(227, 22);
            ReplanishmentMedicamentsToolStripMenuItem.Text = "Пополнение медикаментов";
            ReplanishmentMedicamentsToolStripMenuItem.Click += ReplanishmentMedicamentsToolStripMenuItem_Click;
            // 
            // отчетыToolStripMenuItem
            // 
            отчетыToolStripMenuItem.Name = "отчетыToolStripMenuItem";
            отчетыToolStripMenuItem.Size = new Size(60, 20);
            отчетыToolStripMenuItem.Text = "Отчеты";
            // 
            // FormPolyclinic
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(784, 411);
            Controls.Add(menuStrip);
            MainMenuStrip = menuStrip;
            Name = "FormPolyclinic";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Поликлиника";
            Load += FormPolyclinic_Load;
            menuStrip.ResumeLayout(false);
            menuStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MenuStrip menuStrip;
        private ToolStripMenuItem спарвочникиToolStripMenuItem;
        private ToolStripMenuItem EmployeesToolStripMenuItem;
        private ToolStripMenuItem PacientsToolStripMenuItem;
        private ToolStripMenuItem MedicamentsToolStripMenuItem;
        private ToolStripMenuItem операцииToolStripMenuItem;
        private ToolStripMenuItem GiveMedicamentsToolStripMenuItem;
        private ToolStripMenuItem ReplanishmentMedicamentsToolStripMenuItem;
        private ToolStripMenuItem отчетыToolStripMenuItem;
    }
}
