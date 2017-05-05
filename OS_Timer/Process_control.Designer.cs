namespace OS_Timer
{
    partial class Process_control
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
            this.button33 = new System.Windows.Forms.Button();
            this.button32 = new System.Windows.Forms.Button();
            this.button31 = new System.Windows.Forms.Button();
            this.button27 = new System.Windows.Forms.Button();
            this.button26 = new System.Windows.Forms.Button();
            this.button25 = new System.Windows.Forms.Button();
            this.button24 = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button33
            // 
            this.button33.Location = new System.Drawing.Point(14, 87);
            this.button33.Name = "button33";
            this.button33.Size = new System.Drawing.Size(179, 23);
            this.button33.TabIndex = 16;
            this.button33.Text = "Notepad.Kill Process";
            this.button33.UseVisualStyleBackColor = true;
            this.button33.Click += new System.EventHandler(this.button33_Click);
            // 
            // button32
            // 
            this.button32.Location = new System.Drawing.Point(14, 64);
            this.button32.Name = "button32";
            this.button32.Size = new System.Drawing.Size(179, 23);
            this.button32.TabIndex = 15;
            this.button32.Text = "Notepad.Move()";
            this.button32.UseVisualStyleBackColor = true;
            this.button32.Click += new System.EventHandler(this.button32_Click);
            // 
            // button31
            // 
            this.button31.Location = new System.Drawing.Point(14, 41);
            this.button31.Name = "button31";
            this.button31.Size = new System.Drawing.Size(179, 23);
            this.button31.TabIndex = 14;
            this.button31.Text = "Notepad.ChangSize(320,240)";
            this.button31.UseVisualStyleBackColor = true;
            this.button31.Click += new System.EventHandler(this.button31_Click);
            // 
            // button27
            // 
            this.button27.Location = new System.Drawing.Point(135, 19);
            this.button27.Name = "button27";
            this.button27.Size = new System.Drawing.Size(63, 23);
            this.button27.TabIndex = 13;
            this.button27.Text = "IE";
            this.button27.UseVisualStyleBackColor = true;
            this.button27.Click += new System.EventHandler(this.button27_Click);
            // 
            // button26
            // 
            this.button26.Location = new System.Drawing.Point(70, 19);
            this.button26.Name = "button26";
            this.button26.Size = new System.Drawing.Size(63, 23);
            this.button26.TabIndex = 12;
            this.button26.Text = "Calcurator";
            this.button26.UseVisualStyleBackColor = true;
            this.button26.Click += new System.EventHandler(this.button26_Click);
            // 
            // button25
            // 
            this.button25.Location = new System.Drawing.Point(6, 19);
            this.button25.Name = "button25";
            this.button25.Size = new System.Drawing.Size(63, 23);
            this.button25.TabIndex = 11;
            this.button25.Text = "Paint";
            this.button25.UseVisualStyleBackColor = true;
            this.button25.Click += new System.EventHandler(this.button25_Click);
            // 
            // button24
            // 
            this.button24.Location = new System.Drawing.Point(14, 19);
            this.button24.Name = "button24";
            this.button24.Size = new System.Drawing.Size(179, 23);
            this.button24.TabIndex = 10;
            this.button24.Text = "Notepad.Start()";
            this.button24.UseVisualStyleBackColor = true;
            this.button24.Click += new System.EventHandler(this.button24_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button25);
            this.groupBox1.Controls.Add(this.button26);
            this.groupBox1.Controls.Add(this.button27);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(206, 50);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Process Start";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button33);
            this.groupBox2.Controls.Add(this.button24);
            this.groupBox2.Controls.Add(this.button31);
            this.groupBox2.Controls.Add(this.button32);
            this.groupBox2.Location = new System.Drawing.Point(12, 78);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 124);
            this.groupBox2.TabIndex = 18;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Process Event";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 208);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(206, 23);
            this.button1.TabIndex = 2;
            this.button1.Text = "Close()";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Process_control
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(223, 244);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Process_control";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Process_control";
            this.TopMost = true;
            this.Load += new System.EventHandler(this.Process_control_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button button33;
        private System.Windows.Forms.Button button32;
        private System.Windows.Forms.Button button31;
        private System.Windows.Forms.Button button27;
        private System.Windows.Forms.Button button26;
        private System.Windows.Forms.Button button25;
        private System.Windows.Forms.Button button24;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button button1;
    }
}