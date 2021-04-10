using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySV
{
    
    class CSDL_OOP
    {
        public delegate bool Compare(SV s1, SV s2);
        private static CSDL_OOP _instance;
        public static CSDL_OOP Instance
        {
            get
            {
                if (_instance == null) _instance = new CSDL_OOP();
                return _instance;
            }
            private set { }
        }
        private CSDL_OOP()
        {

        }
        public List<SV> GetAllSV()
        {
            List<SV> data = new List<SV>();
            foreach (DataRow i in CSDL.Instance.DSSV.Rows)
                data.Add(GetSV(i));
            return data;
        }
        public SV GetSV(DataRow i)
        {
            return new SV
            {
                MSSV = i["MSSV"].ToString(),
                NameSV = i["NameSV"].ToString(),
                Gender = Convert.ToBoolean(i["Gender"].ToString()),
                NS = Convert.ToDateTime(i["NS"].ToString()),
                ID_Lop= Convert.ToInt32(i["ID_lop"].ToString())
            };
        }
        public List<LSH> GetAllLopSH()
        {
            List<LSH> data = new List<LSH>();
            foreach(DataRow i in CSDL.Instance.DSLopSH.Rows)
            {
                data.Add(GetLopSH(i));
            }
            return data;
        }
        public LSH GetLopSH(DataRow i)
        {
            return new LSH
            {
                ID_Lop = Convert.ToInt32(i["ID_Lop"].ToString()),
                NameLop = i["NameLop"].ToString()
            };
        }
        public List<SV> GetLitSV(int ID_Lop, string Name)//lay danh sach sv bang ID_lop va Name SV
        {
            List<SV> data = new List<SV>();
            foreach(SV i in GetAllSV())
            {
                if(ID_Lop == 0)
                {
                    if (i.NameSV.Contains(Name))
                    {
                        data.Add(new SV
                        {
                            NameSV = i.NameSV,
                            MSSV = i.MSSV,
                            Gender = i.Gender,
                            NS = i.NS,
                            ID_Lop = i.ID_Lop
                        });
                    }
                }
                else if (i.ID_Lop == ID_Lop && i.NameSV.Contains(Name)) 
                {
                    data.Add(new SV
                    {
                        NameSV = i.NameSV,
                        MSSV=i.MSSV,
                        Gender=i.Gender,
                        NS=i.NS,
                        ID_Lop=i.ID_Lop
                    });
                    
                }
            }
            return data;
        }
        public void ExecuteDB(SV s)
        {
            bool check = false;
            foreach(SV i in GetAllSV())
            {
                if (s.MSSV == i.MSSV)
                    check = true;
            }
            if (check)
            {
                CSDL.Instance.EditDataRowSV(s);
            }
            else
                CSDL.Instance.AddDataRowSV(s);
        }
        public SV GetSVByMSSV(string MSSV)
        {
            SV s = new SV();
            foreach (SV i in GetAllSV())
                if (i.MSSV == MSSV)
                    s = i;
            return s;
        }
        public void DeleteSV(string MSSV)
        {
            CSDL.Instance.DeleteDataRowSV(MSSV);
        }
        public  void Sort(ref List<SV> arr, Compare cmp)
        {
            for(int i = 0; i < arr.Count; i++)
            {
                for (int j = i; j < arr.Count; j++) 
                {
                    if (cmp(arr[i], arr[j]))
                    {
                        SV temp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = temp;
                    }
                }
            }
        }
        public List<SV> SortSV(string sort, int ID_Lop)
        {
            List<SV> s = GetLitSV(ID_Lop, "");
            if (sort == "MSSV") 
            {
                Sort(ref s, SV.Compare_MSSV);
            }
            else if (sort == "NameSV")
            {
                Sort(ref s, SV.Compare_NameSV);
            }
            else if (sort == "ID_Lop")
            {
                Sort(ref s, SV.Compare_ID_Lop);
            }
            else if (sort == "NS")
            {
                Sort(ref s, SV.Compare_NS);
            }
            else if (sort == "Gender")
            {
                Sort(ref s, SV.Compare_Gender);
            }
            return s;
        }
    }
}
