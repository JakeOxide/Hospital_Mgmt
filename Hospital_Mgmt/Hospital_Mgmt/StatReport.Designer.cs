namespace Hospital_Mgmt
{
    partial class StatReport
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gbox_employee = new System.Windows.Forms.GroupBox();
            this.gbox_top3Rating = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView3 = new System.Windows.Forms.DataGridView();
            this.dgv_rating = new System.Windows.Forms.DataGridView();
            this.gbox_top3Salary = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.dgv_salary = new System.Windows.Forms.DataGridView();
            this.tpanel_employeeCount = new System.Windows.Forms.TableLayoutPanel();
            this.lbl_emp_doctors = new System.Windows.Forms.Label();
            this.lbl_emp_tot_total = new System.Windows.Forms.Label();
            this.lbl_emp_tot_adm = new System.Windows.Forms.Label();
            this.lbl_emp_tot_nur = new System.Windows.Forms.Label();
            this.lbl_emp_tot_doc = new System.Windows.Forms.Label();
            this.lbl_emp_nurses = new System.Windows.Forms.Label();
            this.lbl_emp_admins = new System.Windows.Forms.Label();
            this.lbl_emp_totalEmployees = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.gbox_patient = new System.Windows.Forms.GroupBox();
            this.gbox_top10Age_Patient = new System.Windows.Forms.GroupBox();
            this.dgv_age = new System.Windows.Forms.DataGridView();
            this.lbl_pat_totalPatients = new System.Windows.Forms.Label();
            this.lbl_pat_tot_total = new System.Windows.Forms.Label();
            this.gbox_employee.SuspendLayout();
            this.gbox_top3Rating.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rating)).BeginInit();
            this.gbox_top3Salary.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).BeginInit();
            this.tpanel_employeeCount.SuspendLayout();
            this.panel1.SuspendLayout();
            this.gbox_patient.SuspendLayout();
            this.gbox_top10Age_Patient.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_age)).BeginInit();
            this.SuspendLayout();
            // 
            // gbox_employee
            // 
            this.gbox_employee.Controls.Add(this.gbox_top3Rating);
            this.gbox_employee.Controls.Add(this.gbox_top3Salary);
            this.gbox_employee.Controls.Add(this.tpanel_employeeCount);
            this.gbox_employee.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_employee.Location = new System.Drawing.Point(12, 3);
            this.gbox_employee.Name = "gbox_employee";
            this.gbox_employee.Size = new System.Drawing.Size(365, 539);
            this.gbox_employee.TabIndex = 0;
            this.gbox_employee.TabStop = false;
            this.gbox_employee.Text = "Employee";
            // 
            // gbox_top3Rating
            // 
            this.gbox_top3Rating.Controls.Add(this.groupBox4);
            this.gbox_top3Rating.Controls.Add(this.dgv_rating);
            this.gbox_top3Rating.Location = new System.Drawing.Point(6, 346);
            this.gbox_top3Rating.Name = "gbox_top3Rating";
            this.gbox_top3Rating.Size = new System.Drawing.Size(353, 169);
            this.gbox_top3Rating.TabIndex = 12;
            this.gbox_top3Rating.TabStop = false;
            this.gbox_top3Rating.Text = "Top 3 (Rating)";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView3);
            this.groupBox4.Location = new System.Drawing.Point(0, 168);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(353, 169);
            this.groupBox4.TabIndex = 11;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Top 3 (Salary)";
            // 
            // dataGridView3
            // 
            this.dataGridView3.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView3.Location = new System.Drawing.Point(12, 35);
            this.dataGridView3.Name = "dataGridView3";
            this.dataGridView3.Size = new System.Drawing.Size(335, 126);
            this.dataGridView3.TabIndex = 9;
            // 
            // dgv_rating
            // 
            this.dgv_rating.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_rating.Location = new System.Drawing.Point(6, 35);
            this.dgv_rating.Name = "dgv_rating";
            this.dgv_rating.Size = new System.Drawing.Size(341, 126);
            this.dgv_rating.TabIndex = 9;
            // 
            // gbox_top3Salary
            // 
            this.gbox_top3Salary.Controls.Add(this.groupBox2);
            this.gbox_top3Salary.Controls.Add(this.dgv_salary);
            this.gbox_top3Salary.Location = new System.Drawing.Point(6, 171);
            this.gbox_top3Salary.Name = "gbox_top3Salary";
            this.gbox_top3Salary.Size = new System.Drawing.Size(353, 169);
            this.gbox_top3Salary.TabIndex = 10;
            this.gbox_top3Salary.TabStop = false;
            this.gbox_top3Salary.Text = "Top 3 (Salary)";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dataGridView2);
            this.groupBox2.Location = new System.Drawing.Point(0, 168);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(353, 169);
            this.groupBox2.TabIndex = 11;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Top 3 (Salary)";
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(12, 35);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.Size = new System.Drawing.Size(335, 126);
            this.dataGridView2.TabIndex = 9;
            // 
            // dgv_salary
            // 
            this.dgv_salary.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_salary.Location = new System.Drawing.Point(6, 35);
            this.dgv_salary.Name = "dgv_salary";
            this.dgv_salary.Size = new System.Drawing.Size(341, 127);
            this.dgv_salary.TabIndex = 9;
            // 
            // tpanel_employeeCount
            // 
            this.tpanel_employeeCount.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.tpanel_employeeCount.ColumnCount = 2;
            this.tpanel_employeeCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 60.76923F));
            this.tpanel_employeeCount.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 39.23077F));
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_doctors, 0, 0);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_tot_total, 1, 3);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_tot_adm, 1, 2);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_tot_nur, 1, 1);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_tot_doc, 1, 0);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_nurses, 0, 1);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_admins, 0, 2);
            this.tpanel_employeeCount.Controls.Add(this.lbl_emp_totalEmployees, 0, 3);
            this.tpanel_employeeCount.Location = new System.Drawing.Point(40, 35);
            this.tpanel_employeeCount.Name = "tpanel_employeeCount";
            this.tpanel_employeeCount.RowCount = 4;
            this.tpanel_employeeCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpanel_employeeCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpanel_employeeCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpanel_employeeCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tpanel_employeeCount.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tpanel_employeeCount.Size = new System.Drawing.Size(292, 130);
            this.tpanel_employeeCount.TabIndex = 8;
            // 
            // lbl_emp_doctors
            // 
            this.lbl_emp_doctors.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_doctors.AutoSize = true;
            this.lbl_emp_doctors.Location = new System.Drawing.Point(52, 2);
            this.lbl_emp_doctors.Name = "lbl_emp_doctors";
            this.lbl_emp_doctors.Size = new System.Drawing.Size(73, 28);
            this.lbl_emp_doctors.TabIndex = 3;
            this.lbl_emp_doctors.Text = "Doctors";
            // 
            // lbl_emp_tot_total
            // 
            this.lbl_emp_tot_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_tot_total.AutoSize = true;
            this.lbl_emp_tot_total.Location = new System.Drawing.Point(208, 99);
            this.lbl_emp_tot_total.Name = "lbl_emp_tot_total";
            this.lbl_emp_tot_total.Size = new System.Drawing.Size(53, 28);
            this.lbl_emp_tot_total.TabIndex = 4;
            this.lbl_emp_tot_total.Text = "Total";
            // 
            // lbl_emp_tot_adm
            // 
            this.lbl_emp_tot_adm.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_tot_adm.AutoSize = true;
            this.lbl_emp_tot_adm.Location = new System.Drawing.Point(208, 66);
            this.lbl_emp_tot_adm.Name = "lbl_emp_tot_adm";
            this.lbl_emp_tot_adm.Size = new System.Drawing.Size(53, 28);
            this.lbl_emp_tot_adm.TabIndex = 5;
            this.lbl_emp_tot_adm.Text = "Total";
            // 
            // lbl_emp_tot_nur
            // 
            this.lbl_emp_tot_nur.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_tot_nur.AutoSize = true;
            this.lbl_emp_tot_nur.Location = new System.Drawing.Point(208, 34);
            this.lbl_emp_tot_nur.Name = "lbl_emp_tot_nur";
            this.lbl_emp_tot_nur.Size = new System.Drawing.Size(53, 28);
            this.lbl_emp_tot_nur.TabIndex = 6;
            this.lbl_emp_tot_nur.Text = "Total";
            // 
            // lbl_emp_tot_doc
            // 
            this.lbl_emp_tot_doc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_tot_doc.AutoSize = true;
            this.lbl_emp_tot_doc.Location = new System.Drawing.Point(208, 2);
            this.lbl_emp_tot_doc.Name = "lbl_emp_tot_doc";
            this.lbl_emp_tot_doc.Size = new System.Drawing.Size(53, 28);
            this.lbl_emp_tot_doc.TabIndex = 7;
            this.lbl_emp_tot_doc.Text = "Total";
            // 
            // lbl_emp_nurses
            // 
            this.lbl_emp_nurses.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_nurses.AutoSize = true;
            this.lbl_emp_nurses.Location = new System.Drawing.Point(56, 34);
            this.lbl_emp_nurses.Name = "lbl_emp_nurses";
            this.lbl_emp_nurses.Size = new System.Drawing.Size(65, 28);
            this.lbl_emp_nurses.TabIndex = 2;
            this.lbl_emp_nurses.Text = "Nurses";
            // 
            // lbl_emp_admins
            // 
            this.lbl_emp_admins.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_admins.AutoSize = true;
            this.lbl_emp_admins.Location = new System.Drawing.Point(51, 66);
            this.lbl_emp_admins.Name = "lbl_emp_admins";
            this.lbl_emp_admins.Size = new System.Drawing.Size(74, 28);
            this.lbl_emp_admins.TabIndex = 1;
            this.lbl_emp_admins.Text = "Admins";
            // 
            // lbl_emp_totalEmployees
            // 
            this.lbl_emp_totalEmployees.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_emp_totalEmployees.AutoSize = true;
            this.lbl_emp_totalEmployees.Location = new System.Drawing.Point(17, 99);
            this.lbl_emp_totalEmployees.Name = "lbl_emp_totalEmployees";
            this.lbl_emp_totalEmployees.Size = new System.Drawing.Size(142, 28);
            this.lbl_emp_totalEmployees.TabIndex = 0;
            this.lbl_emp_totalEmployees.Text = "Total Employees";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.gbox_patient);
            this.panel1.Controls.Add(this.gbox_employee);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(777, 558);
            this.panel1.TabIndex = 1;
            // 
            // gbox_patient
            // 
            this.gbox_patient.Controls.Add(this.gbox_top10Age_Patient);
            this.gbox_patient.Controls.Add(this.lbl_pat_totalPatients);
            this.gbox_patient.Controls.Add(this.lbl_pat_tot_total);
            this.gbox_patient.Font = new System.Drawing.Font("Segoe Print", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbox_patient.Location = new System.Drawing.Point(383, 57);
            this.gbox_patient.Name = "gbox_patient";
            this.gbox_patient.Size = new System.Drawing.Size(381, 411);
            this.gbox_patient.TabIndex = 1;
            this.gbox_patient.TabStop = false;
            this.gbox_patient.Text = "Patient";
            // 
            // gbox_top10Age_Patient
            // 
            this.gbox_top10Age_Patient.Controls.Add(this.dgv_age);
            this.gbox_top10Age_Patient.Location = new System.Drawing.Point(6, 82);
            this.gbox_top10Age_Patient.Name = "gbox_top10Age_Patient";
            this.gbox_top10Age_Patient.Size = new System.Drawing.Size(369, 323);
            this.gbox_top10Age_Patient.TabIndex = 11;
            this.gbox_top10Age_Patient.TabStop = false;
            this.gbox_top10Age_Patient.Text = "Top 10 (Age)";
            // 
            // dgv_age
            // 
            this.dgv_age.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_age.Location = new System.Drawing.Point(6, 35);
            this.dgv_age.Name = "dgv_age";
            this.dgv_age.Size = new System.Drawing.Size(357, 282);
            this.dgv_age.TabIndex = 9;
            // 
            // lbl_pat_totalPatients
            // 
            this.lbl_pat_totalPatients.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pat_totalPatients.AutoSize = true;
            this.lbl_pat_totalPatients.Location = new System.Drawing.Point(87, 41);
            this.lbl_pat_totalPatients.Name = "lbl_pat_totalPatients";
            this.lbl_pat_totalPatients.Size = new System.Drawing.Size(124, 28);
            this.lbl_pat_totalPatients.TabIndex = 8;
            this.lbl_pat_totalPatients.Text = "Total Patients";
            // 
            // lbl_pat_tot_total
            // 
            this.lbl_pat_tot_total.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_pat_tot_total.AutoSize = true;
            this.lbl_pat_tot_total.Location = new System.Drawing.Point(250, 41);
            this.lbl_pat_tot_total.Name = "lbl_pat_tot_total";
            this.lbl_pat_tot_total.Size = new System.Drawing.Size(53, 28);
            this.lbl_pat_tot_total.TabIndex = 9;
            this.lbl_pat_tot_total.Text = "Total";
            // 
            // StatReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PowderBlue;
            this.Controls.Add(this.panel1);
            this.Name = "StatReport";
            this.Size = new System.Drawing.Size(783, 564);
            this.gbox_employee.ResumeLayout(false);
            this.gbox_top3Rating.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_rating)).EndInit();
            this.gbox_top3Salary.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_salary)).EndInit();
            this.tpanel_employeeCount.ResumeLayout(false);
            this.tpanel_employeeCount.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.gbox_patient.ResumeLayout(false);
            this.gbox_patient.PerformLayout();
            this.gbox_top10Age_Patient.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_age)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbox_employee;
        private System.Windows.Forms.TableLayoutPanel tpanel_employeeCount;
        private System.Windows.Forms.Label lbl_emp_doctors;
        private System.Windows.Forms.Label lbl_emp_tot_total;
        private System.Windows.Forms.Label lbl_emp_tot_adm;
        private System.Windows.Forms.Label lbl_emp_tot_nur;
        private System.Windows.Forms.Label lbl_emp_tot_doc;
        private System.Windows.Forms.Label lbl_emp_nurses;
        private System.Windows.Forms.Label lbl_emp_admins;
        private System.Windows.Forms.Label lbl_emp_totalEmployees;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.GroupBox gbox_patient;
        private System.Windows.Forms.GroupBox gbox_top3Rating;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView3;
        private System.Windows.Forms.DataGridView dgv_rating;
        private System.Windows.Forms.GroupBox gbox_top3Salary;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.DataGridView dgv_salary;
        private System.Windows.Forms.GroupBox gbox_top10Age_Patient;
        private System.Windows.Forms.DataGridView dgv_age;
        private System.Windows.Forms.Label lbl_pat_totalPatients;
        private System.Windows.Forms.Label lbl_pat_tot_total;
    }
}
