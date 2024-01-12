using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap02
{
    class SanPham
    {
        private string _ten;
        private double _giamua;

        public SanPham()
        {
        }
        public SanPham(string ten, double giamua)
        {
            this._ten = ten;
            this._giamua = giamua;
        }
        public string Ten
        {
            get { return _ten; }
            set { _ten = value; }
        }
        public double GiaMua
        {
            get { return _giamua; }
            set
            {
                if (value >= 0)
                    _giamua = value;
            }
        }
        public virtual double TinhGiaBan()
        {
            return 0;
        }
        public virtual string InChiTiet()
        {
            return _ten;
        }
        public virtual void Nhap()
        {
            Console.Write("Cho biet ten san phan: ");
            _ten = Console.ReadLine();
            Console.Write("Cho biet gia mua: ");
            _giamua = double.Parse(Console.ReadLine());
        }
    }
    class Socola : SanPham
    {
        private double _loinhuan;
        public Socola() : base() { }
        public Socola (string ten, double giamua) : base(ten,giamua)
        {
            _loinhuan = giamua * 0.2;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan;
        }
        public override string InChiTiet()
        {
            return string.Format("ten: {0} - Gia Ban: {1: #,##0}", Ten, TinhGiaBan());
        }
        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.2;
        }
    }
    class NuocUong : SanPham
    {
        private double _loinhuan;
        private double _ChiPhiGiuLanh;
        public NuocUong() : base() { }
        public NuocUong(string ten, double giamua): base(ten, giamua)
        {
            _loinhuan = giamua * 0.15;
            _ChiPhiGiuLanh = giamua * 0.1;
        }
        public override double TinhGiaBan()
        {
            return GiaMua + _loinhuan + _ChiPhiGiuLanh;
        }
        public override string InChiTiet()
        {
            return string.Format("Ten: {0} - Gia ban: {1: #,##0}", Ten, TinhGiaBan());
        }
        public override void Nhap()
        {
            base.Nhap();
            _loinhuan = GiaMua * 0.15;
            _ChiPhiGiuLanh = GiaMua * 0.1;
        }
    }
    class QuanLySanPham
    {
        private string _ten;
        private SanPham[] dssp;
        private int n;
        public QuanLySanPham()
        {
            _ten = "Cua hang ban le: ";
            dssp = new SanPham[100];
            n = 0;
        }
        public QuanLySanPham(int size)
        {

            _ten = "Cua hang ban le: ";
            dssp = new SanPham[size];
            n = 0;
        }
        public void nhap()
        {
            int chon;
            SanPham sp;
            while(true)
            {
                Console.Write("Ban muon them san pham loai nao(1.socola  - 2.NuocUong: ");
                chon = int.Parse(Console.ReadLine());
                switch (chon)
                {
                    case 1:
                        sp = new Socola();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                    case 2:
                        sp = new NuocUong();
                        sp.Nhap();
                        dssp[n++] = sp;
                        break;
                }
                Console.Write("Ban co tiep tuc?(0.thoat):");
                chon = int.Parse(Console.ReadLine());
                if ( chon == 0)
                    break;
            }    
        }
        public void InDanhSachSP()
        {
            Console.WriteLine("******Ten Cua Hang:" + _ten);
            Console.WriteLine("*******Danh sach cac san pham*******");
            for ( int i = 0;  i < n; i ++)
            {
                Console.WriteLine(dssp[i].InChiTiet());
            }    
        }
    }
    class Program
    {
        
        static void Main(string[] args)
        {
            QuanLySanPham q1 = new QuanLySanPham();
            Console.WriteLine("-----CHUONG TRINH QUAN LY CUA HANG BAN LE-------");
            q1.nhap();
            q1.InDanhSachSP();
            Console.ReadLine();
        }
    }
}
