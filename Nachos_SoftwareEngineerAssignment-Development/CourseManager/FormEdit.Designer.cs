namespace WindowsFormsApp1
{
    partial class FormEdit
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
            this.label1 = new System.Windows.Forms.Label();
            this.bx_assignmentNum = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_assigmentType = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.bx_modName = new System.Windows.Forms.TextBox();
            this.bx_startDate = new System.Windows.Forms.TextBox();
            this.bx_dueDate = new System.Windows.Forms.TextBox();
            this.bt_finish = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(98, 31);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(187, 22);
            this.label1.TabIndex = 0;
            this.label1.Text = "Edit Ongoing Module";
            // 
            // bx_assignmentNum
            // 
            this.bx_assignmentNum.Location = new System.Drawing.Point(11, 110);
            this.bx_assignmentNum.Name = "bx_assignmentNum";
            this.bx_assignmentNum.Size = new System.Drawing.Size(130, 20);
            this.bx_assignmentNum.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(8, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 18);
            this.label2.TabIndex = 2;
            this.label2.Text = "Assignment number";
            // 
            // cb_assigmentType
            // 
            this.cb_assigmentType.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cb_assigmentType.FormattingEnabled = true;
            this.cb_assigmentType.Location = new System.Drawing.Point(12, 148);
            this.cb_assigmentType.Name = "cb_assigmentType";
            this.cb_assigmentType.Size = new System.Drawing.Size(134, 26);
            this.cb_assigmentType.TabIndex = 3;
            this.cb_assigmentType.Text = "AssigmentType";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(8, 196);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(102, 18);
            this.label3.TabIndex = 4;
            this.label3.Text = "Module name";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(9, 262);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 18);
            this.label4.TabIndex = 5;
            this.label4.Text = "Start date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(12, 324);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 18);
            this.label5.TabIndex = 6;
            this.label5.Text = "Due date";
            // 
            // bx_modName
            // 
            this.bx_modName.Location = new System.Drawing.Point(12, 221);
            this.bx_modName.Name = "bx_modName";
            this.bx_modName.Size = new System.Drawing.Size(134, 20);
            this.bx_modName.TabIndex = 7;
            // 
            // bx_startDate
            // 
            this.bx_startDate.Location = new System.Drawing.Point(12, 283);
            this.bx_startDate.Name = "bx_startDate";
            this.bx_startDate.Size = new System.Drawing.Size(134, 20);
            this.bx_startDate.TabIndex = 8;
            // 
            // bx_dueDate
            // 
            this.bx_dueDate.Location = new System.Drawing.Point(12, 345);
            this.bx_dueDate.Name = "bx_dueDate";
            this.bx_dueDate.Size = new System.Drawing.Size(134, 20);
            this.bx_dueDate.TabIndex = 9;
            // 
            // bt_finish
            // 
            this.bt_finish.Font = new System.Drawing.Font("Arial", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bt_finish.Location = new System.Drawing.Point(125, 407);
            this.bt_finish.Name = "bt_finish";
            this.bt_finish.Size = new System.Drawing.Size(130, 59);
            this.bt_finish.TabIndex = 10;
            this.bt_finish.Text = "Finish";
            this.bt_finish.UseVisualStyleBackColor = true;
            // 
            // FormEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(390, 498);
            this.Controls.Add(this.bt_finish);
            this.Controls.Add(this.bx_dueDate);
            this.Controls.Add(this.bx_startDate);
            this.Controls.Add(this.bx_modName);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.cb_assigmentType);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.bx_assignmentNum);
            this.Controls.Add(this.label1);
            this.Name = "FormEdit";
            this.Text = "FormEdit";
            this.Load += new System.EventHandler(this.FormEdit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox bx_assignmentNum;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cb_assigmentType;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox bx_modName;
        private System.Windows.Forms.TextBox bx_startDate;
        private System.Windows.Forms.TextBox bx_dueDate;
        private System.Windows.Forms.Button bt_finish;
    }
}