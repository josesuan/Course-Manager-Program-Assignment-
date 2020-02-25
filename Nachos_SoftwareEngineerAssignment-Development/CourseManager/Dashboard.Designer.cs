namespace CourseManager
{
    partial class Dashboard
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tab_ongoing = new System.Windows.Forms.TabPage();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.dgv_ongoing = new System.Windows.Forms.DataGridView();
            this.moduleName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.timeRemaining = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btn_add = new System.Windows.Forms.Button();
            this.dt_dueDate = new System.Windows.Forms.DateTimePicker();
            this.dt_startDate = new System.Windows.Forms.DateTimePicker();
            this.tb_moduleName = new System.Windows.Forms.TextBox();
            this.cb_assignmentType = new System.Windows.Forms.ComboBox();
            this.tb_assignmentNumber = new System.Windows.Forms.TextBox();
            this.tb_year = new System.Windows.Forms.TextBox();
            this.tab_pending = new System.Windows.Forms.TabPage();
            this.dgv_pending = new System.Windows.Forms.DataGridView();
            this.moduleNamePending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.assignmentNumberPending = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dueDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tab_finished = new System.Windows.Forms.TabPage();
            this.btn_addFinished = new System.Windows.Forms.Button();
            this.dgv_finished = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.marks = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.year = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.tb_marksFinished = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.tb_assignmentNumberFinished = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.tb_moduleNameFinished = new System.Windows.Forms.TextBox();
            this.tabControl1.SuspendLayout();
            this.tab_ongoing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ongoing)).BeginInit();
            this.tab_pending.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).BeginInit();
            this.tab_finished.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finished)).BeginInit();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tab_ongoing);
            this.tabControl1.Controls.Add(this.tab_pending);
            this.tabControl1.Controls.Add(this.tab_finished);
            this.tabControl1.Location = new System.Drawing.Point(0, 0);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(780, 460);
            this.tabControl1.TabIndex = 0;
            // 
            // tab_ongoing
            // 
            this.tab_ongoing.Controls.Add(this.label6);
            this.tab_ongoing.Controls.Add(this.label5);
            this.tab_ongoing.Controls.Add(this.label4);
            this.tab_ongoing.Controls.Add(this.label3);
            this.tab_ongoing.Controls.Add(this.label2);
            this.tab_ongoing.Controls.Add(this.label1);
            this.tab_ongoing.Controls.Add(this.dgv_ongoing);
            this.tab_ongoing.Controls.Add(this.btn_add);
            this.tab_ongoing.Controls.Add(this.dt_dueDate);
            this.tab_ongoing.Controls.Add(this.dt_startDate);
            this.tab_ongoing.Controls.Add(this.tb_moduleName);
            this.tab_ongoing.Controls.Add(this.cb_assignmentType);
            this.tab_ongoing.Controls.Add(this.tb_assignmentNumber);
            this.tab_ongoing.Controls.Add(this.tb_year);
            this.tab_ongoing.Location = new System.Drawing.Point(4, 22);
            this.tab_ongoing.Name = "tab_ongoing";
            this.tab_ongoing.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_ongoing.Size = new System.Drawing.Size(772, 434);
            this.tab_ongoing.TabIndex = 0;
            this.tab_ongoing.Text = "Ongoing";
            this.tab_ongoing.UseVisualStyleBackColor = true;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(9, 290);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 13;
            this.label6.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(9, 236);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(9, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Module Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Assignment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(9, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Assignment Number";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(9, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(29, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Year";
            // 
            // dgv_ongoing
            // 
            this.dgv_ongoing.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_ongoing.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleName,
            this.assignmentNumber,
            this.timeRemaining});
            this.dgv_ongoing.Location = new System.Drawing.Point(179, 29);
            this.dgv_ongoing.Name = "dgv_ongoing";
            this.dgv_ongoing.RowHeadersWidth = 62;
            this.dgv_ongoing.Size = new System.Drawing.Size(564, 379);
            this.dgv_ongoing.TabIndex = 7;
            this.dgv_ongoing.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ongoing_CellClick);
            this.dgv_ongoing.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.Dgv_ongoing_CellContentClick);
            // 
            // moduleName
            // 
            this.moduleName.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moduleName.HeaderText = "Module Name";
            this.moduleName.MinimumWidth = 8;
            this.moduleName.Name = "moduleName";
            // 
            // assignmentNumber
            // 
            this.assignmentNumber.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignmentNumber.HeaderText = "Assignment Number";
            this.assignmentNumber.MinimumWidth = 8;
            this.assignmentNumber.Name = "assignmentNumber";
            // 
            // timeRemaining
            // 
            this.timeRemaining.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.timeRemaining.HeaderText = "Time Remaining";
            this.timeRemaining.MinimumWidth = 8;
            this.timeRemaining.Name = "timeRemaining";
            // 
            // btn_add
            // 
            this.btn_add.Location = new System.Drawing.Point(9, 349);
            this.btn_add.Name = "btn_add";
            this.btn_add.Size = new System.Drawing.Size(143, 59);
            this.btn_add.TabIndex = 6;
            this.btn_add.Text = "Add";
            this.btn_add.UseVisualStyleBackColor = true;
            this.btn_add.Click += new System.EventHandler(this.Btn_add_Click);
            // 
            // dt_dueDate
            // 
            this.dt_dueDate.Location = new System.Drawing.Point(8, 306);
            this.dt_dueDate.Name = "dt_dueDate";
            this.dt_dueDate.Size = new System.Drawing.Size(144, 20);
            this.dt_dueDate.TabIndex = 5;
            // 
            // dt_startDate
            // 
            this.dt_startDate.Location = new System.Drawing.Point(9, 252);
            this.dt_startDate.Name = "dt_startDate";
            this.dt_startDate.Size = new System.Drawing.Size(143, 20);
            this.dt_startDate.TabIndex = 4;
            // 
            // tb_moduleName
            // 
            this.tb_moduleName.Location = new System.Drawing.Point(8, 198);
            this.tb_moduleName.Name = "tb_moduleName";
            this.tb_moduleName.Size = new System.Drawing.Size(144, 20);
            this.tb_moduleName.TabIndex = 3;
            // 
            // cb_assignmentType
            // 
            this.cb_assignmentType.FormattingEnabled = true;
            this.cb_assignmentType.Location = new System.Drawing.Point(8, 148);
            this.cb_assignmentType.Name = "cb_assignmentType";
            this.cb_assignmentType.Size = new System.Drawing.Size(144, 21);
            this.cb_assignmentType.TabIndex = 2;
            // 
            // tb_assignmentNumber
            // 
            this.tb_assignmentNumber.Location = new System.Drawing.Point(8, 98);
            this.tb_assignmentNumber.Name = "tb_assignmentNumber";
            this.tb_assignmentNumber.Size = new System.Drawing.Size(144, 20);
            this.tb_assignmentNumber.TabIndex = 1;
            // 
            // tb_year
            // 
            this.tb_year.Location = new System.Drawing.Point(8, 48);
            this.tb_year.Name = "tb_year";
            this.tb_year.Size = new System.Drawing.Size(145, 20);
            this.tb_year.TabIndex = 0;
            // 
            // tab_pending
            // 
            this.tab_pending.Controls.Add(this.dgv_pending);
            this.tab_pending.Location = new System.Drawing.Point(4, 22);
            this.tab_pending.Name = "tab_pending";
            this.tab_pending.Size = new System.Drawing.Size(772, 434);
            this.tab_pending.TabIndex = 2;
            this.tab_pending.Text = "Pending";
            this.tab_pending.UseVisualStyleBackColor = true;
            // 
            // dgv_pending
            // 
            this.dgv_pending.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_pending.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.moduleNamePending,
            this.assignmentNumberPending,
            this.dueDate});
            this.dgv_pending.Location = new System.Drawing.Point(30, 42);
            this.dgv_pending.Name = "dgv_pending";
            this.dgv_pending.RowHeadersWidth = 62;
            this.dgv_pending.Size = new System.Drawing.Size(703, 374);
            this.dgv_pending.TabIndex = 0;
            // 
            // moduleNamePending
            // 
            this.moduleNamePending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.moduleNamePending.HeaderText = "Module Name";
            this.moduleNamePending.MinimumWidth = 8;
            this.moduleNamePending.Name = "moduleNamePending";
            // 
            // assignmentNumberPending
            // 
            this.assignmentNumberPending.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.assignmentNumberPending.HeaderText = "Assignment Number";
            this.assignmentNumberPending.MinimumWidth = 8;
            this.assignmentNumberPending.Name = "assignmentNumberPending";
            // 
            // dueDate
            // 
            this.dueDate.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dueDate.HeaderText = "Due Date";
            this.dueDate.MinimumWidth = 8;
            this.dueDate.Name = "dueDate";
            // 
            // tab_finished
            // 
            this.tab_finished.Controls.Add(this.btn_addFinished);
            this.tab_finished.Controls.Add(this.dgv_finished);
            this.tab_finished.Controls.Add(this.label9);
            this.tab_finished.Controls.Add(this.tb_marksFinished);
            this.tab_finished.Controls.Add(this.label8);
            this.tab_finished.Controls.Add(this.tb_assignmentNumberFinished);
            this.tab_finished.Controls.Add(this.label7);
            this.tab_finished.Controls.Add(this.tb_moduleNameFinished);
            this.tab_finished.Location = new System.Drawing.Point(4, 22);
            this.tab_finished.Name = "tab_finished";
            this.tab_finished.Padding = new System.Windows.Forms.Padding(3, 3, 3, 3);
            this.tab_finished.Size = new System.Drawing.Size(772, 434);
            this.tab_finished.TabIndex = 1;
            this.tab_finished.Text = "Finished";
            this.tab_finished.UseVisualStyleBackColor = true;
            // 
            // btn_addFinished
            // 
            this.btn_addFinished.Location = new System.Drawing.Point(8, 203);
            this.btn_addFinished.Name = "btn_addFinished";
            this.btn_addFinished.Size = new System.Drawing.Size(143, 59);
            this.btn_addFinished.TabIndex = 19;
            this.btn_addFinished.Text = "Add";
            this.btn_addFinished.UseVisualStyleBackColor = true;
            this.btn_addFinished.Click += new System.EventHandler(this.Btn_addFinished_Click);
            // 
            // dgv_finished
            // 
            this.dgv_finished.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgv_finished.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.marks,
            this.year});
            this.dgv_finished.Location = new System.Drawing.Point(191, 29);
            this.dgv_finished.Name = "dgv_finished";
            this.dgv_finished.RowHeadersWidth = 62;
            this.dgv_finished.Size = new System.Drawing.Size(561, 385);
            this.dgv_finished.TabIndex = 18;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn1.HeaderText = "Module Name";
            this.dataGridViewTextBoxColumn1.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.dataGridViewTextBoxColumn2.HeaderText = "Assignment Number";
            this.dataGridViewTextBoxColumn2.MinimumWidth = 8;
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // marks
            // 
            this.marks.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.marks.HeaderText = "Marks (%)";
            this.marks.MinimumWidth = 8;
            this.marks.Name = "marks";
            // 
            // year
            // 
            this.year.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.year.HeaderText = "Year";
            this.year.MinimumWidth = 8;
            this.year.Name = "year";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(9, 142);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(36, 13);
            this.label9.TabIndex = 17;
            this.label9.Text = "Marks";
            // 
            // tb_marksFinished
            // 
            this.tb_marksFinished.Location = new System.Drawing.Point(8, 158);
            this.tb_marksFinished.Name = "tb_marksFinished";
            this.tb_marksFinished.Size = new System.Drawing.Size(143, 20);
            this.tb_marksFinished.TabIndex = 16;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(9, 82);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(101, 13);
            this.label8.TabIndex = 15;
            this.label8.Text = "Assignment Number";
            // 
            // tb_assignmentNumberFinished
            // 
            this.tb_assignmentNumberFinished.Location = new System.Drawing.Point(8, 98);
            this.tb_assignmentNumberFinished.Name = "tb_assignmentNumberFinished";
            this.tb_assignmentNumberFinished.Size = new System.Drawing.Size(143, 20);
            this.tb_assignmentNumberFinished.TabIndex = 14;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(9, 29);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(73, 13);
            this.label7.TabIndex = 13;
            this.label7.Text = "Module Name";
            // 
            // tb_moduleNameFinished
            // 
            this.tb_moduleNameFinished.Location = new System.Drawing.Point(6, 45);
            this.tb_moduleNameFinished.Name = "tb_moduleNameFinished";
            this.tb_moduleNameFinished.Size = new System.Drawing.Size(145, 20);
            this.tb_moduleNameFinished.TabIndex = 12;
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 461);
            this.Controls.Add(this.tabControl1);
            this.Name = "Dashboard";
            this.Text = "Form1";
            this.Activated += new System.EventHandler(this.Dashboard_Activated);
            this.tabControl1.ResumeLayout(false);
            this.tab_ongoing.ResumeLayout(false);
            this.tab_ongoing.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_ongoing)).EndInit();
            this.tab_pending.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgv_pending)).EndInit();
            this.tab_finished.ResumeLayout(false);
            this.tab_finished.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgv_finished)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tab_ongoing;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgv_ongoing;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleName;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentNumber;
        private System.Windows.Forms.DataGridViewTextBoxColumn timeRemaining;
        private System.Windows.Forms.Button btn_add;
        private System.Windows.Forms.DateTimePicker dt_dueDate;
        private System.Windows.Forms.DateTimePicker dt_startDate;
        private System.Windows.Forms.TextBox tb_moduleName;
        private System.Windows.Forms.ComboBox cb_assignmentType;
        private System.Windows.Forms.TextBox tb_assignmentNumber;
        private System.Windows.Forms.TextBox tb_year;
        private System.Windows.Forms.TabPage tab_finished;
        private System.Windows.Forms.DataGridView dgv_finished;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn marks;
        private System.Windows.Forms.DataGridViewTextBoxColumn year;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox tb_marksFinished;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox tb_assignmentNumberFinished;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox tb_moduleNameFinished;
        private System.Windows.Forms.Button btn_addFinished;
        private System.Windows.Forms.TabPage tab_pending;
        private System.Windows.Forms.DataGridView dgv_pending;
        private System.Windows.Forms.DataGridViewTextBoxColumn moduleNamePending;
        private System.Windows.Forms.DataGridViewTextBoxColumn assignmentNumberPending;
        private System.Windows.Forms.DataGridViewTextBoxColumn dueDate;
    }
}

