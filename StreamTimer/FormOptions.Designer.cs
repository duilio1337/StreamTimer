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
            this.tb_prefix = new System.Windows.Forms.TextBox();
            this.tb_suffix = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cb_overtime = new System.Windows.Forms.CheckBox();
            this.cb_nonotify = new System.Windows.Forms.CheckBox();
            this.tb_otprefix = new System.Windows.Forms.TextBox();
            this.tb_otsuffix = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.b_file = new System.Windows.Forms.Button();
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(197, 226);
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
            this.cb_hidehr.Location = new System.Drawing.Point(55, 119);
            this.cb_hidehr.Name = "cb_hidehr";
            this.cb_hidehr.Size = new System.Drawing.Size(113, 17);
            this.cb_hidehr.TabIndex = 5;
            this.cb_hidehr.Text = "Hide hours while 0";
            this.cb_hidehr.UseVisualStyleBackColor = true;
            this.cb_hidehr.CheckedChanged += new System.EventHandler(this.cb_showhr_CheckedChanged);
            // 
            // b_about
            // 
            this.b_about.Location = new System.Drawing.Point(13, 226);
            this.b_about.Name = "b_about";
            this.b_about.Size = new System.Drawing.Size(75, 23);
            this.b_about.TabIndex = 8;
            this.b_about.Text = "About";
            this.b_about.UseVisualStyleBackColor = true;
            this.b_about.Click += new System.EventHandler(this.b_about_Click);
            // 
            // tb_prefix
            // 
            this.tb_prefix.Location = new System.Drawing.Point(55, 13);
            this.tb_prefix.Name = "tb_prefix";
            this.tb_prefix.Size = new System.Drawing.Size(217, 20);
            this.tb_prefix.TabIndex = 1;
            this.tb_prefix.TextChanged += new System.EventHandler(this.tb_prefix_TextChanged);
            // 
            // tb_suffix
            // 
            this.tb_suffix.Location = new System.Drawing.Point(55, 39);
            this.tb_suffix.Name = "tb_suffix";
            this.tb_suffix.Size = new System.Drawing.Size(217, 20);
            this.tb_suffix.TabIndex = 2;
            this.tb_suffix.TextChanged += new System.EventHandler(this.tb_suffix_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(18, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(36, 13);
            this.label1.TabIndex = 5;
            this.label1.Text = "Prefix:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 42);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(36, 13);
            this.label2.TabIndex = 6;
            this.label2.Text = "Suffix:";
            // 
            // cb_overtime
            // 
            this.cb_overtime.AutoSize = true;
            this.cb_overtime.Location = new System.Drawing.Point(55, 142);
            this.cb_overtime.Name = "cb_overtime";
            this.cb_overtime.Size = new System.Drawing.Size(196, 17);
            this.cb_overtime.TabIndex = 6;
            this.cb_overtime.Text = "Overtime (count up after reaching 0)";
            this.cb_overtime.UseVisualStyleBackColor = true;
            this.cb_overtime.CheckedChanged += new System.EventHandler(this.cb_overtime_CheckedChanged);
            // 
            // cb_nonotify
            // 
            this.cb_nonotify.AutoSize = true;
            this.cb_nonotify.Location = new System.Drawing.Point(55, 166);
            this.cb_nonotify.Name = "cb_nonotify";
            this.cb_nonotify.Size = new System.Drawing.Size(185, 17);
            this.cb_nonotify.TabIndex = 7;
            this.cb_nonotify.Text = "Suppress alert on countdown end";
            this.cb_nonotify.UseVisualStyleBackColor = true;
            this.cb_nonotify.CheckedChanged += new System.EventHandler(this.cb_nonotify_CheckedChanged);
            // 
            // tb_otprefix
            // 
            this.tb_otprefix.Location = new System.Drawing.Point(55, 66);
            this.tb_otprefix.Name = "tb_otprefix";
            this.tb_otprefix.Size = new System.Drawing.Size(217, 20);
            this.tb_otprefix.TabIndex = 3;
            this.tb_otprefix.TextChanged += new System.EventHandler(this.tb_otprefix_TextChanged);
            // 
            // tb_otsuffix
            // 
            this.tb_otsuffix.Location = new System.Drawing.Point(55, 93);
            this.tb_otsuffix.Name = "tb_otsuffix";
            this.tb_otsuffix.Size = new System.Drawing.Size(217, 20);
            this.tb_otsuffix.TabIndex = 4;
            this.tb_otsuffix.TextChanged += new System.EventHandler(this.tb_otsuffix_TextChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(0, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(54, 13);
            this.label3.TabIndex = 11;
            this.label3.Text = "OT Prefix:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(0, 96);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "OT Suffix:";
            // 
            // b_file
            // 
            this.b_file.Location = new System.Drawing.Point(105, 226);
            this.b_file.Name = "b_file";
            this.b_file.Size = new System.Drawing.Size(75, 23);
            this.b_file.TabIndex = 9;
            this.b_file.Text = "Select File...";
            this.b_file.UseVisualStyleBackColor = true;
            this.b_file.Click += new System.EventHandler(this.b_file_Click);
            // 
            // saveFileDialog
            // 
            this.saveFileDialog.DefaultExt = "txt";
            this.saveFileDialog.FileName = "timer.txt";
            this.saveFileDialog.Filter = "(*.txt)|*.txt";
            this.saveFileDialog.InitialDirectory = "s";
            this.saveFileDialog.Title = "Select Timer Text File";
            this.saveFileDialog.FileOk += new System.ComponentModel.CancelEventHandler(this.saveFileDialog_FileOk);
            // 
            // FormOptions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.b_file);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tb_otsuffix);
            this.Controls.Add(this.tb_otprefix);
            this.Controls.Add(this.cb_nonotify);
            this.Controls.Add(this.cb_overtime);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_suffix);
            this.Controls.Add(this.tb_prefix);
            this.Controls.Add(this.b_about);
            this.Controls.Add(this.cb_hidehr);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormOptions";
            this.ShowIcon = false;
            this.Text = "Options";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckBox cb_hidehr;
        private System.Windows.Forms.Button b_about;
        private System.Windows.Forms.TextBox tb_prefix;
        private System.Windows.Forms.TextBox tb_suffix;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cb_overtime;
        private System.Windows.Forms.CheckBox cb_nonotify;
        private System.Windows.Forms.TextBox tb_otprefix;
        private System.Windows.Forms.TextBox tb_otsuffix;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button b_file;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
    }
}