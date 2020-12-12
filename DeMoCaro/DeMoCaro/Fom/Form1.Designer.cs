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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.btChoivoimay = new System.Windows.Forms.Button();
            this.panelBanCo = new System.Windows.Forms.Panel();
            this.btChoivoinguoi = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.menuStrip1.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.HorizontalStackWithOverflow;
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(7, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(822, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            this.menuStrip1.ItemClicked += new System.Windows.Forms.ToolStripItemClickedEventHandler(this.menuStrip1_ItemClicked);
            // 
            // btChoivoimay
            // 
            this.btChoivoimay.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btChoivoimay.Font = new System.Drawing.Font("Showcard Gothic", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoivoimay.Location = new System.Drawing.Point(673, 51);
            this.btChoivoimay.Name = "btChoivoimay";
            this.btChoivoimay.Size = new System.Drawing.Size(118, 44);
            this.btChoivoimay.TabIndex = 4;
            this.btChoivoimay.Text = "Chơi với Máy";
            this.btChoivoimay.UseVisualStyleBackColor = true;
            this.btChoivoimay.Click += new System.EventHandler(this.btChoivoimay_Click);
            // 
            // panelBanCo
            // 
            this.panelBanCo.BackColor = System.Drawing.Color.Lime;
            this.panelBanCo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.panelBanCo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.panelBanCo.Location = new System.Drawing.Point(12, 37);
            this.panelBanCo.Name = "panelBanCo";
            this.panelBanCo.Size = new System.Drawing.Size(626, 626);
            this.panelBanCo.TabIndex = 8;
            this.panelBanCo.Paint += new System.Windows.Forms.PaintEventHandler(this.paneBanCo);
            this.panelBanCo.MouseClick += new System.Windows.Forms.MouseEventHandler(this.panelMouseClick);
            // 
            // btChoivoinguoi
            // 
            this.btChoivoinguoi.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.btChoivoinguoi.Font = new System.Drawing.Font("Swis721 Hv BT", 8.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btChoivoinguoi.Location = new System.Drawing.Point(673, 153);
            this.btChoivoinguoi.Name = "btChoivoinguoi";
            this.btChoivoinguoi.Size = new System.Drawing.Size(120, 44);
            this.btChoivoinguoi.TabIndex = 5;
            this.btChoivoinguoi.Text = "P vs P";
            this.btChoivoinguoi.UseVisualStyleBackColor = true;
            this.btChoivoinguoi.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(675, 267);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(118, 41);
            this.button1.TabIndex = 10;
            this.button1.Text = "Xóa nước đã đi";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(673, 381);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(118, 41);
            this.button2.TabIndex = 11;
            this.button2.Text = "Khôi phục nước xóa";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click_1);
            // 
            // vanco
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.LawnGreen;
            this.ClientSize = new System.Drawing.Size(822, 675);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btChoivoimay);
            this.Controls.Add(this.panelBanCo);
            this.Controls.Add(this.btChoivoinguoi);
            this.Controls.Add(this.menuStrip1);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "vanco";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Ván cờ ";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.Button btChoivoimay;
        private System.Windows.Forms.Panel panelBanCo;
        private System.Windows.Forms.Button btChoivoinguoi;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
    }
}

