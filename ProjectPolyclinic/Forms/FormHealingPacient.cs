using ProjectPolyclinic.Entities;
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

namespace ProjectPolyclinic.Forms
{
    public partial class FormHealingPacient : Form
    {
        private readonly IHealingPacientRepository _healingPacientRepository;

        public FormHealingPacient(IHealingPacientRepository healingPacientRepository,
                                    IMedicineRepository medicineRepository, 
                                    IEmployeeRepository employeeRepository,
                                    IPacientRepository pacientRepository)
        {
            InitializeComponent();
            _healingPacientRepository = healingPacientRepository ??
            throw new
            ArgumentNullException(nameof(healingPacientRepository));
            comboBoxEmoloyee.DataSource =
            employeeRepository.ReadEmployees();
            comboBoxEmoloyee.DisplayMember = "FirstName";
            comboBoxEmoloyee.ValueMember = "Id";
            comboBoxMedicament.DataSource = medicineRepository.ReadMedicines();
            comboBoxMedicament.DisplayMember = "Name";
            comboBoxMedicament.ValueMember = "Id";
            comboBoxPacient.DataSource = pacientRepository.ReadPacients();
            comboBoxPacient.DisplayMember = "AnimalNickName";
            comboBoxPacient.ValueMember = "Id";
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (comboBoxMedicament.SelectedIndex < 0 ||
                comboBoxEmoloyee.SelectedIndex < 0 ||
                comboBoxPacient.SelectedIndex < 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                _healingPacientRepository.CreateHealingPacient(HealingPacient.CreateOperation(
                0,
                (int)comboBoxMedicament.SelectedValue!,
                (int)comboBoxEmoloyee.SelectedValue!,
                (int)comboBoxPacient.SelectedValue!,
                Convert.ToInt32(numericUpDownCount.Value)));
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

    }
}
