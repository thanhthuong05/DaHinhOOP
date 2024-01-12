using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BaiTap_BanKing
{
    class Program
    {
        static void Main(string[] args)
        {
            Account ac1 = new SavingsAccount();
            ac1.NapTien(1000);
            ac1.RutTien(100);
            ac1.InHoaDon();
            // Creating checking account object
            Account ac2 = new CheckingAccount(5000);
            ac2.NapTien(1000);
            ac2.RutTien(3000);
            ac2.InHoaDon();

            Console.ReadLine();
        }
    }
}
