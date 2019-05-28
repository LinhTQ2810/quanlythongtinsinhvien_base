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
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        private void Form4_Load(object sender, EventArgs e)
        {
            // Thực hiện load dữ liệu tỉnh thành mặc định chọn tỉnh hà nội
            string[] lineOfContents = File.ReadAllLines("Danhsachtinhthanh.txt");
            foreach (var line in lineOfContents)
            {
                comboBox1.Items.Add(line);
            }
            comboBox1.SelectedIndex = 23;

            load_data();
        }

        ketnoicsdl ketnoi = new ketnoicsdl();
        private void load_data()
        {
            string truyvan = "select * from thongtin";
            DataTable dulieu = ketnoi.readdata(truyvan);
            if (dulieu != null)
            {
                dataGridView1.DataSource = dulieu;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string truyvan = "select * from thongtin where quequan = N'"+comboBox1.SelectedItem+"'";
            DataTable dulieu = ketnoi.readdata(truyvan);
            if (dulieu != null)
            {
                dataGridView1.DataSource = dulieu;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }
    }
}
