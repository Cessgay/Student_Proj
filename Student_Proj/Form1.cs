using System;
using System.Collections.Generic;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Student_Proj
{
    public partial class StudentForm : XtraForm
    {
        private List<Student> students = new List<Student>(); // Corrected list name

        public StudentForm()
        {
            InitializeComponent(); // Ensuring UI components are initialized
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Create new student object
            Student newStudent = new Student
            {
                FirstName = teFirstName.Text,
                LastName = teLastName.Text,
                Age = teAge.Text,
                PhoneNumber = tePhoneNumber.Text,
                Address = teAddress.Text
            };

            // add new student object to the list
            students.Add(newStudent);

            // Set the grid control's data source
            gridControl1.DataSource = null;  // Clear previous binding
            gridControl1.DataSource = students;

            // e ang clear ang textboxes
            teFirstName.Text = "";
            teLastName.Text = "";
            teAge.Text = "";
            tePhoneNumber.Text = "";
            teAddress.Text = "";

            // para mo refresh grid control everytime naay add 
            gridControl1.RefreshDataSource();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected row indexzzz
            int selectedRowHandle = gridView1.FocusedRowHandle;

            if (selectedRowHandle >= 0) // Check if a row is selectedd
            {
                // Remove selected student from the list
                students.RemoveAt(selectedRowHandle);

                // Refresh GridControl
                gridControl1.DataSource = null;
                gridControl1.DataSource = students;
                gridControl1.RefreshDataSource();
            }
            else
            {
                XtraMessageBox.Show("Please select a student to delete.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
    }

}
