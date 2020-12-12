namespace DeMoCaro
{
    partial class vanco
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(vanco));
            this.btChoivoimay = new System.Windows.Forms.Button();
            this.panelBanCo = new System.Windows.Forms.Panel();
            this.btChoivoinguoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btChoivoimay
            // 
            this.btChoivoimay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btChoivoimay.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoivoimay.Location = new System.Drawing.Point(16, 46);
            this.btChoivoimay.Name = "btChoivoimay";
            this.btChoivoimay.Size = new System.Drawing.Size(97, 44);
            this.btChoivoimay.TabIndex = 4;
            this.btChoivoimay.Text = "P vs Com";
            this.btChoivoimay.UseVisualStyleBackColor = true;
            this.btChoivoimay.Click += new System.EventHandler(this.btChoivoimay_Click);
            // 
            // panelBanCo
            // 
            this.panelBanCo.BackColor = System.Drawing.Color.CadetBlue;
            this.panelBanCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBanCo.ForeColor = System.Drawing.Color.Azure;
            this.panelBanCo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelBanCo.Location = new System.Drawing.Point(1, 3);
            this.panelBanCo.Name = "panelBanCo";
            this.panelBanCo.Size = new System.Drawing.Size(1231, 751);
            this.panelBanCo.TabIndex = 8;
            this.panelBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.paneBanCo);
            this.panelBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMouseClick);
            // 
            // btChoivoinguoi
            // 
            this.btChoivoinguoi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btChoivoinguoi.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoivoinguoi.Location = new System.Drawing.Point(16, 148);
            this.btChoivoinguoi.Name = "btChoivoinguoi";
            this.btChoivoinguoi.Size = new System.Drawing.Size(97, 44);
            this.btChoivoinguoi.TabIndex = 5;
            this.btChoivoinguoi.Text = "P vs P";
            this.btChoivoinguoi.UseVisualStyleBackColor = true;
            this.btChoivoinguoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(16, 233);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(97, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(16, 314);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(97, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "restore";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(16, 416);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(97, 41);
            this.button3.TabIndex = 13;
            this.button3.Text = "Exit";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.MediumSeaGreen;
            this.panel1.Controls.Add(this.btChoivoimay);
            this.panel1.Controls.Add(this.button3);
            this.panel1.Controls.Add(this.btChoivoinguoi);
            this.panel1.Controls.Add(this.button1);
            this.panel1.Controls.Add(this.button2);
            this.panel1.Location = new System.Drawing.Point(1238, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(125, 751);
            this.panel1.TabIndex = 14;
            // 
            // vanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1353, 732);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panelBanCo);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "vanco";
            this.Opacity = 0.95D;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Chơi Cờ Không?";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }
        #endregion

        private System.Windows.Forms.Button btChoivoimay;
        private System.Windows.Forms.Panel panelBanCo;
        private System.Windows.Forms.Button btChoivoinguoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Panel panel1;
    }
}

