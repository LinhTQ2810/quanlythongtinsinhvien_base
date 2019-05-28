using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication12
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        private void Button3_Click(object sender, EventArgs e)
        {
            string truyvan = "select * from thongtin where ngaysinh = N'" + textBox1.Text + "'";
            DataTable dulieu = ketnoi.readdata(truyvan);
            if (dulieu != null)
            {
                dataGridView1.DataSource = dulieu;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        private void Form5_Load(object sender, EventArgs e)
        {
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

        private void DataGridView1_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["ngaysinh"].Value);
                // id_xoa = Convert.ToString(dataGridView1.CurrentRow.Cells["masinhvien"].Value);
            }
        }
    }
}
