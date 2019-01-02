namespace SnowflakeGenerator
{
    partial class Form1
    {
        /// <summary>
        /// Erforderliche Designervariable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Verwendete Ressourcen bereinigen.
        /// </summary>
        /// <param name="disposing">True, wenn verwaltete Ressourcen gelöscht werden sollen; andernfalls False.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Vom Windows Form-Designer generierter Code

        /// <summary>
        /// Erforderliche Methode für die Designerunterstützung.
        /// Der Inhalt der Methode darf nicht mit dem Code-Editor geändert werden.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.pBx_main = new System.Windows.Forms.PictureBox();
            this.lbl_01 = new System.Windows.Forms.Label();
            this.tBx_seed = new System.Windows.Forms.TextBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.tmr_16ms = new System.Windows.Forms.Timer(this.components);
            this.btn_new_Seed = new System.Windows.Forms.Button();
            this.btn_stop = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pBx_main)).BeginInit();
            this.SuspendLayout();
            // 
            // pBx_main
            // 
            this.pBx_main.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pBx_main.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pBx_main.Location = new System.Drawing.Point(-2, -1);
            this.pBx_main.Name = "pBx_main";
            this.pBx_main.Size = new System.Drawing.Size(843, 524);
            this.pBx_main.TabIndex = 0;
            this.pBx_main.TabStop = false;
            this.pBx_main.Paint += new System.Windows.Forms.PaintEventHandler(this.pBx_main_Paint);
            // 
            // lbl_01
            // 
            this.lbl_01.AutoSize = true;
            this.lbl_01.Location = new System.Drawing.Point(12, 9);
            this.lbl_01.Name = "lbl_01";
            this.lbl_01.Size = new System.Drawing.Size(32, 13);
            this.lbl_01.TabIndex = 1;
            this.lbl_01.Text = "Seed";
            // 
            // tBx_seed
            // 
            this.tBx_seed.Location = new System.Drawing.Point(53, 6);
            this.tBx_seed.Name = "tBx_seed";
            this.tBx_seed.Size = new System.Drawing.Size(100, 20);
            this.tBx_seed.TabIndex = 2;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(53, 191);
            this.Btn_Generate.Name = "Btn_Generate";
            this.Btn_Generate.Size = new System.Drawing.Size(100, 23);
            this.Btn_Generate.TabIndex = 3;
            this.Btn_Generate.Text = "Generate New";
            this.Btn_Generate.UseVisualStyleBackColor = true;
            this.Btn_Generate.Click += new System.EventHandler(this.Btn_Generate_Click);
            // 
            // tmr_16ms
            // 
            this.tmr_16ms.Enabled = true;
            this.tmr_16ms.Interval = 1000;
            this.tmr_16ms.Tick += new System.EventHandler(this.tmr_16ms_Tick);
            // 
            // btn_new_Seed
            // 
            this.btn_new_Seed.Location = new System.Drawing.Point(53, 32);
            this.btn_new_Seed.Name = "btn_new_Seed";
            this.btn_new_Seed.Size = new System.Drawing.Size(100, 23);
            this.btn_new_Seed.TabIndex = 4;
            this.btn_new_Seed.Text = "Random Seed";
            this.btn_new_Seed.UseVisualStyleBackColor = true;
            this.btn_new_Seed.Click += new System.EventHandler(this.btn_new_Seed_Click);
            // 
            // btn_stop
            // 
            this.btn_stop.Location = new System.Drawing.Point(53, 220);
            this.btn_stop.Name = "btn_stop";
            this.btn_stop.Size = new System.Drawing.Size(100, 23);
            this.btn_stop.TabIndex = 5;
            this.btn_stop.Text = "Stop";
            this.btn_stop.UseVisualStyleBackColor = true;
            this.btn_stop.Click += new System.EventHandler(this.btn_stop_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(53, 61);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Seed";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(53, 87);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 9;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 90);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 8;
            this.label2.Text = "Seed";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(53, 113);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 11;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 116);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(32, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Seed";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(53, 139);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(100, 20);
            this.textBox4.TabIndex = 13;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 142);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 12;
            this.label4.Text = "Seed";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(53, 165);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(100, 20);
            this.textBox5.TabIndex = 15;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 168);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(32, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Seed";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 519);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_stop);
            this.Controls.Add(this.btn_new_Seed);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.tBx_seed);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.pBx_main);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.pBx_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBx_main;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.TextBox tBx_seed;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Timer tmr_16ms;
        private System.Windows.Forms.Button btn_new_Seed;
        private System.Windows.Forms.Button btn_stop;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label5;
    }
}

