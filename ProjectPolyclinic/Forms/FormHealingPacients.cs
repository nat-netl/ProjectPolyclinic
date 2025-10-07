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
using System.Xml.Linq;
using Unity;

namespace ProjectPolyclinic.Forms
{
    public partial class FormHealingPacients : Form
    {
        private readonly IUnityContainer _container;
        private readonly IHealingPacientRepository _healingPacientRepository;


        public FormHealingPacients(IUnityContainer container, IHealingPacientRepository healingPacientRepository)
        {
            InitializeComponent();
            _container = container ??
            throw new ArgumentNullException(nameof(container));
            _healingPacientRepository = healingPacientRepository ??
            throw new
            ArgumentNullException(nameof(healingPacientRepository));
        }

        private void FormHealingPacients_Load(object sender, EventArgs e)
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
                _container.Resolve<FormHealingPacient>().ShowDialog();
                LoadList();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при добавлении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadList() => dataGridView.DataSource = _healingPacientRepository.ReadHealingPacient();


    }
}
