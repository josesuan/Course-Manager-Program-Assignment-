namespace CourseManager
{
	partial class Menu
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
			this.label2 = new System.Windows.Forms.Label();
			this.btn_StartDashboard = new System.Windows.Forms.Button();
			this.label3 = new System.Windows.Forms.Label();
			this.SuspendLayout();
			// 
			// label1
			// 
			this.label1.AutoSize = true;
			this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label1.Location = new System.Drawing.Point(159, 54);
			this.label1.Name = "label1";
			this.label1.Size = new System.Drawing.Size(102, 25);
			this.label1.TabIndex = 0;
			this.label1.Text = "Welcome";
			// 
			// label2
			// 
			this.label2.AutoSize = true;
			this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label2.Location = new System.Drawing.Point(140, 93);
			this.label2.Name = "label2";
			this.label2.Size = new System.Drawing.Size(147, 20);
			this.label2.TabIndex = 1;
			this.label2.Text = "Course Manager";
			// 
			// btn_StartDashboard
			// 
			this.btn_StartDashboard.Location = new System.Drawing.Point(143, 168);
			this.btn_StartDashboard.Name = "btn_StartDashboard";
			this.btn_StartDashboard.Size = new System.Drawing.Size(133, 47);
			this.btn_StartDashboard.TabIndex = 2;
			this.btn_StartDashboard.Text = "Start";
			this.btn_StartDashboard.UseVisualStyleBackColor = true;
			this.btn_StartDashboard.Click += new System.EventHandler(this.Btn_StartDashboard_Click);
			// 
			// label3
			// 
			this.label3.AutoSize = true;
			this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
			this.label3.Location = new System.Drawing.Point(147, 270);
			this.label3.Name = "label3";
			this.label3.Size = new System.Drawing.Size(129, 20);
			this.label3.TabIndex = 3;
			this.label3.Text = "Group Nachos";
			// 
			// Menu
			// 
			this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.ClientSize = new System.Drawing.Size(437, 344);
			this.Controls.Add(this.label3);
			this.Controls.Add(this.btn_StartDashboard);
			this.Controls.Add(this.label2);
			this.Controls.Add(this.label1);
			this.Name = "Menu";
			this.Text = "Course Manager App";
			this.ResumeLayout(false);
			this.PerformLayout();

		}

		#endregion

		private System.Windows.Forms.Label label1;
		private System.Windows.Forms.Label label2;
		private System.Windows.Forms.Button btn_StartDashboard;
		private System.Windows.Forms.Label label3;
	}
}