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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        private void txtlh_TextChanged(object sender, EventArgs e)
        {

        }

        private void Form3_Load(object sender, EventArgs e)
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

        string id_xoa = "";
        private void Button3_Click(object sender, EventArgs e)
        {
            Boolean check = ketnoi.exedata("DELETE FROM thongtin WHERE masinhvien = '" + id_xoa + "'");
            if (check == true)
            {
                load_data();
                MessageBox.Show("Xóa thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Xóa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void DataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["masinhvien"].Value);
                id_xoa = Convert.ToString(dataGridView1.CurrentRow.Cells["masinhvien"].Value);
            }
        }

        private bool kiemtracotontai(string find)
        {

            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string xxx = Convert.ToString(dataGridView1.Rows[i].Cells["masinhvien"].Value);
                if (xxx == find)
                    return true;

            }
            return false;
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {

        }
    }
}
