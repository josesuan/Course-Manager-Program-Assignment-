namespace CourseManager
{
    partial class EditForm
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
            this.bt_finish = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ed_dueDate = new System.Windows.Forms.DateTimePicker();
            this.ed_startDate = new System.Windows.Forms.DateTimePicker();
            this.ed_moduleName = new System.Windows.Forms.TextBox();
            this.ed_assignmentType = new System.Windows.Forms.ComboBox();
            this.ed_assignmentNumber = new System.Windows.Forms.TextBox();
            this.ed_year = new System.Windows.Forms.TextBox();
            this.ed_MarkTexbox = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // bt_finish
            // 
            this.bt_finish.Location = new System.Drawing.Point(285, 386);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(130, 59);
            this.bt_finish.TabIndex = 19;
            this.bt_finish.Text = "Finish";
            this.bt_finish.UseVisualStyleBackColor = true;
            this.bt_finish.Click += new System.EventHandler(this.bt_finish_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(126, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(209, 24);
            this.label1.TabIndex = 11;
            this.label1.Text = "Edit Ongoing Module";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(26, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(53, 13);
            this.label6.TabIndex = 31;
            this.label6.Text = "Due Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(26, 274);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 30;
            this.label5.Text = "Start Date";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 220);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 13);
            this.label4.TabIndex = 29;
            this.label4.Text = "Module Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(26, 170);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 13);
            this.label3.TabIndex = 28;
            this.label3.Text = "Assignment Type";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 120);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(101, 13);
            this.label2.TabIndex = 27;
            this.label2.Text = "Assignment Number";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(26, 67);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(29, 13);
            this.label7.TabIndex = 26;
            this.label7.Text = "Year";
            // 
            // ed_dueDate
            // 
            this.ed_dueDate.Location = new System.Drawing.Point(25, 344);
            this.ed_dueDate.Name = "ed_dueDate";
            this.ed_dueDate.Size = new System.Drawing.Size(144, 20);
            this.ed_dueDate.TabIndex = 25;
            // 
            // ed_startDate
            // 
            this.ed_startDate.Location = new System.Drawing.Point(26, 290);
            this.ed_startDate.Name = "ed_startDate";
            this.ed_startDate.Size = new System.Drawing.Size(143, 20);
            this.ed_startDate.TabIndex = 24;
            // 
            // ed_moduleName
            // 
            this.ed_moduleName.Location = new System.Drawing.Point(25, 236);
            this.ed_moduleName.Name = "ed_moduleName";
            this.ed_moduleName.Size = new System.Drawing.Size(144, 20);
            this.ed_moduleName.TabIndex = 23;
            this.ed_moduleName.Text = "OOP";
            // 
            // ed_assignmentType
            // 
            this.ed_assignmentType.FormattingEnabled = true;
            this.ed_assignmentType.Location = new System.Drawing.Point(25, 186);
            this.ed_assignmentType.Name = "ed_assignmentType";
            this.ed_assignmentType.Size = new System.Drawing.Size(144, 21);
            this.ed_assignmentType.TabIndex = 22;
            this.ed_assignmentType.Text = "Essay";
            // 
            // ed_assignmentNumber
            // 
            this.ed_assignmentNumber.Location = new System.Drawing.Point(25, 136);
            this.ed_assignmentNumber.Name = "ed_assignmentNumber";
            this.ed_assignmentNumber.Size = new System.Drawing.Size(144, 20);
            this.ed_assignmentNumber.TabIndex = 21;
            this.ed_assignmentNumber.Text = "1";
            // 
            // ed_year
            // 
            this.ed_year.Location = new System.Drawing.Point(25, 86);
            this.ed_year.Name = "ed_year";
            this.ed_year.Size = new System.Drawing.Size(145, 20);
            this.ed_year.TabIndex = 20;
            this.ed_year.Text = "1";
            // 
            // ed_MarkTexbox
            // 
            this.ed_MarkTexbox.Location = new System.Drawing.Point(248, 86);
            this.ed_MarkTexbox.Name = "ed_MarkTexbox";
            this.ed_MarkTexbox.Size = new System.Drawing.Size(145, 20);
            this.ed_MarkTexbox.TabIndex = 32;
            this.ed_MarkTexbox.Text = "1";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(245, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(31, 13);
            this.label8.TabIndex = 33;
            this.label8.Text = "Mark";
            // 
            // EditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(440, 450);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.ed_MarkTexbox);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.ed_dueDate);
            this.Controls.Add(this.ed_startDate);
            this.Controls.Add(this.ed_moduleName);
            this.Controls.Add(this.ed_assignmentType);
            this.Controls.Add(this.ed_assignmentNumber);
            this.Controls.Add(this.ed_year);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.label1);
            this.Name = "EditForm";
            this.Text = "EditForm";
            this.Load += new System.EventHandler(this.EditForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button bt_finish;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker ed_dueDate;
        private System.Windows.Forms.DateTimePicker ed_startDate;
        private System.Windows.Forms.TextBox ed_moduleName;
        private System.Windows.Forms.ComboBox ed_assignmentType;
        private System.Windows.Forms.TextBox ed_assignmentNumber;
        private System.Windows.Forms.TextBox ed_year;
        private System.Windows.Forms.TextBox ed_MarkTexbox;
        private System.Windows.Forms.Label label8;
    }
}