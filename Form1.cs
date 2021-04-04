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
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            SetCBB();
            SetCBBSort();
        }
        public void SetCBB()
        {
            cbbLopSH.Items.Add(new CBBItem { Value = 0, Text = "All" });
            foreach(LSH i in CSDL_OOP.Instance.GetAllLopSH())
            {
                cbbLopSH.Items.Add(new CBBItem
                {
                    Value = i.ID_Lop,
                    Text = i.NameLop
                }); 
            }
        }
        public void SetCBBSort()
        {
            cbbSort.Items.AddRange(new string[]
            {
               "MSSV",
               "NameSV",
               "ID_Lop",
               "NS",
               "Gender"
            });
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            cbbLopSH.SelectedIndex = 0;
            cbbSort.SelectedIndex = 0;
        }
        public void Show(int ID_Lop, string Name)
        {
            grvList.DataSource = CSDL_OOP.Instance.GetLitSV(ID_Lop, Name);
        }


        private void btnShow_Click(object sender, EventArgs e)
        {
            Show(((CBBItem)cbbLopSH.SelectedItem).Value, txtSearch.Text);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            Form2 f = new Form2(null);
            f.d += new Form2.MyDel(Show);
            f.Show();
        }
        private void btnEdit_Click(object sender, EventArgs e)
        {
            if(grvList.SelectedRows.Count==1)
            {
                string MSSV = grvList.SelectedRows[0].Cells["MSSV"].Value.ToString();
                Form2 f = new Form2(MSSV);
                f.d += new Form2.MyDel(Show);
                f.Show();
            }
        }

        private void btnDel_Click(object sender, EventArgs e)
        {
            if(grvList.SelectedRows.Count==1)
            {
                string MSSV = grvList.SelectedRows[0].Cells["MSSV"].Value.ToString();
                CSDL_OOP.Instance.DeleteSV(MSSV);
            }
            Show(0, "");
        }

        private void btnSort_Click(object sender, EventArgs e)
        {
            CSDL_OOP.Instance.SortSV(cbbSort.SelectedItem.ToString());
            Show(0, "");
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            btnShow.PerformClick();
        }

        
    }
}
