namespace FireGame_Assign_F
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
            this.Start = new System.Windows.Forms.Button();
            this.load1 = new System.Windows.Forms.Button();
            this.spin1 = new System.Windows.Forms.Button();
            this.shoot1 = new System.Windows.Forms.Button();
            this.shoot_away = new System.Windows.Forms.Button();
            this.exit_now = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Start
            // 
            this.Start.BackColor = System.Drawing.Color.Chartreuse;
            this.Start.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Start.Location = new System.Drawing.Point(12, 456);
            this.Start.Name = "Start";
            this.Start.Size = new System.Drawing.Size(120, 38);
            this.Start.TabIndex = 1;
            this.Start.Text = "Start";
            this.Start.UseVisualStyleBackColor = false;
            this.Start.Click += new System.EventHandler(this.Start_Click);
            // 
            // load1
            // 
            this.load1.BackColor = System.Drawing.Color.Chartreuse;
            this.load1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.load1.Location = new System.Drawing.Point(148, 456);
            this.load1.Name = "load1";
            this.load1.Size = new System.Drawing.Size(120, 38);
            this.load1.TabIndex = 2;
            this.load1.Text = "Load";
            this.load1.UseVisualStyleBackColor = false;
            this.load1.Click += new System.EventHandler(this.load1_Click);
            // 
            // spin1
            // 
            this.spin1.BackColor = System.Drawing.Color.Chartreuse;
            this.spin1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spin1.Location = new System.Drawing.Point(289, 456);
            this.spin1.Name = "spin1";
            this.spin1.Size = new System.Drawing.Size(120, 38);
            this.spin1.TabIndex = 3;
            this.spin1.Text = "Spin";
            this.spin1.UseVisualStyleBackColor = false;
            this.spin1.Click += new System.EventHandler(this.spin1_Click);
            // 
            // shoot1
            // 
            this.shoot1.BackColor = System.Drawing.Color.Chartreuse;
            this.shoot1.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot1.Location = new System.Drawing.Point(431, 456);
            this.shoot1.Name = "shoot1";
            this.shoot1.Size = new System.Drawing.Size(120, 38);
            this.shoot1.TabIndex = 4;
            this.shoot1.Text = "Shoot";
            this.shoot1.UseVisualStyleBackColor = false;
            this.shoot1.Click += new System.EventHandler(this.shoot1_Click);
            // 
            // shoot_away
            // 
            this.shoot_away.BackColor = System.Drawing.Color.Chartreuse;
            this.shoot_away.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shoot_away.Location = new System.Drawing.Point(557, 456);
            this.shoot_away.Name = "shoot_away";
            this.shoot_away.Size = new System.Drawing.Size(120, 38);
            this.shoot_away.TabIndex = 5;
            this.shoot_away.Text = "Shoot Away";
            this.shoot_away.UseVisualStyleBackColor = false;
            this.shoot_away.Click += new System.EventHandler(this.shoot_away_Click);
            // 
            // exit_now
            // 
            this.exit_now.BackColor = System.Drawing.Color.Chartreuse;
            this.exit_now.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit_now.Location = new System.Drawing.Point(697, 456);
            this.exit_now.Name = "exit_now";
            this.exit_now.Size = new System.Drawing.Size(120, 38);
            this.exit_now.TabIndex = 6;
            this.exit_now.Text = "Exit";
            this.exit_now.UseVisualStyleBackColor = false;
            this.exit_now.Click += new System.EventHandler(this.exit_now_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(844, 427);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkViolet;
            this.ClientSize = new System.Drawing.Size(891, 525);
            this.Controls.Add(this.exit_now);
            this.Controls.Add(this.shoot_away);
            this.Controls.Add(this.shoot1);
            this.Controls.Add(this.spin1);
            this.Controls.Add(this.load1);
            this.Controls.Add(this.Start);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Start;
        private System.Windows.Forms.Button load1;
        private System.Windows.Forms.Button spin1;
        private System.Windows.Forms.Button shoot1;
        private System.Windows.Forms.Button shoot_away;
        private System.Windows.Forms.Button exit_now;
    }
}

