namespace StreamTimer
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.btn_start = new System.Windows.Forms.Button();
            this.btn_reset = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.radiodown = new System.Windows.Forms.RadioButton();
            this.radioup = new System.Windows.Forms.RadioButton();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.second = new System.Windows.Forms.RichTextBox();
            this.minute = new System.Windows.Forms.RichTextBox();
            this.hour = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.b_options = new System.Windows.Forms.Button();
            this.l_alert = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btn_start
            // 
            this.btn_start.Location = new System.Drawing.Point(13, 126);
            this.btn_start.Name = "btn_start";
            this.btn_start.Size = new System.Drawing.Size(75, 23);
            this.btn_start.TabIndex = 5;
            this.btn_start.Text = "Start";
            this.btn_start.UseVisualStyleBackColor = true;
            this.btn_start.Click += new System.EventHandler(this.btn_start_Click);
            // 
            // btn_reset
            // 
            this.btn_reset.Location = new System.Drawing.Point(197, 126);
            this.btn_reset.Name = "btn_reset";
            this.btn_reset.Size = new System.Drawing.Size(75, 23);
            this.btn_reset.TabIndex = 7;
            this.btn_reset.Text = "Reset";
            this.btn_reset.UseVisualStyleBackColor = true;
            this.btn_reset.Click += new System.EventHandler(this.btn_reset_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(105, 126);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(75, 23);
            this.btn_stop.TabIndex = 6;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // radiodown
            // 
            this.radiodown.AutoSize = true;
            this.radiodown.Checked = true;
            this.radiodown.ForeColor = System.Drawing.SystemColors.ControlText;
            this.radiodown.Location = new System.Drawing.Point(13, 100);
            this.radiodown.Name = "radiodown";
            this.radiodown.Size = new System.Drawing.Size(84, 17);
            this.radiodown.TabIndex = 3;
            this.radiodown.TabStop = true;
            this.radiodown.Text = "Count Down";
            this.radiodown.UseVisualStyleBackColor = true;
            this.radiodown.CheckedChanged += new System.EventHandler(this.radiodown_CheckedChanged);
            // 
            // radioup
            // 
            this.radioup.AutoSize = true;
            this.radioup.Location = new System.Drawing.Point(105, 100);
            this.radioup.Name = "radioup";
            this.radioup.Size = new System.Drawing.Size(70, 17);
            this.radioup.TabIndex = 4;
            this.radioup.Text = "Count Up";
            this.radioup.UseVisualStyleBackColor = true;
            this.radioup.CheckedChanged += new System.EventHandler(this.radioup_CheckedChanged);
            // 
            // timer
            // 
            this.timer.Interval = 10;
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // second
            // 
            this.second.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.second.Location = new System.Drawing.Point(197, 13);
            this.second.Margin = new System.Windows.Forms.Padding(10);
            this.second.MaxLength = 4;
            this.second.Multiline = false;
            this.second.Name = "second";
            this.second.Size = new System.Drawing.Size(75, 25);
            this.second.TabIndex = 2;
            this.second.Text = "0";
            this.second.Click += new System.EventHandler(this.second_Focus);
            this.second.TextChanged += new System.EventHandler(this.second_TextChanged);
            this.second.Enter += new System.EventHandler(this.second_Focus);
            this.second.KeyDown += new System.Windows.Forms.KeyEventHandler(this.second_KeyDown);
            this.second.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.second_KeyPress);
            this.second.KeyUp += new System.Windows.Forms.KeyEventHandler(this.second_KeyUp);
            this.second.Leave += new System.EventHandler(this.second_Leave);
            // 
            // minute
            // 
            this.minute.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minute.Location = new System.Drawing.Point(105, 13);
            this.minute.Margin = new System.Windows.Forms.Padding(10);
            this.minute.MaxLength = 4;
            this.minute.Multiline = false;
            this.minute.Name = "minute";
            this.minute.Size = new System.Drawing.Size(75, 25);
            this.minute.TabIndex = 1;
            this.minute.Text = "0";
            this.minute.Click += new System.EventHandler(this.minute_Focus);
            this.minute.TextChanged += new System.EventHandler(this.minute_TextChanged);
            this.minute.Enter += new System.EventHandler(this.minute_Focus);
            this.minute.KeyDown += new System.Windows.Forms.KeyEventHandler(this.minute_KeyDown);
            this.minute.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.minute_KeyPress);
            this.minute.KeyUp += new System.Windows.Forms.KeyEventHandler(this.minute_KeyUp);
            this.minute.Leave += new System.EventHandler(this.minute_Leave);
            // 
            // hour
            // 
            this.hour.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hour.Location = new System.Drawing.Point(13, 13);
            this.hour.Margin = new System.Windows.Forms.Padding(10);
            this.hour.MaxLength = 4;
            this.hour.Multiline = false;
            this.hour.Name = "hour";
            this.hour.Size = new System.Drawing.Size(75, 25);
            this.hour.TabIndex = 0;
            this.hour.Text = "0";
            this.hour.Click += new System.EventHandler(this.hour_Focus);
            this.hour.TextChanged += new System.EventHandler(this.hour_TextChanged);
            this.hour.Enter += new System.EventHandler(this.hour_Focus);
            this.hour.KeyDown += new System.Windows.Forms.KeyEventHandler(this.hour_KeyDown);
            this.hour.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.hour_KeyPress);
            this.hour.KeyUp += new System.Windows.Forms.KeyEventHandler(this.hour_KeyUp);
            this.hour.Leave += new System.EventHandler(this.hour_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Hours";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(102, 48);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "Minutes";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(194, 48);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seconds";
            // 
            // b_options
            // 
            this.b_options.Location = new System.Drawing.Point(197, 97);
            this.b_options.Name = "b_options";
            this.b_options.Size = new System.Drawing.Size(75, 23);
            this.b_options.TabIndex = 11;
            this.b_options.Text = "Options";
            this.b_options.UseVisualStyleBackColor = true;
            this.b_options.Click += new System.EventHandler(this.options_Click);
            // 
            // l_alert
            // 
            this.l_alert.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.l_alert.AutoSize = true;
            this.l_alert.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.l_alert.ForeColor = System.Drawing.Color.Red;
            this.l_alert.Location = new System.Drawing.Point(102, 70);
            this.l_alert.Name = "l_alert";
            this.l_alert.Size = new System.Drawing.Size(78, 16);
            this.l_alert.TabIndex = 12;
            this.l_alert.Text = "OVERTIME";
            this.l_alert.Visible = false;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(284, 161);
            this.Controls.Add(this.l_alert);
            this.Controls.Add(this.b_options);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.hour);
            this.Controls.Add(this.minute);
            this.Controls.Add(this.second);
            this.Controls.Add(this.radioup);
            this.Controls.Add(this.radiodown);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_reset);
            this.Controls.Add(this.btn_start);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FormMain";
            this.Text = "Stream Timer by Duilio";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.Shown += new System.EventHandler(this.FormMain_Show);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_start;
        private System.Windows.Forms.Button btn_reset;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.RadioButton radiodown;
        private System.Windows.Forms.RadioButton radioup;
        private System.Windows.Forms.Timer timer;
        private System.Windows.Forms.RichTextBox second;
        private System.Windows.Forms.RichTextBox minute;
        private System.Windows.Forms.RichTextBox hour;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button b_options;
        private System.Windows.Forms.Label l_alert;
    }
}

