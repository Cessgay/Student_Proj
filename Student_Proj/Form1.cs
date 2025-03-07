using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using DevExpress.XtraGrid.Views.Grid;

namespace Student_Proj
{
    public partial class StudentForm : XtraForm
    {
        private List<Student> students = new List<Student>();

        public StudentForm()
        {
            InitializeComponent();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                string.IsNullOrWhiteSpace(teLastName.Text) ||
                string.IsNullOrWhiteSpace(teAge.Text) ||
                string.IsNullOrWhiteSpace(tePhoneNumber.Text) ||
                string.IsNullOrWhiteSpace(teAddress.Text))
            {
                XtraMessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(teAge.Text, out int age))
            {
                XtraMessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Student newStudent = new Student
            {
                FirstName = teFirstName.Text,
                LastName = teLastName.Text,
                Age = teAge.Text,
                PhoneNumber = tePhoneNumber.Text,
                Address = teAddress.Text
            };

            students.Add(newStudent);
            RefreshGrid();
            ClearInputs();
        }

       

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            int selectedRow = gridView1.FocusedRowHandle;
            if (selectedRow >= 0)
            {
                if (string.IsNullOrWhiteSpace(teFirstName.Text) ||
                    string.IsNullOrWhiteSpace(teLastName.Text) ||
                    string.IsNullOrWhiteSpace(teAge.Text) ||
                    string.IsNullOrWhiteSpace(tePhoneNumber.Text) ||
                    string.IsNullOrWhiteSpace(teAddress.Text))
                {
                    XtraMessageBox.Show("All fields are required.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                if (!int.TryParse(teAge.Text, out int age))
                {
                    XtraMessageBox.Show("Please enter a valid age.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                Student student = students[selectedRow];

                if (students.Any(s => s.FirstName.Equals(teFirstName.Text, StringComparison.OrdinalIgnoreCase) &&
                                      s.LastName.Equals(teLastName.Text, StringComparison.OrdinalIgnoreCase) &&
                                      s != student))
                {
                    XtraMessageBox.Show("A student with the same name already exists!", "Duplicate Entry", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    return;
                }

                DialogResult result = XtraMessageBox.Show("Are you sure you want to update this student's information?",
                    "Confirm Update", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (result == DialogResult.Yes)
                {
                    student.FirstName = teFirstName.Text;
                    student.LastName = teLastName.Text;
                    student.Age = teAge.Text;
                    student.PhoneNumber = tePhoneNumber.Text;
                    student.Address = teAddress.Text;

                    RefreshGrid();
                    ClearInputs();
                }
            }
            else
            {
                XtraMessageBox.Show("No student selected for updating.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void RefreshGrid()
        {
            gridControl1.DataSource = null;
            gridControl1.DataSource = students;
            gridControl1.RefreshDataSource();
        }

        private void ClearInputs()
        {
            teFirstName.Text = "";
            teLastName.Text = "";
            teAge.Text = "";
            tePhoneNumber.Text = "";
            teAddress.Text = "";
        }

        private void btnDelete_Click_1(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("Are you sure you want to delete this record?",
                       "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (result == DialogResult.Yes)
            {
                int selectedRowHandle = gridView1.FocusedRowHandle;

                if (selectedRowHandle >= 0)
                {
                    Student selectedStudent = gridView1.GetRow(selectedRowHandle) as Student;
                    if (selectedStudent != null)
                    {

                        students.Remove(selectedStudent);
                        RefreshGrid();
                        XtraMessageBox.Show("Record deleted successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        ClearInputs();
                    }
                }
            }
            else
            {
                XtraMessageBox.Show("Please select a student to delete.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }


}

