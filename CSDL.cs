using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace QuanLySV
{
    class CSDL
    {
        
        public DataTable DSSV { get; set; }
        public DataTable DSLopSH { get; set; }
        private static CSDL _instance;
        public static CSDL Instance
        {
            get
            {
                if (_instance == null) _instance = new CSDL();
                return _instance;
            }
            private set { }
        }
        private CSDL()
        {
            DSSV = new DataTable();

            //DSSV.Columns.Add("MSSV", typeof(string));
            //DSSV.Columns.Add("NameSV", typeof(string));
            //DSSV.Columns.Add("Gender", typeof(bool));
            //DSSV.Columns.Add("NS", typeof(DateTime));
            //DSSV.Columns.Add("ID_Lop", typeof(int));

            DSSV.Columns.AddRange(new DataColumn[]
                {
                    new DataColumn("MSSV", typeof(string)),
                    new DataColumn("NameSV", typeof(string)),
                    new DataColumn("Gender", typeof(bool)),
                    new DataColumn("NS", typeof(DateTime)),
                    new DataColumn("ID_Lop", typeof(int))
                });

            DataRow drsv1 = DSSV.NewRow();
            drsv1["MSSV"] = "101";
            drsv1["NameSV"] = "NVA";
            drsv1["Gender"] = true;
            drsv1["NS"] = new DateTime(2001, 8, 2);
            drsv1["ID_Lop"] = "1";
            DSSV.Rows.Add(drsv1);

            DataRow drsv2 = DSSV.NewRow();
            drsv2["MSSV"] = "102";
            drsv2["NameSV"] = "NVB";
            drsv2["Gender"] = false;
            drsv2["NS"] = new DateTime(2001, 9, 10);
            drsv2["ID_Lop"] = "2";
            DSSV.Rows.Add(drsv2);

            DataRow drsv3 = DSSV.NewRow();
            drsv3["MSSV"] = "103";
            drsv3["NameSV"] = "NVC";
            drsv3["Gender"] = true;
            drsv3["NS"] = new DateTime(2001, 2, 23);
            drsv3["ID_Lop"] = "3";
            DSSV.Rows.Add(drsv3);

            DataRow drsv4 = DSSV.NewRow();
            drsv4["MSSV"] = "104";
            drsv4["NameSV"] = "NVD";
            drsv4["Gender"] = false;
            drsv4["NS"] = new DateTime(2001, 7, 1);
            drsv4["ID_Lop"] = "4";
            DSSV.Rows.Add(drsv4);

            DataRow drsv5 = DSSV.NewRow();
            drsv5["MSSV"] = "105";
            drsv5["NameSV"] = "NVE";
            drsv5["Gender"] = true;
            drsv5["NS"] = new DateTime(2001, 4, 14);
            drsv5["ID_Lop"] = "5";
            DSSV.Rows.Add(drsv5);

            DataRow drsv6 = DSSV.NewRow();
            drsv6["MSSV"] = "106";
            drsv6["NameSV"] = "NVF";
            drsv6["Gender"] = false;
            drsv6["NS"] = new DateTime(2001, 5, 7);
            drsv6["ID_Lop"] = "6";
            DSSV.Rows.Add(drsv6);

            DSLopSH = new DataTable();

            DSLopSH.Columns.AddRange(new DataColumn[]
            {
                new DataColumn("ID_Lop", typeof(int)),
                new DataColumn("NameLop", typeof(string)),
                new DataColumn("NgayHH",typeof(DateTime))
            });
           
            DataRow drlsh1 = DSLopSH.NewRow();
            drlsh1["ID_Lop"] = 1;
            drlsh1["NameLop"] = "19TCLC_DT1";
            drlsh1["NgayHH"] = new DateTime(2020,4,10);
            DSLopSH.Rows.Add(drlsh1);

            DataRow drlsh2 = DSLopSH.NewRow();
            drlsh2["ID_Lop"] = 2;
            drlsh2["NameLop"] = "19TCLC_DT2";
            drlsh2["NgayHH"] = DateTime.Now;
            DSLopSH.Rows.Add(drlsh2);

            DataRow drlsh3 = DSLopSH.NewRow();
            drlsh3["ID_Lop"] = 3;
            drlsh3["NameLop"] = "19TCLC_DT3";
            drlsh3["NgayHH"] = DateTime.Now;
            DSLopSH.Rows.Add(drlsh3);

            DataRow drlsh4 = DSLopSH.NewRow();
            drlsh4["ID_Lop"] = 4;
            drlsh4["NameLop"] = "19TCLC_DT4";
            drlsh4["NgayHH"] = DateTime.Now;
            DSLopSH.Rows.Add(drlsh4);

            DataRow drlsh5 = DSLopSH.NewRow();
            drlsh5["ID_Lop"] = 5;
            drlsh5["NameLop"] = "19TCLC_DT5";
            drlsh5["NgayHH"] = DateTime.Now;
            DSLopSH.Rows.Add(drlsh5);

            DataRow drlsh6 = DSLopSH.NewRow();
            drlsh6["ID_Lop"] = 6;
            drlsh6["NameLop"] = "19TCLC_DT6";
            drlsh6["NgayHH"] = DateTime.Now;
            DSLopSH.Rows.Add(drlsh6);

        }
        public void EditDataRowSV(SV s)
        {
            foreach(DataRow i in DSSV.Rows)
            {
                if (i["MSSV"].ToString() == s.MSSV) 
                {
                    i["NameSV"] = s.NameSV;
                    i["Gender"] = s.Gender;
                    i["NS"] = new DateTime(s.NS.Year, s.NS.Month, s.NS.Day);
                    i["ID_Lop"] = s.ID_Lop;
                }
            }
        }
        public void AddDataRowSV(SV s)
        {
            DataRow dr = DSSV.NewRow();
            dr["MSSV"] = s.MSSV;
            dr["NameSV"] = s.NameSV;
            dr["Gender"] = s.Gender;
            dr["NS"] = new DateTime(s.NS.Year, s.NS.Month, s.NS.Day);
            dr["ID_Lop"] = s.ID_Lop;
            DSSV.Rows.Add(dr);
        }
        public void DeleteDataRowSV(string MSSV)
        {
            int index = -1;
            foreach (DataRow i in DSSV.Rows)
            {
                if (i["MSSV"].ToString() == MSSV)
                {
                    index = DSSV.Rows.IndexOf(i);
                }
            }
            DSSV.Rows.RemoveAt(index);
        }
        

        public void SortSV(string Sort)
        { 
                DSSV.DefaultView.Sort = Sort;
                DSSV = DSSV.DefaultView.ToTable(true);
        }
    }
}
