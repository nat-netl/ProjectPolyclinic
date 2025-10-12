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
    public partial class FormHealingPacientDistributionReport : Form
    {
        private string _fileName = string.Empty;
        private readonly IUnityContainer _container;

        public FormHealingPacientDistributionReport(IUnityContainer container)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
        }

        private void buttonSelectFileName_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Pdf Files | *.pdf"
            };
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                _fileName = sfd.FileName;
                labelFileName.Text = Path.GetFileName(_fileName);
            }
        }

        private void buttonCreate_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(_fileName))
                {
                    throw new Exception("Отсутствует имя файла для отчета");
                }
                if (_container.Resolve<ChartReport>().CreateChart(_fileName, dateTimePicker.Value))
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
                MessageBox.Show(ex.Message, "Ошибка при создании очета",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
