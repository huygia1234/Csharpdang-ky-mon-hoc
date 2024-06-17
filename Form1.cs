using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics.Eventing.Reader;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CSharp_dkmonhoc
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int i = 2020; i <= 2025; i++)
            {
                cbxnienkhoa.Items.Add(i.ToString());
            }
            cbxnienkhoa.SelectedIndex = 5;
            /* cbxlop.Items.Add("Ứng dụng phần mềm 1");
             cbxlop.Items.Add("Ứng dụng phần mềm 2");
             cbxlop.Items.Add("Ứng dụng phần mềm 3");
             cbxlop.Items.Add("Thiết kế đồ họa 1");
             cbxlop.Items.Add("Thiết kế đồ họa 2");
             cbxlop.Items.Add("Thiết kế đồ họa 3");
             cbxlop.Items.Add("Quản trị mạng 1");
             cbxlop.Items.Add("Quản trị mạng 2");
             cbxlop.Items.Add("Quản trị mạng 3");*/
            string[] lopArray = { "Ứng dụng phần mềm 1", "Ứng dụng phần mềm 2", "Ứng dụng phần mềm 3", "Thiết kế đồ họa 1", "Thiết kế đồ họa 2", "Thiết kế đồ họa 3", "Quản trị mạng 1", "Quản trị mạng 2", "Quản trị mạng 3" };
            foreach (var items in lopArray)
            {
                cbxlop.Items.Add(items);
            }
            rdb1.Checked = true;
            clbmonhoc.Items.Add("LT WIN", CheckState.Checked);
            clbmonhoc.Items.Add("LT Internet", CheckState.Checked);
            clbmonhoc.Items.Add("Mạng máy tính", CheckState.Unchecked);
            clbmonhoc.Items.Add("UML", CheckState.Checked);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void cbxnienkhoa_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void btnthoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btndky_Click(object sender, EventArgs e)
        {
            string thongtin;
            thongtin = "Mã số sinh viên: " + txtmssv.Text;
            thongtin += "\nHọ và tên: " + txthovaten.Text;
            thongtin += "\nNiên khóa: " + cbxnienkhoa.SelectedItem;
            thongtin += "\nLớp: " + cbxlop.SelectedItem;
            string hocky = "";
            if (rdb1.Checked)
            {
                hocky = rdb1.Text;
            }
            else if (rdb2.Checked)
            {
                hocky = rdb2.Text;
            }
            else if (rdb3.Checked)
            {
                hocky = rdb3.Text;
            }
            else if (rdb4.Checked)
            {
                hocky = rdb4.Text;
            }

            thongtin += "\nĐã đăng ký học Học kỳ " + hocky + " các môn sau: ";
            int stt = 1;
            foreach (var item in clbmonhoc.CheckedItems)
            {
                thongtin += "\n" + stt + ". " + item.ToString();
                stt++;
            }
            MessageBox.Show(thongtin, "Thông tin sinh viên");

        }
    }
}57361