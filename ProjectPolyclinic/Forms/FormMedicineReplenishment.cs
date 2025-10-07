using ProjectPolyclinic.Entities;
using ProjectPolyclinic.Repositories;
using ProjectPolyclinic.Repositories.Implementations;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProjectPolyclinic.Forms
{
    public partial class FormMedicineReplenishment : Form
    {
        private readonly IMedicineReplenishmentRepository _medicineReplenishmentRepository;

        public FormMedicineReplenishment(IMedicineReplenishmentRepository medicineReplenishmentRepository,
        IEmployeeRepository employeeRepository,
        IMedicineRepository medicineRepository)
        {
            InitializeComponent();
            _medicineReplenishmentRepository = medicineReplenishmentRepository ??
                throw new ArgumentNullException(nameof(medicineReplenishmentRepository));

            comboBoxEmoloyee.DataSource = employeeRepository.ReadEmployees();
            comboBoxEmoloyee.DisplayMember = "FirstName";
            comboBoxEmoloyee.ValueMember = "Id";
            ColumnMedicine.DataSource = medicineRepository.ReadMedicines();
            ColumnMedicine.DisplayMember = "Name";
            ColumnMedicine.ValueMember = "Id";
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (dataGridViewMedicine.RowCount < 1 ||
                comboBoxEmoloyee.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                _medicineReplenishmentRepository.CreateMedicineReplenishment(MedicineReplenishment.CreateOperation(0,
                (int)comboBoxEmoloyee.SelectedValue!,
                CreateListMedicineMedicineReplenishmentsFromDataGrid()));

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private List<MedicineMedicineReplenishment>
        CreateListMedicineMedicineReplenishmentsFromDataGrid()
        {
            var list = new List<MedicineMedicineReplenishment>();
            foreach (DataGridViewRow row in dataGridViewMedicine.Rows)
            {
                if (row.Cells["ColumnMedicine"].Value == null ||
                row.Cells["ColumnCount"].Value == null)
                {
                    continue;
                }
                list.Add(MedicineMedicineReplenishment.CreateElement(0,
                Convert.ToInt32(row.Cells["ColumnMedicine"].Value),
                Convert.ToInt32(row.Cells["ColumnCount"].Value)));
            }
            return list;
        }

        private void FormMedicineReplenishment_Load(object sender, EventArgs e)
        {

        }
    }
}
