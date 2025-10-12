using ProjectPolyclinic.Reports;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Unity;

namespace ProjectPolyclinic.Forms
{
    public partial class FormDirectoryReport : Form
    {
        private readonly IUnityContainer _container;
        public FormDirectoryReport(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ??
            throw new ArgumentNullException(nameof(container));
        }


        private void buttonBuild_Click(object sender, EventArgs e)
        {
            try
            {
                if (!checkBoxPacients.Checked &&
                !checkBoxEmployees.Checked && !checkBoxMedicines.Checked)
                {
                    throw new Exception("Не выбран ни один справочник для выгрузки");
                }
                var sfd = new SaveFileDialog()
                {
                    Filter = "Docx Files | *.docx"
                };
                if (sfd.ShowDialog() != DialogResult.OK)
                {
                    throw new Exception("Не выбран файла для отчета");
                }
                if
                (_container.Resolve<DocReport>().CreateDoc(sfd.FileName, checkBoxPacients.Checked,
                checkBoxEmployees.Checked, checkBoxMedicines.Checked))
                {
                    MessageBox.Show("Документ сформирован",
                    "Формирование документа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Возникли ошибки при формировании документа.Подробности в логах",
                    "Формирование документа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при создании отчета", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
