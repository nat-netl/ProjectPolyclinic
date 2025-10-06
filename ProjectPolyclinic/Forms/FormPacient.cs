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
    public partial class FormPacient : Form
    {
        private readonly IPacientRepository _pacientRepository;
        private int? _pacientId;
        public int Id
        {
            set
            {
                try
                {
                    var pacient = _pacientRepository.ReadPacientById(value);
                    if (pacient == null)
                    {
                        throw new InvalidDataException(nameof(pacient));
                    }
                    textBoxPacientName.Text = pacient.PacientName;
                    textBoxPacientDisease.Text = pacient.PacientDisease;
                    numericUpDownAge.Value = pacient.Age;
                    _pacientId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при полученииданных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormPacient(IPacientRepository pacientRepository)
        {
            InitializeComponent();
            _pacientRepository = pacientRepository ?? throw new ArgumentNullException(nameof(pacientRepository));
        }


        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void FormPacients_Load(object sender, EventArgs e)
        {

        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxPacientName.Text)
                ||
                string.IsNullOrWhiteSpace(textBoxPacientDisease.Text))
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_pacientId.HasValue)
                {
                    _pacientRepository.UpdatePacient(CreatePacient(_pacientId.Value));
                }
                else
                {
                    _pacientRepository.CreatePacient(CreatePacient(0));
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

        private Pacient CreatePacient(int id) => Pacient.CreateEntity(id,
                                                textBoxPacientName.Text,
                                                textBoxPacientDisease.Text,
                                                Convert.ToInt32(numericUpDownAge.Value));

        private void textBoxPacientDisease_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
