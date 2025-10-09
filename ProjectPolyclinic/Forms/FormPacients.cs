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
    public partial class FormPacients : Form
    {
        private readonly IUnityContainer _container;
        private readonly IPacientRepository _pacientRepository;

        public FormPacients(IUnityContainer container, IPacientRepository pacientRepository)
        {
            InitializeComponent();
            _container = container ??
            throw new ArgumentNullException(nameof(container));
            _pacientRepository = pacientRepository ??
            throw new ArgumentNullException(nameof(pacientRepository));
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
                _container.Resolve<FormPacient>().ShowDialog();
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
                var form = _container.Resolve<FormPacient>();
                form.Id = findId;
                form.ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при изменении", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            if (!TryGetIdentifierFromSelectedRow(out var findId))
            {
                return;
            }
            if (MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.YesNo) != DialogResult.Yes)
            {
                return;
            }
            try
            {
                _pacientRepository.DeletePacient(findId);
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при удалении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void LoadList() => dataGridView.DataSource = _pacientRepository.ReadPacients();

        
        private bool TryGetIdentifierFromSelectedRow(out int id)
        {
            id = 0;
            if (dataGridView.SelectedRows.Count < 1)
            {
                MessageBox.Show("Нет выбранной записи", "Ошибка",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            id = Convert.ToInt32(dataGridView.SelectedRows[0].Cells["Id"].Value);
            return true;
        }
    }
}
