using Microsoft.VisualBasic.FileIO;
using ProjectPolyclinic.Entities;
using ProjectPolyclinic.Entities.Enums;
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
    public partial class FormMedicine : Form
    {
        private readonly IMedicineRepository _medicineRepository;
        private int? _medicineId;

        public int Id
        {
            set
            {
                try
                {
                    var medicine = _medicineRepository.ReadMedicineById(value);
                    if (medicine == null)
                    {
                        throw new
                        InvalidDataException(nameof(medicine));
                    }
                    foreach (MedicineType elem in
                    Enum.GetValues(typeof(MedicineType)))
                    {
                        if ((elem & medicine.MedicineType) != 0)
                        {
                            checkedListBoxTypes.SetItemChecked(checkedListBoxTypes.Items.IndexOf(
                            elem), true);
                        }
                    }
                    textBoxName.Text = medicine.Name;
                    richTextBoxDescription.Text = medicine.Description;
                    _medicineId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
                }
            }
            }


        public FormMedicine(IMedicineRepository medicineRepository)
        {
            InitializeComponent();
            _medicineRepository = medicineRepository ??
            throw new ArgumentNullException(nameof(medicineRepository));
            foreach (var elem in Enum.GetValues(typeof(MedicineType)))
            {
                checkedListBoxTypes.Items.Add(elem);
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxName.Text) ||
                string.IsNullOrWhiteSpace(richTextBoxDescription.Text) ||
                checkedListBoxTypes.CheckedItems.Count == 0)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_medicineId.HasValue)
                {
                    _medicineRepository.UpdateMedicine(CreateMedicine(_medicineId.Value));
                }
                else
                {
                    _medicineRepository.CreateMedicine(CreateMedicine(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e) => Close();

        private Medicine CreateMedicine(int id)
        {
            MedicineType medicineType = MedicineType.None;
            foreach (var elem in checkedListBoxTypes.CheckedItems)
            {
                medicineType |= (MedicineType)elem;
            }
            return Medicine.CreateEntity(id, medicineType, textBoxName.Text,
            richTextBoxDescription.Text);
        }

    }
}
