using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Windows.Forms;
namespace DeMoCaro
{
    public enum KetThuc
    {
        HoaCo,
        Player1,
        Player2,
        COM,
    }
    class CaroChess
    {
        public static Pen pen;//but ve cac o
        public static SolidBrush sbtraang;
        public static SolidBrush sbtden;
        public static SolidBrush sbhotPink;
        private oCo[,] _MangOCo;
        private int _LuotDi;
        private int _Chedochoi;
        private BanCo _BanCo;
        private Stack<oCo> Stack_CacNuocDaDi;
        private Stack<oCo> Stack_CacNuocDaXoa;
        private bool _SanSang;
        public int Chedochoi
        {
            get { return _Chedochoi; }
        }
        private KetThuc _ketthuc;
    
        public bool SanSang
        {
            get { return _SanSang; }
        }
        public CaroChess()
        {
            pen = new Pen(Color.Black);
            sbhotPink = new SolidBrush(Color.Lime);
            sbtraang = new SolidBrush(Color.White);
            sbtden = new SolidBrush(Color.Black);
            _BanCo = new BanCo(25,25);
            _MangOCo = new oCo[_BanCo.SoDong, _BanCo.SoCot];
            Stack_CacNuocDaDi = new Stack<oCo>();
            Stack_CacNuocDaXoa = new Stack<oCo>();
            _LuotDi = 1;

           
        }
        public void VeBanCo(Graphics g)
        {
            _BanCo.VeBanCo(g);
        }
        public void KhoiTaoMangOCo()
        {
            for(int i =0; i< _BanCo.SoDong;i++)
            {
                for(int j = 0; j<_BanCo.SoCot;j++)
                {
                    _MangOCo[i, j] = new oCo(i,j,new Point(j*oCo._CHieuRong,i*oCo._ChieuCao),0);
                }
            }
        }

        public bool DanhCo (int MouseX, int MouseY, Graphics g)
        {
            if (MouseX % oCo._CHieuRong == 0|| MouseY %oCo._ChieuCao==0)
                return false;
            int Cot = MouseX / oCo._CHieuRong;
            int Dong = MouseY / oCo._ChieuCao;
          //  _MangOCo[Dong, Cot].SoHuu = 1;
        //    _BanCo.VeQuanCo(g,_MangOCo[Dong,Cot].ViTri,sbtden);
           
            if (_MangOCo[Dong, Cot].SoHuu != 0)
                return false;
            switch(_LuotDi)
            {
                case 1:
                    _MangOCo[Dong, Cot].SoHuu = 1;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbtden);
                    _LuotDi = 2;
                    break;
                case 2:
                    _MangOCo[Dong, Cot].SoHuu = 2;
                    _BanCo.VeQuanCo(g, _MangOCo[Dong, Cot].ViTri, sbtraang);
                    _LuotDi = 1;
                    break;
                default:
                    MessageBox.Show("Có Lỗi !");
                    break;
            }
            Stack_CacNuocDaXoa = new Stack<oCo>();
            oCo oco = new oCo(_MangOCo[Dong,Cot].Dong,_MangOCo[Dong,Cot].Cot, _MangOCo[Dong,Cot].ViTri,_MangOCo[Dong,Cot].SoHuu);
            Stack_CacNuocDaDi.Push(_MangOCo[Dong, Cot]);
            return true;
        }
        
