using System.Drawing;
namespace AI.DeMoCaro
{
    class oCo
    {
        public const int _CHieuRong = 30;
        public const int _ChieuCao = 30;
        private int _Dong;
        private int _Cot;
        private Point _ViTri;
        private int _SoHuu;
        public int Dong
        {
            set { _Dong = value; }
            get { return _Dong; }
        }

        public int Cot
        {
            set { _Cot = value; }
            get { return _Cot; }
        }

        public Point ViTri
        {
            set { _ViTri = value; }
            get { return _ViTri; }
        }

        public int SoHuu
        {
            set { _SoHuu = value; }
            get { return _SoHuu; }
        }
        public oCo()
        {

        }
        public oCo(int dong, int cot, Point vitri, int sohuu)
        {
            _Dong = dong;
            _Cot = cot;
            _ViTri = vitri;
            _SoHuu = sohuu;
        }

    }
}
