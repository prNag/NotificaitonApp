using System;

namespace NotifyApp
{
    partial class Form1
    {
        public Int64 notfiyTime;
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
            this.lblNotifyTime = new System.Windows.Forms.Label();
            this.txtNofiyTime = new System.Windows.Forms.TextBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNotifyTime
            // 
            this.lblNotifyTime.AutoSize = true;
            this.lblNotifyTime.Location = new System.Drawing.Point(24, 61);
            this.lblNotifyTime.Name = "lblNotifyTime";
            this.lblNotifyTime.Size = new System.Drawing.Size(128, 13);
            this.lblNotifyTime.TabIndex = 0;
            this.lblNotifyTime.Text = "Notification Time (in ms) : ";
            // 
            // txtNofiyTime
            // 
            this.txtNofiyTime.Location = new System.Drawing.Point(158, 61);
            this.txtNofiyTime.Name = "txtNofiyTime";
            this.txtNofiyTime.Size = new System.Drawing.Size(100, 20);
            this.txtNofiyTime.TabIndex = 1;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(51, 124);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(184, 28);
            this.btnUpdate.TabIndex = 2;
            this.btnUpdate.Text = "Update Time";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(51, 172);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(184, 30);
            this.button1.TabIndex = 3;
            this.button1.Text = "Show Current Notificaiton Time";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(292, 273);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.txtNofiyTime);
            this.Controls.Add(this.lblNotifyTime);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNotifyTime;
        private System.Windows.Forms.TextBox txtNofiyTime;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button button1;
    }
}

