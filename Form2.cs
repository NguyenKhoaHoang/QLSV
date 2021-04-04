using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLySV
{
    public partial class Form2 : Form
    {
        public delegate void MyDel(int ID_Lop, string Name);
        public MyDel d { get; set; }
        public string MSSV { get; set; }

        public Form2(string m)
        {
            InitializeComponent();
            MSSV = m;
            SetGUI();
        }
        private void Form2_Load(object sender, EventArgs e)
        {
            //cbbLopSH.DataSource = CSDL.Instance.DSLopSH;
            //cbbLopSH.DisplayMember = "NameLop";
            //cbbLopSH.ValueMember = "ID_Lop";
            if (MSSV == null)
            {
                this.Text = "Them sinh vien";
                gbTTSV.Text = "Them sinh vien"; 
                cbbLopSH.SelectedIndex = 0;
                rdMale.Checked = true;
            }
            else
            {
                this.Text = "Chinh sua sinh vien";
                gbTTSV.Text = "Chinh sua sinh vien";
                txtMSSV.ReadOnly = true; 
            }
        }
        public void SetCBB()
        {
            foreach (LSH i in CSDL_OOP.Instance.GetAllLopSH())
            {
                cbbLopSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                });
            }
        }
        public void SetGUI()
        {
            if (MSSV != null)
            {
                SV s = CSDL_OOP.Instance.GetSVByMSSV(MSSV);
                txtMSSV.Text = s.MSSV;
                txtName.Text = s.NameSV;
                foreach (LSH i in CSDL_OOP.Instance.GetAllLopSH())
                {
                    cbbLopSH.Items.Add(new CBBItem
                    {
                        Value = i.ID_Lop,
                        Text = i.NameLop
                    });
                }
                dtBirth.Value = new DateTime(s.NS.Year, s.NS.Month, s.NS.Day);
                if (s.Gender == true) rdMale.Checked = true;
                else rdFemale.Checked = true;
                foreach (CBBItem i in cbbLopSH.Items)
                {
                    if (i.Value == s.ID_Lop)
                    {
                        cbbLopSH.SelectedIndex = cbbLopSH.Items.IndexOf(i);
                    }
                }
            }
            else
            { 
                SetCBB();
            }
        }
        private void btnOK_Click(object sender, EventArgs e)
        {
            if (txtMSSV.Text == "" || txtName.Text == "")
            {
                MessageBox.Show("Hay nhap day du thong tin SV");
            }
            else
            {
                SV s = new SV();
                s.MSSV = txtMSSV.Text;
                s.NameSV = txtName.Text;
                s.ID_Lop = ((CBBItem)cbbLopSH.SelectedItem).Value;
                s.NS = dtBirth.Value;
                if (rdMale.Checked) s.Gender = true;
                else s.Gender = false;
                if (MSSV == null)
                {
                    foreach(SV i in CSDL_OOP.Instance.GetAllSV())
                    {
                        if (s.MSSV == i.MSSV)
                        {
                            MessageBox.Show("Trung MSSV, ko them vao dc");
                            return;
                        }
                    }
                }
                CSDL_OOP.Instance.ExecuteDB(s);
                d(0, "");
            }
        }
        
        private void Cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
