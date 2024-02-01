using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab1_F1
{
    internal static class General
    {
        //Chuyen doi dd/mm/yyyy sang yyyy/mm/dd
        public static String convertDMY2YMD(String dmy)
        {
            string[] t = dmy.Split('/');
            string res = t[2] + "/" + t[1] + "/" + t[0];
            return res;
        }
    }
}
