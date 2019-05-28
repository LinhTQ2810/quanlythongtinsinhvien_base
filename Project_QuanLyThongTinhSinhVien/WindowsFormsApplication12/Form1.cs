using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        ketnoicsdl ketnoi = new ketnoicsdl();
        private void Form1_Load(object sender, EventArgs e)
        {
            // Truy vấn vào cơ sở dữ liệu tên lớp
            string truyvan = "select * from tenlop";
            DataTable dulieu = ketnoi.readdata(truyvan);
            if (dulieu != null)
            {
                cbxTenLop.DataSource = dulieu;
                cbxTenLop.DisplayMember = "tenlop_nc";
                cbxTenLop.ValueMember = "tenlop_nc";
            }
            // Thực hiện load dữ liệu tỉnh thành mặc định chọn tỉnh hà nội
            string[] lineOfContents = File.ReadAllLines("Danhsachtinhthanh.txt");
            foreach (var line in lineOfContents)
            {
                comboBox1.Items.Add(line);
            }
            comboBox1.SelectedIndex=23;
        }

        string msv = "";
        private void button1_Click(object sender, EventArgs e)
        {
            int stt = 0;
            // Thực hiện đếm sinh viên hiện có để tính toán ra mã sinh viên
            stt = ketnoi.dembanghi("SELECT COUNT(*) FROM thongtin") + 1;
            string selected = this.cbxTenLop.SelectedValue.ToString();
            msv = "";
            msv = msv + stt.ToString("000")+ selected;
            txtmaSV.Text = msv;
            button2.Enabled = true;
            button1.Enabled = false;
        }

        private void CbxTenLop_SelectedIndexChanged(object sender, EventArgs e)
        {
            button2.Enabled = false;
            txtmaSV.Text = "";
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string hoten = txtTenSV.Text;
            string ngaysinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string quequan = this.comboBox1.SelectedItem.ToString();
            string gioitinh = "";
            if (radioButton7.Checked == true)
            {
                gioitinh = radioButton7.Text;
            }
            else gioitinh = radioButton8.Text;

            if (hoten != "" && ngaysinh != "" && quequan != "" && gioitinh != "" && msv !="")
            {
                Boolean check = ketnoi.exedata("INSERT INTO thongtin (masinhvien,hoten,ngaysinh,gioitinh,quequan) VALUES (N'" + msv + "',N'" + hoten + "',N'" + ngaysinh + "',N'" + gioitinh + "',N'" + quequan + "')");
                if (check == true)
                {
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    txtTenSV.Text = "";
                    txtmaSV.Text = "";
                    radioButton7.Checked = true;
                    dateTimePicker1.Value = DateTime.Now;
                    comboBox1.SelectedIndex = 23;
                    button2.Enabled = false;
                    button1.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bạn phải nhập đầy đủ thông tin trên mẫu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void RadioButton7_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
