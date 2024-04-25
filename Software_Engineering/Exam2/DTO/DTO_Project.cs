using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Project
    {
        private string maphieumuon, madocgia, masach, ngaymuon, ngaytra;

        public string _maphieumuon
        {
            get { return maphieumuon; }
            set { maphieumuon = value; }
        }

        public string _madocgia
        {
            get { return _maphieumuon; }
            set { madocgia = value; }
        }

        public string _masach
        {
            get { return masach; }
            set { masach = value; }
        }

        public string _ngaymuon
        {
            get { return ngaymuon; }
            set { ngaymuon = value; }
        }

        public string _ngaytra
        {
            get { return ngaytra; }
            set { ngaytra = value; }
        }

        public DTO_Project(string maphieumuon, string madocgia, string masach, string ngaymuon, string ngaytra)
        {
            this.maphieumuon = maphieumuon;
            this.madocgia = madocgia;
            this.masach = masach;
            this.ngaymuon = ngaymuon;
            this.ngaytra = ngaytra;
        }
    }
}
}
