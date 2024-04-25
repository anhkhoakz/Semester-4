using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DTO
{
    public class DTO_Project
    {
        private string phieuID, docgiaID, sachID, ngaymuon, ngaytra;

        public string _phieuID
        {
            get { return phieuID; }
            set { phieuID = value; }
        }

        public string _docgiaID
        {
            get { return _phieuID; }
            set { docgiaID = value; }
        }

        public string _sachID
        {
            get { return sachID; }
            set { sachID = value; }
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

        public DTO_Project(string phieuID, string docgiaID, string sachID, string ngaymuon, string ngaytra) 
        {
            this.phieuID = phieuID;
            this.docgiaID = docgiaID;
            this.sachID = sachID;
            this.ngaymuon = ngaymuon;
            this.ngaytra = ngaytra;
        }
    }
}