        public void VeLaiQuanCo(Graphics g)
        {
            foreach(oCo oCo in Stack_CacNuocDaDi)
            {
                if(oCo.SoHuu ==1)
                    _BanCo.VeQuanCo(g, oCo.ViTri, sbtden);
                else if(oCo.SoHuu ==2)
                    _BanCo.VeQuanCo(g, oCo.ViTri,sbtraang);
            }
        }
        public void StartPlayVsPlayer(Graphics g)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<oCo>();
            Stack_CacNuocDaXoa = new Stack<oCo>();
            _LuotDi = 1;
            _Chedochoi = 1;
            KhoiTaoMangOCo();
            VeBanCo(g);
        }
        public void StartPlayvsComputer(Graphics g)
        {
            _SanSang = true;
            Stack_CacNuocDaDi = new Stack<oCo>();
            Stack_CacNuocDaXoa = new Stack<oCo>();
            _LuotDi = 2;
            _Chedochoi =2 ;
            KhoiTaoMangOCo();
            VeBanCo(g);
            KhoiDongComputer(g);
           
        }
        //C32DDQW-D29-B20E5A039N
        #region AI
        private long[] MangDiemTanCong =  new long[7] { 0, 3, 24, 192, 1536, 12288, 98304};
        private long[] MangDiemPhongNgu = new long[7] { 0, 1, 9, 81, 729, 6561, 59849 };
        public void KhoiDongComputer(Graphics g)
        {
            if(Stack_CacNuocDaDi.Count==0)
            {
                DanhCo(_BanCo.SoCot / 2 * oCo._CHieuRong + 1, _BanCo.SoDong / 2 * oCo._ChieuCao+ 1, g);
            }
            else
            {
                oCo oco = TimKiemNuocDi();
                DanhCo(oco.ViTri.X + 1, oco.ViTri.Y + 1, g);
            }
        }
        private oCo TimKiemNuocDi()
        {
            oCo ocotimkiem = new oCo();
            long DiemMax=0;
            for (int i = 0; i < _BanCo.SoDong;i++ )
            {
                for(int j =0; j < _BanCo.SoCot;j++)
                {
                    if(_MangOCo[i,j].SoHuu==0)
                    {
                        long DiemTanCong = DiemTC_DuyetDoc(i, j) + DiemTC_DuyetNgang(i, j) + DiemTC_DuyetCheoNguoc(i, j) + DiemTC_DuyetCheoXuoi(i, j);
                        long DiemPhongNgu = DiemPN_DuyetDoc(i, j) + DiemPN_DuyetNgang(i, j) + DiemPN_DuyetCheoNguoc(i, j) + DiemPN_DuyetCheoXuoi(i, j);
                        long DiemTam = DiemTanCong  >DiemPhongNgu ? DiemTanCong : DiemPhongNgu;
                        if(DiemMax<DiemTam)
                        {
                            DiemMax = DiemTam;
                            ocotimkiem = new oCo(_MangOCo[i, j].Dong, _MangOCo[i, j].Cot, _MangOCo[i, j].ViTri, _MangOCo[i, j].SoHuu);
                        }
                    }

                }
            }
                return ocotimkiem;
        }
        #region Tan Cong

        private long DiemTC_DuyetDoc(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrDong + Dem < _BanCo.SoDong;Dem++ )
            {
                if(_MangOCo[crrDong+Dem,crrCot].SoHuu==1)
                {
                    soquanta++;
                }
                else if(_MangOCo[crrDong+Dem,crrCot].SoHuu==2)
                    {
                        soquandich++;
                        break;
                    }
                    else
                        break;
            }
            for (int Dem = 1; Dem < 6 && crrDong - Dem >=0; Dem++)
            {
                if (_MangOCo[crrDong - Dem, crrCot].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong - Dem, crrCot].SoHuu == 2)
                    {
                        soquandich++;
                        break;
                    }
                    else
                        break;
            }
            if(soquandich==2)
                return 0;
            DiemTong -= MangDiemPhongNgu[soquandich + 1];
            DiemTong += MangDiemTanCong[soquanta];
           
            return DiemTong;
        }
        private long DiemTC_DuyetNgang(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[crrDong, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            if (soquandich == 2)
                return 0;
            DiemTong = MangDiemPhongNgu[soquandich + 1];
            DiemTong += MangDiemTanCong[soquanta];
            return DiemTong;
        }
        private long DiemTC_DuyetCheoNguoc(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot && crrDong-Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong-Dem, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong-Dem, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0 && crrDong+Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[crrDong+Dem, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong+Dem, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            if (soquandich == 2)
                return 0;
            DiemTong = MangDiemPhongNgu[soquandich + 1];
            DiemTong += MangDiemTanCong[soquanta];
            return DiemTong;
        }
        private long DiemTC_DuyetCheoXuoi(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta=0;
            int soquandich=0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot && crrDong +Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[crrDong + Dem, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong + Dem, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0 && crrDong - Dem >=0; Dem++)
            {
                if (_MangOCo[crrDong - Dem, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                }
                else if (_MangOCo[crrDong - Dem, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                    break;
                }
                else
                    break;
            }
            if (soquandich == 2)
                return 0;
            DiemTong = MangDiemPhongNgu[soquandich + 1];
            DiemTong += MangDiemTanCong[soquanta];
            return DiemTong;
        }
        #endregion
        #region Phong Ngu
        private long DiemPN_DuyetDoc(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[crrDong + Dem, crrCot].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong + Dem, crrCot].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong - Dem, crrCot].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong - Dem, crrCot].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            if (soquanta == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[soquandich];

            return DiemTong;
        }
        private long DiemPN_DuyetNgang(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot; Dem++)
            {
                if (_MangOCo[crrDong, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            if (soquanta == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[soquandich];
            return DiemTong;
        }
        private long DiemPN_DuyetCheoNguoc(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot && crrDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong - Dem, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong - Dem, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0 && crrDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[crrDong + Dem, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong + Dem, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            if (soquanta == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[soquandich];
            return DiemTong;
        }
        private long DiemPN_DuyetCheoXuoi(int crrDong, int crrCot)
        {
            long DiemTong = 0;
            int soquanta = 0;
            int soquandich = 0;
            for (int Dem = 1; Dem < 6 && crrCot + Dem < _BanCo.SoCot && crrDong + Dem < _BanCo.SoDong; Dem++)
            {
                if (_MangOCo[crrDong + Dem, crrCot + Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong + Dem, crrCot + Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            for (int Dem = 1; Dem < 6 && crrCot - Dem >= 0 && crrDong - Dem >= 0; Dem++)
            {
                if (_MangOCo[crrDong - Dem, crrCot - Dem].SoHuu == 1)
                {
                    soquanta++;
                    break;
                }
                else if (_MangOCo[crrDong - Dem, crrCot - Dem].SoHuu == 2)
                {
                    soquandich++;
                }
                else
                    break;
            }
            if (soquanta == 2)
                return 0;
            DiemTong += MangDiemPhongNgu[soquandich];

            return DiemTong;
        }
        #endregion
        #endregion

        public void Undo(Graphics g)
        {
            if(Stack_CacNuocDaDi.Count !=0)
            {
                
                oCo oco = Stack_CacNuocDaDi.Pop();
                  Stack_CacNuocDaXoa.Push(new oCo(oco.Dong,oco.Cot,oco.ViTri,oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.XoaQuanCo(g, oco.ViTri, sbhotPink);
                if (_LuotDi == 1)
                {
                    _LuotDi = 2;
                }
                else
                    _LuotDi = 1;
            }
                
        }
        public void Redo(Graphics g)
        {
            if (Stack_CacNuocDaXoa.Count != 0)
            {
                oCo oco = Stack_CacNuocDaXoa.Pop();
                Stack_CacNuocDaDi.Push(new oCo(oco.Dong,oco.Cot,oco.ViTri,oco.SoHuu));
                _MangOCo[oco.Dong, oco.Cot].SoHuu = 0;
                _BanCo.VeQuanCo(g, oco.ViTri, oco.SoHuu == 1 ? sbtden : sbtraang);
            }
            if (_LuotDi == 1)
            {
                _LuotDi = 2;
            }
            else
                _LuotDi = 1;

        }
        #region Duyet chien thang;
        public void KetThucTroChoi()
        {
            switch(_ketthuc)
            {
                case KetThuc.HoaCo:
                    MessageBox.Show("Hòa cờ !");
                    break;
                case KetThuc.Player1:
                    MessageBox.Show("Người chơi số 1 thắng !");
                    break;
                case KetThuc.Player2:
                    MessageBox.Show("Người chơi số 2 thắng !");
                    break;
                case KetThuc.COM:
                    MessageBox.Show("Máy Thắng !");
                    break;
            }
            _SanSang = false;
        }
        public bool KiemTraChienThang()
        {
            if(Stack_CacNuocDaDi.Count== _BanCo.SoCot * _BanCo.SoDong)
            {
                _ketthuc = KetThuc.HoaCo;
                
                return true;
            }
            foreach(oCo oco in Stack_CacNuocDaDi)
            {
                if (DuyeDoc(oco.Dong, oco.Cot, oco.SoHuu) || DuyeNgang(oco.Dong, oco.Cot, oco.SoHuu) || DuyeCheoNguoc(oco.Dong, oco.Cot, oco.SoHuu) || DuyetCheoXuoi(oco.Dong, oco.Cot, oco.SoHuu))
                {
                    _ketthuc = oco.SoHuu == 1 ? KetThuc.Player1 : KetThuc.Player2;
                    return true;
                }
            }
            return false;
        }
        private bool DuyeDoc(int crrDong, int crrCot, int CrrSohuu)
        {
            if (crrDong > _BanCo.SoDong - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5;Dem++ )
            {
                if (_MangOCo[crrDong + Dem, crrCot].SoHuu != CrrSohuu)
                    return false;
            }
            if (crrDong == 0|| crrDong+Dem== _BanCo.SoDong)
                return true;
            if (_MangOCo[crrDong - 1, crrCot].SoHuu == 0 || _MangOCo[crrDong + Dem, crrCot].SoHuu == 0)
                return true;
             return false;
        }
        private bool DuyeNgang(int crrDong, int crrCot, int CrrSohuu)
        {
            if (crrCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[crrDong, crrCot+Dem].SoHuu != CrrSohuu)
                    return false;
            }
            if (crrCot == 0 || crrCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[crrDong, crrCot-1].SoHuu == 0 || _MangOCo[crrDong, crrCot +Dem].SoHuu == 0)
                return true;
            return false;
        }
        private bool DuyetCheoXuoi(int crrDong, int crrCot, int CrrSohuu)
        {
            if (crrDong>_BanCo.SoDong-5||crrCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[crrDong +Dem, crrCot + Dem].SoHuu != CrrSohuu)
                    return false;
            }
            if (crrDong==0|| crrDong+Dem==_BanCo.SoDong|| crrCot == 0 || crrCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[crrDong-1, crrCot - 1].SoHuu == 0 || _MangOCo[crrDong+Dem, crrCot + Dem].SoHuu == 0)
                return true;
            return false;
        }

        private bool DuyeCheoNguoc(int crrDong, int crrCot, int CrrSohuu)
        {
            if (crrDong<4 || crrCot > _BanCo.SoCot - 5)
                return false;
            int Dem;
            for (Dem = 1; Dem < 5; Dem++)
            {
                if (_MangOCo[crrDong -Dem, crrCot + Dem].SoHuu != CrrSohuu)
                    return false;
            }
            if (crrDong == 4 || crrDong == _BanCo.SoDong - 1|| crrCot ==0|| crrCot+Dem ==_BanCo.SoCot)
                return true;
            if (crrCot == 0 || crrCot + Dem == _BanCo.SoCot)
                return true;
            if (_MangOCo[crrDong +1, crrCot - 1].SoHuu == 0 || _MangOCo[crrDong-Dem, crrCot + Dem].SoHuu == 0)
                return true;
            return false;
        }
        #endregion
    }
}
