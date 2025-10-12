using ProjectPolyclinic.Reports;
using ProjectPolyclinic.Repositories;
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
    public partial class FormMedicineReport : Form
    {
        private readonly IUnityContainer _container;

        public FormMedicineReport(IUnityContainer container, IMedicineRepository medicineRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            comboBoxMedicine.DataSource = medicineRepository.ReadMedicines();
            comboBoxMedicine.DisplayMember = "Name";
            comboBoxMedicine.ValueMember = "Id";
        }

        private void buttonMakeReport_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFilePath.Text))
                {
                    throw new Exception("Отсутствует имя файла для отчета");
                }
                if (comboBoxMedicine.SelectedIndex < 0)
                {
                    throw new Exception("Не выбран медикамент");
                }
                if (dateTimePickerDateEnd.Value <= dateTimePickerDateBegin.Value)
                {
                    throw new Exception("Дата начала должна быть раньше даты окончания");
                }
                if (_container.Resolve<TableReport>().CreateTable(textBoxFilePath.Text,
                (int)comboBoxMedicine.SelectedValue!,
                dateTimePickerDateBegin.Value, dateTimePickerDateEnd.Value))
                {
                    MessageBox.Show("Документ сформирован", "Формирование документа",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Возникли ошибки при формировании документа.Подробности в логах", "Формирование документа",
                    MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при создании очета",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonSelectFilePath_Click(object sender, EventArgs e)
        {
            var sfd = new SaveFileDialog()
            {
                Filter = "Excel Files | *.xlsx"
            };
            if (sfd.ShowDialog() != DialogResult.OK)
            {
                return;
            }
            textBoxFilePath.Text = sfd.FileName;
        }
    }
}
