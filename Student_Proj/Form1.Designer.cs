namespace Student_Proj
{
    partial class StudentForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gridControl1 = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.FirstName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.LastName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Age = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Birthdate = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Address = new DevExpress.XtraGrid.Columns.GridColumn();
            this.teFirstName = new DevExpress.XtraEditors.TextEdit();
            this.teLastName = new DevExpress.XtraEditors.TextEdit();
            this.teAge = new DevExpress.XtraEditors.TextEdit();
            this.tePhoneNumber = new DevExpress.XtraEditors.TextEdit();
            this.teAddress = new DevExpress.XtraEditors.TextEdit();
            this.btnAdd = new DevExpress.XtraEditors.SimpleButton();
            this.btnUpdate = new DevExpress.XtraEditors.SimpleButton();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.lcFirstName = new DevExpress.XtraEditors.LabelControl();
            this.lcLastName = new DevExpress.XtraEditors.LabelControl();
            this.lcAge = new DevExpress.XtraEditors.LabelControl();
            this.lcPhoneNumber = new DevExpress.XtraEditors.LabelControl();
            this.lcAddress = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // gridControl1
            // 
            this.gridControl1.Location = new System.Drawing.Point(517, 78);
            this.gridControl1.MainView = this.gridView1;
            this.gridControl1.Name = "gridControl1";
            this.gridControl1.Size = new System.Drawing.Size(723, 584);
            this.gridControl1.TabIndex = 0;
            this.gridControl1.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.FirstName,
            this.LastName,
            this.Age,
            this.Birthdate,
            this.Address});
            this.gridView1.GridControl = this.gridControl1;
            this.gridView1.Name = "gridView1";
            // 
            // FirstName
            // 
            this.FirstName.Caption = "First Name";
            this.FirstName.FieldName = "FirstName";
            this.FirstName.MinWidth = 25;
            this.FirstName.Name = "FirstName";
            this.FirstName.Visible = true;
            this.FirstName.VisibleIndex = 0;
            this.FirstName.Width = 94;
            // 
            // LastName
            // 
            this.LastName.Caption = "Last Name";
            this.LastName.FieldName = "LastName";
            this.LastName.MinWidth = 25;
            this.LastName.Name = "LastName";
            this.LastName.Visible = true;
            this.LastName.VisibleIndex = 1;
            this.LastName.Width = 94;
            // 
            // Age
            // 
            this.Age.Caption = "Age";
            this.Age.FieldName = "Age";
            this.Age.MinWidth = 25;
            this.Age.Name = "Age";
            this.Age.Visible = true;
            this.Age.VisibleIndex = 2;
            this.Age.Width = 94;
            // 
            // Birthdate
            // 
            this.Birthdate.Caption = "Birth Date";
            this.Birthdate.FieldName = "BirthDate";
            this.Birthdate.MinWidth = 25;
            this.Birthdate.Name = "Birthdate";
            this.Birthdate.Visible = true;
            this.Birthdate.VisibleIndex = 3;
            this.Birthdate.Width = 94;
            // 
            // Address
            // 
            this.Address.Caption = "Address";
            this.Address.FieldName = "Address";
            this.Address.MinWidth = 25;
            this.Address.Name = "Address";
            this.Address.Visible = true;
            this.Address.VisibleIndex = 4;
            this.Address.Width = 94;
            // 
            // teFirstName
            // 
            this.teFirstName.Location = new System.Drawing.Point(97, 105);
            this.teFirstName.Name = "teFirstName";
            this.teFirstName.Properties.AutoHeight = false;
            this.teFirstName.Size = new System.Drawing.Size(293, 41);
            this.teFirstName.TabIndex = 1;
            // 
            // teLastName
            // 
            this.teLastName.Location = new System.Drawing.Point(97, 197);
            this.teLastName.Name = "teLastName";
            this.teLastName.Properties.AutoHeight = false;
            this.teLastName.Size = new System.Drawing.Size(293, 38);
            this.teLastName.TabIndex = 2;
            // 
            // teAge
            // 
            this.teAge.Location = new System.Drawing.Point(97, 285);
            this.teAge.Name = "teAge";
            this.teAge.Properties.AutoHeight = false;
            this.teAge.Size = new System.Drawing.Size(293, 42);
            this.teAge.TabIndex = 3;
            // 
            // tePhoneNumber
            // 
            this.tePhoneNumber.Location = new System.Drawing.Point(97, 382);
            this.tePhoneNumber.Name = "tePhoneNumber";
            this.tePhoneNumber.Properties.AutoHeight = false;
            this.tePhoneNumber.Size = new System.Drawing.Size(293, 42);
            this.tePhoneNumber.TabIndex = 4;
            // 
            // teAddress
            // 
            this.teAddress.Location = new System.Drawing.Point(97, 485);
            this.teAddress.Name = "teAddress";
            this.teAddress.Properties.AutoHeight = false;
            this.teAddress.Size = new System.Drawing.Size(293, 42);
            this.teAddress.TabIndex = 5;
            // 
            // btnAdd
            // 
            this.btnAdd.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.btnAdd.Appearance.Options.UseBackColor = true;
            this.btnAdd.Location = new System.Drawing.Point(97, 585);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(123, 34);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(224)))), ((int)(((byte)(192)))));
            this.btnUpdate.Appearance.Options.UseBackColor = true;
            this.btnUpdate.Location = new System.Drawing.Point(267, 585);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(123, 34);
            this.btnUpdate.TabIndex = 7;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnDelete.Appearance.Options.UseBackColor = true;
            this.btnDelete.Location = new System.Drawing.Point(181, 652);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(123, 34);
            this.btnDelete.TabIndex = 8;
            this.btnDelete.Text = "Delete";
            // 
            // lcFirstName
            // 
            this.lcFirstName.Location = new System.Drawing.Point(218, 83);
            this.lcFirstName.Name = "lcFirstName";
            this.lcFirstName.Size = new System.Drawing.Size(62, 16);
            this.lcFirstName.TabIndex = 9;
            this.lcFirstName.Text = "First Name";
            // 
            // lcLastName
            // 
            this.lcLastName.Location = new System.Drawing.Point(220, 175);
            this.lcLastName.Name = "lcLastName";
            this.lcLastName.Size = new System.Drawing.Size(60, 16);
            this.lcLastName.TabIndex = 10;
            this.lcLastName.Text = "Last Name";
            // 
            // lcAge
            // 
            this.lcAge.Location = new System.Drawing.Point(225, 263);
            this.lcAge.Name = "lcAge";
            this.lcAge.Size = new System.Drawing.Size(22, 16);
            this.lcAge.TabIndex = 11;
            this.lcAge.Text = "Age";
            // 
            // lcPhoneNumber
            // 
            this.lcPhoneNumber.Location = new System.Drawing.Point(204, 360);
            this.lcPhoneNumber.Name = "lcPhoneNumber";
            this.lcPhoneNumber.Size = new System.Drawing.Size(84, 16);
            this.lcPhoneNumber.TabIndex = 12;
            this.lcPhoneNumber.Text = "Phone Number";
            // 
            // lcAddress
            // 
            this.lcAddress.Location = new System.Drawing.Point(220, 463);
            this.lcAddress.Name = "lcAddress";
            this.lcAddress.Size = new System.Drawing.Size(46, 16);
            this.lcAddress.TabIndex = 13;
            this.lcAddress.Text = "Address";
            // 
            // StudentForm
            // 
            this.Appearance.BackColor = System.Drawing.Color.OldLace;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1288, 710);
            this.Controls.Add(this.lcAddress);
            this.Controls.Add(this.lcPhoneNumber);
            this.Controls.Add(this.lcAge);
            this.Controls.Add(this.lcLastName);
            this.Controls.Add(this.lcFirstName);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.teAddress);
            this.Controls.Add(this.tePhoneNumber);
            this.Controls.Add(this.teAge);
            this.Controls.Add(this.teLastName);
            this.Controls.Add(this.teFirstName);
            this.Controls.Add(this.gridControl1);
            this.IconOptions.SvgImage = global::Student_Proj.Properties.Resources.bo_department;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "StudentForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Form";
            ((System.ComponentModel.ISupportInitialize)(this.gridControl1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teFirstName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teLastName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tePhoneNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.teAddress.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraGrid.GridControl gridControl1;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraEditors.TextEdit teFirstName;
        private DevExpress.XtraEditors.TextEdit teLastName;
        private DevExpress.XtraGrid.Columns.GridColumn FirstName;
        private DevExpress.XtraGrid.Columns.GridColumn LastName;
        private DevExpress.XtraGrid.Columns.GridColumn Age;
        private DevExpress.XtraGrid.Columns.GridColumn Birthdate;
        private DevExpress.XtraGrid.Columns.GridColumn Address;
        private DevExpress.XtraEditors.TextEdit teAge;
        private DevExpress.XtraEditors.TextEdit tePhoneNumber;
        private DevExpress.XtraEditors.TextEdit teAddress;
        private DevExpress.XtraEditors.SimpleButton btnAdd;
        private DevExpress.XtraEditors.SimpleButton btnUpdate;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraEditors.LabelControl lcFirstName;
        private DevExpress.XtraEditors.LabelControl lcLastName;
        private DevExpress.XtraEditors.LabelControl lcAge;
        private DevExpress.XtraEditors.LabelControl lcPhoneNumber;
        private DevExpress.XtraEditors.LabelControl lcAddress;
    }
}

