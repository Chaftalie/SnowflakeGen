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
            this.tBx = new System.Windows.Forms.TextBox();
            this.Btn_Generate = new System.Windows.Forms.Button();
            this.tmr_16ms = new System.Windows.Forms.Timer(this.components);
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
            this.lbl_01.Size = new System.Drawing.Size(35, 13);
            this.lbl_01.TabIndex = 1;
            this.lbl_01.Text = "label1";
            // 
            // tBx
            // 
            this.tBx.Location = new System.Drawing.Point(53, 6);
            this.tBx.Name = "tBx";
            this.tBx.Size = new System.Drawing.Size(100, 20);
            this.tBx.TabIndex = 2;
            // 
            // Btn_Generate
            // 
            this.Btn_Generate.Location = new System.Drawing.Point(53, 32);
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
            this.tmr_16ms.Interval = 16;
            this.tmr_16ms.Tick += new System.EventHandler(this.tmr_16ms_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(838, 519);
            this.Controls.Add(this.Btn_Generate);
            this.Controls.Add(this.tBx);
            this.Controls.Add(this.lbl_01);
            this.Controls.Add(this.pBx_main);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pBx_main)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pBx_main;
        private System.Windows.Forms.Label lbl_01;
        private System.Windows.Forms.TextBox tBx;
        private System.Windows.Forms.Button Btn_Generate;
        private System.Windows.Forms.Timer tmr_16ms;
    }
}

