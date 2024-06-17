using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharp_HinhChuNhat_Class
{
    internal class hinhchunhat
    {
        public double chieucao;
        public double chieurong;

        public double Tinhdientich()
        {
            return chieucao * chieurong;
        }
        public double tinhchuvi()
        {
           return (chieucao + chieurong) * 2;
        }

    }
}
