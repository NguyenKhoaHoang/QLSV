using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuanLySV
{
    class SV
    {
        public string MSSV { get; set; }
        public string NameSV { get; set; }
        public bool Gender { get; set; }
        public DateTime NS { get; set; }
        public int ID_Lop { get; set; }
        public static bool Compare_MSSV(SV s1, SV s2)
        {
            if (string.Compare(s1.MSSV, s2.MSSV) > 0) return true;
            return false;
        }
        public static bool Compare_NameSV(SV s1, SV s2)
        {
            if (string.Compare(s1.NameSV, s2.NameSV) > 0) return true;
            return false;
        }
        public static bool Compare_Gender(SV s1, SV s2)
        {
            if (s1.Gender.CompareTo(s2.Gender)>0) return true;
            return false;
        }
        public static bool Compare_NS(SV s1, SV s2)
        {
            if (s1.NS > s2.NS)  return true;
            return false;
        }
        public static bool Compare_ID_Lop(SV s1, SV s2)
        {
            if (s1.ID_Lop > s2.ID_Lop) return true;
            return false;
        }

    }
}
