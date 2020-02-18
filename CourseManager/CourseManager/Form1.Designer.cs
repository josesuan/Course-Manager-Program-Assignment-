namespace WindowsFormsApp1
{
    partial class Form1
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
            this.Lb_Module = new System.Windows.Forms.GroupBox();
            this.bt_edit = new System.Windows.Forms.Button();
            this.bt_sendPending = new System.Windows.Forms.Button();
            this.bt_sendFinish = new System.Windows.Forms.Button();
            this.bt_remove = new System.Windows.Forms.Button();
            this.Lb_Module.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(299, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(169, 24);
            this.label1.TabIndex = 0;
            this.label1.Text = "Option Edit Form";
            // 
            // Lb_Module
            // 
            this.Lb_Module.Controls.Add(this.bt_remove);
            this.Lb_Module.Controls.Add(this.bt_sendFinish);
            this.Lb_Module.Controls.Add(this.bt_sendPending);
            this.Lb_Module.Controls.Add(this.bt_edit);
            this.Lb_Module.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Lb_Module.Location = new System.Drawing.Point(25, 72);
            this.Lb_Module.Name = "Lb_Module";
            this.Lb_Module.Size = new System.Drawing.Size(743, 155);
            this.Lb_Module.TabIndex = 1;
            this.Lb_Module.TabStop = false;
            this.Lb_Module.Text = "Choose option for ";
            this.Lb_Module.Enter += new System.EventHandler(this.GroupBox1_Enter);
            // 
            // bt_edit
            // 
            this.bt_edit.Location = new System.Drawing.Point(26, 58);
            this.bt_edit.Name = "bt_edit";
            this.bt_edit.Size = new System.Drawing.Size(147, 66);
            this.bt_edit.TabIndex = 0;
            this.bt_edit.Text = "Edit";
            this.bt_edit.UseVisualStyleBackColor = true;
            // 
            // bt_sendPending
            // 
            this.bt_sendPending.Location = new System.Drawing.Point(207, 58);
            this.bt_sendPending.Name = "bt_sendPending";
            this.bt_sendPending.Size = new System.Drawing.Size(143, 66);
            this.bt_sendPending.TabIndex = 1;
            this.bt_sendPending.Text = "Send to pending";
            this.bt_sendPending.UseVisualStyleBackColor = true;
            // 
            // bt_sendFinish
            // 
            this.bt_sendFinish.Location = new System.Drawing.Point(378, 58);
            this.bt_sendFinish.Name = "bt_sendFinish";
            this.bt_sendFinish.Size = new System.Drawing.Size(140, 66);
            this.bt_sendFinish.TabIndex = 2;
            this.bt_sendFinish.Text = "Send to finish list";
            this.bt_sendFinish.UseVisualStyleBackColor = true;
            // 
            // bt_remove
            // 
            this.bt_remove.Location = new System.Drawing.Point(537, 58);
            this.bt_remove.Name = "bt_remove";
            this.bt_remove.Size = new System.Drawing.Size(150, 66);
            this.bt_remove.TabIndex = 3;
            this.bt_remove.Text = "Remove";
            this.bt_remove.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 252);
            this.Controls.Add(this.Lb_Module);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Lb_Module.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox Lb_Module;
        private System.Windows.Forms.Button bt_remove;
        private System.Windows.Forms.Button bt_sendFinish;
        private System.Windows.Forms.Button bt_sendPending;
        private System.Windows.Forms.Button bt_edit;
    }
}

