using System.Drawing;
namespace AI.DeMoCaro
{
    class BanCo
    {
        private int _SoDong { set; get; }
        private int _SoCot { set; get; }
        public int SoDong
        {
            get { return _SoDong; }
        }
        public int SoCot
        {
            get { return _SoCot; }
        }
        public BanCo()
        {
            _SoDong = 0;
            _SoCot = 0;
        }
        public BanCo(int soDong, int soCot)
        {
            _SoDong = soDong;
            _SoCot = soCot;
        }
        public void VeBanCo(Graphics g)
        {
            for (int i = 0; i <= _SoCot; i++)
            {
                g.DrawLine(CaroChess.pen, i * oCo._CHieuRong, 0, i * oCo._CHieuRong, _SoDong * oCo._ChieuCao);// ve cac cot
            }
            for (int j = 0; j <= _SoCot; j++)
            {
                g.DrawLine(CaroChess.pen, 0, j * oCo._ChieuCao, _SoCot * oCo._CHieuRong, j * oCo._ChieuCao); //ve cac dong
            }
        }
        public void VeQuanCo(Graphics g, Point point, SolidBrush sb)
        {

            g.FillEllipse(sb, point.X + 2, point.Y + 2, oCo._CHieuRong - 4, oCo._ChieuCao - 4);// ve quan co

        }

        public void XoaQuanCo(Graphics g, Point point, SolidBrush sb)
        {
            g.FillRectangle(sb, point.X + 2, point.Y + 2, oCo._CHieuRong - 4, oCo._ChieuCao - 4);// xoa quan co
        }
    }

}
