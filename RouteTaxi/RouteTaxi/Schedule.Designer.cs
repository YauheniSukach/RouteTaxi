namespace RouteTaxi
{
    partial class Schedule
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
            this.CBtxt = new System.Windows.Forms.ComboBox();
            this.btn = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // CBtxt
            // 
            this.CBtxt.FormattingEnabled = true;
            this.CBtxt.Location = new System.Drawing.Point(146, 102);
            this.CBtxt.Name = "CBtxt";
            this.CBtxt.Size = new System.Drawing.Size(326, 21);
            this.CBtxt.TabIndex = 0;
            // 
            // btn
            // 
            this.btn.BackColor = System.Drawing.Color.Red;
            this.btn.Location = new System.Drawing.Point(39, 100);
            this.btn.Name = "btn";
            this.btn.Size = new System.Drawing.Size(75, 23);
            this.btn.TabIndex = 1;
            this.btn.Text = "Search";
            this.btn.UseVisualStyleBackColor = false;
            this.btn.Click += new System.EventHandler(this.btn_Click);
            // 
            // btn1
            // 
            this.btn1.BackColor = System.Drawing.Color.Red;
            this.btn1.Location = new System.Drawing.Point(500, 100);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(75, 23);
            this.btn1.TabIndex = 2;
            this.btn1.Text = "Buy";
            this.btn1.UseVisualStyleBackColor = false;
            // 
            // Schedule
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(591, 261);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.btn);
            this.Controls.Add(this.CBtxt);
            this.Name = "Schedule";
            this.Text = "Schedule";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox CBtxt;
        private System.Windows.Forms.Button btn;
        private System.Windows.Forms.Button btn1;
    }
}