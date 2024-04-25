using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Project
    {
        private string masach, tensach, tacgia;
        private int soluong;

        public string _masach
        {
            get { return masach; }
            set { masach = value; }
        }

        public string _tensach
        {
            get { return tensach; }
            set { tensach = value; }
        }

        public string _tacgia
        {
            get { return tacgia; }
            set { tacgia = value; }
        }

        public int _soluong
        {
            get { return soluong; }
            set { soluong = value; }
        }

        public DTO_Project(string masach, string tensach, string tacgia, int soluong)
        {
            this.masach = masach;
            this.tensach = tensach;
            this.tacgia = tacgia;
            this.soluong = soluong;
        }
    }
}
