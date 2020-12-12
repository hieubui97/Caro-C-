using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DeMoCaro
{
    public partial class vanco : Form
    {
        private CaroChess caroChess;
        private Graphics grs;

        
        public vanco()
        {
            InitializeComponent();
            btChoivoinguoi.Click += new EventHandler(PvsP);
            caroChess = new CaroChess();
            caroChess.KhoiTaoMangOCo();
            grs = panelBanCo.CreateGraphics();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }
        private void button2_Click(object sender, EventArgs e)
        {

        }
    
        private void paneBanCo(object sender, PaintEventArgs e)
        {
         
        }

        private void panelMouseClick(object sender, MouseEventArgs e)
        {
            if (!caroChess.SanSang)
                return;
            caroChess.DanhCo(e.X, e.Y, grs);
            if(caroChess.KiemTraChienThang()==true)
            {
                caroChess.KetThucTroChoi();
            }
            if(caroChess.Chedochoi==2)
            {
                caroChess.KhoiDongComputer(grs);
                if (caroChess.KiemTraChienThang() == true)
                {
                    caroChess.KetThucTroChoi();
                }
            }
        }
        private void menuStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }
        private void PvsP(object sender, EventArgs e)
        {
            grs.Clear(panelBanCo.BackColor);
            caroChess.StartPlayVsPlayer(grs);
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btChoivoimay_Click(object sender, EventArgs e)
        {
            grs.Clear(panelBanCo.BackColor);
            caroChess.StartPlayvsComputer(grs);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            caroChess.Redo(grs);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            caroChess.Undo(grs);
        }
            
    }
}
