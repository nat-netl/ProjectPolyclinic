using ProjectPolyclinic.Entities;
using ProjectPolyclinic.Entities.Enums;
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
    public partial class FormEmployee : Form
    {
        private readonly IEmployeeRepository _employeeRepository;
        private int? _employeeId;

        public int Id
        {
            set
            {
                try
                {
                    var employee =
                    _employeeRepository.ReadEmployeeById(value);
                    if (employee == null)
                    {
                        throw new
                        InvalidDataException(nameof(employee));
                    }
                    textBoxFirstName.Text = employee.FirstName;
                    textBoxLastName.Text = employee.LastName;
                    comboBoxPost.SelectedItem =
                    employee.EmployeePost;
                    _employeeId = value;
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message, "Ошибка при получении данных", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
        }

        public FormEmployee(IEmployeeRepository employeeRepository)
        {
            InitializeComponent();
            _employeeRepository = employeeRepository ??
            throw new ArgumentNullException(nameof(employeeRepository));
            comboBoxPost.DataSource = Enum.GetValues(typeof(EmployeePost));

        }

        private void ButtonSave_Click(object sender, EventArgs e)
        {
            try
            {
                if (string.IsNullOrWhiteSpace(textBoxFirstName.Text) ||
                string.IsNullOrWhiteSpace(textBoxLastName.Text)
                ||
                comboBoxPost.SelectedIndex < 1)
                {
                    throw new Exception("Имеются незаполненные поля");
                }
                if (_employeeId.HasValue)
                {
                    _employeeRepository.UpdateEmployee(CreateEmployee(_employeeId.Value));
                }
                else
                {
                    _employeeRepository.CreateEmployee(CreateEmployee(0));
                }
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Ошибка при сохранении",
                MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void ButtonCancel_Click(object sender, EventArgs e) => Close();

        private Employee CreateEmployee(int id) => 
            Employee.CreateEntity(id, textBoxFirstName.Text,textBoxLastName.Text, (EmployeePost)comboBoxPost.SelectedItem!);

        private void FormEmployee_Load(object sender, EventArgs e)
        {

        }
    }
}
