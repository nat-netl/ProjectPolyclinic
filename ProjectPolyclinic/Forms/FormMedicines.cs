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
using System.Xml.Linq;
using Unity;

namespace ProjectPolyclinic.Forms
{
    public partial class FormMedicines : Form
    {
        private readonly IUnityContainer _container;
        private readonly IMedicineRepository _medicineRepository;

        public FormMedicines(IUnityContainer container, IMedicineRepository medicineRepository)
        {
            InitializeComponent();
            _container = container ?? throw new ArgumentNullException(nameof(container));
            _medicineRepository = medicineRepository ?? throw new ArgumentNullException(nameof(medicineRepository));
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void FormPacients_Load(object sender, EventArgs e)
        {
            try
            {
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при загрузке",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            try
            {
                _container.Resolve<FormMedicine>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void buttonUpdate_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId))
            {
                return;
            }
            try
            {
                var form = _container.Resolve<FormMedicine>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId))
            {
                return;
            }
            if (MessageBox.Show("Удалить запись?", "Удаление",
            MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _medicineRepository.DeleteMedicine(findId);
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadList() => dataGridView.DataSource =
        _medicineRepository.ReadMedicines();


        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;

            if (dataGridView.SelectedRows.Count< 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}
