using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void txtmsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void txttsv_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form2_Load(object sender, EventArgs e)
        {
            // Thực hiện load dữ liệu tỉnh thành mặc định chọn tỉnh hà nội
            string[] lineOfContents = File.ReadAllLines("Danhsachtinhthanh.txt");
            foreach (var line in lineOfContents)
            {
                comboBox1.Items.Add(line);
            }
            comboBox1.SelectedIndex = 23;
        }
        ketnoicsdl ketnoi = new ketnoicsdl();
        private void Button1_Click(object sender, EventArgs e)
        {
            if (txtmaSV.Text != "")
            {
                string truyvan = "select * from thongtin where masinhvien = '"+txtmaSV.Text.ToUpper()+"'";
                DataTable dulieu = ketnoi.readdata(truyvan);
                if (dulieu != null)
                {
                    // Thực hiện lấy dữ liệu từ cơ sở dữ liệu trả về giao diện cho người dùng
                    DataRow[] rows = dulieu.Select();
                    try
                    { 
                        txtTenSV.Text = rows[0]["hoten"].ToString();
                        dateTimePicker1.Value = DateTime.ParseExact(rows[0]["ngaysinh"].ToString(), "dd-MM-yyyy", CultureInfo.InvariantCulture);
                            if (rows[0]["gioitinh"].ToString().Trim() == "Nam")
                            {
                                radioButton7.Checked = true;
                            }
                            else
                                radioButton8.Checked = true;
                        comboBox1.SelectedItem = rows[0]["quequan"].ToString();
                        button2.Enabled = true;
                        button1.Enabled = false;
                    }
                    catch
                    {
                        MessageBox.Show("Mã sinh viên không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                    
                }
                else
                {
                    MessageBox.Show("Mã sinh viên không chính xác!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show("Bạn không được phép để trống trường Mã Sinh Viên!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void Button2_Click(object sender, EventArgs e)
        {
            string hoten = txtTenSV.Text;
            string ngaysinh = dateTimePicker1.Value.ToString("dd-MM-yyyy");
            string quequan = this.comboBox1.SelectedItem.ToString();
            string gioitinh = "";
            string msv = txtmaSV.Text;
            if (radioButton7.Checked == true)
            {
                gioitinh = radioButton7.Text;
            }
            else gioitinh = radioButton8.Text;

            if (hoten != "" && ngaysinh != "" && quequan != "" && gioitinh != "" && msv != "")
            {
                Boolean check = ketnoi.exedata("UPDATE thongtin  SET hoten = N'" + hoten + "',ngaysinh = N'" + ngaysinh + "', quequan = N'" + quequan + "',gioitinh = N'" + gioitinh + "' WHERE masinhvien = '" + msv + "'");
                if (check == true)
                {
                    MessageBox.Show("Đã sửa thông tin thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                    MessageBox.Show("Sửa thông tin thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else MessageBox.Show("Bạn phải nhập đầy đủ thông tin trên mẫu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
