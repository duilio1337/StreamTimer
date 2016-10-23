namespace StreamTimer
{
    partial class FormOptions
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
            this.button1 = new System.Windows.Forms.Button();
            this.cb_hidehr = new System.Windows.Forms.CheckBox();
            this.b_about = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 126);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "Close";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.close_Click);
            // 
            // cb_hidehr
            // 
            this.cb_hidehr.AutoSize = true;
            this.cb_hidehr.Location = new System.Drawing.Point(13, 13);
            this.cb_hidehr.Name = "cb_hidehr";
            this.cb_hidehr.Size = new System.Drawing.Size(115, 17);
            this.cb_hidehr.TabIndex = 1;
            this.cb_hidehr.Text = "Hide hours when 0";
            this.cb_hidehr.UseVisualStyleBackColor = true;
            this.cb_hidehr.CheckedChanged += new System.EventHandler(this.cb_showhr_CheckedChanged);
            // 
            // b_about
            // 
            this.b_about.Location = new System.Drawing.Point(13, 126);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(75, 23);
            this.b_about.TabIndex = 2;
            this.b_about.Text = "About";
            this.b_about.UseVisualStyleBackColor = true;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.b_about);
            this.Controls.Add(this.cb_hidehr);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_hidehr;
        private System.Windows.Forms.Button b_about;
    }
}