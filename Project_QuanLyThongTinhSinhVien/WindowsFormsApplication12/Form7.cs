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
    public partial class Form7 : Form
    {
        public Form7()
        {
            InitializeComponent();
        }
        ketnoicsdl ketnoi = new ketnoicsdl();


        private void button1_Click(object sender, EventArgs e)
        {
            if (kiemtracotontai(textBox1.Text.ToUpper()) == false)
            { 
                Boolean check = ketnoi.exedata("INSERT INTO tenlop (tenlop_nc) VALUES (N'" + textBox1.Text.ToUpper()+ "')");
                if (check == true)
                {
                    load_data();
                    MessageBox.Show("Đã thêm thành công!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Thêm thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Thêm thất bại! Do đã trùng dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            
        }

        private void Form7_Load(object sender, EventArgs e)
        {
            load_data();
        }

        private void load_data()
        {
            string truyvan = "select * from tenlop";
            DataTable dulieu = ketnoi.readdata(truyvan);
            if (dulieu != null)
            {
                dataGridView1.DataSource = dulieu;
            }
            dataGridView1.AutoResizeColumns();
            dataGridView1.AutoResizeRows();
        }

        string id_xoa = "";
        private void button2_Click(object sender, EventArgs e)
        {
            if (kiemtracotontai(textBox1.Text.ToUpper()) == false)
            { 
                Boolean check = ketnoi.exedata("UPDATE tenlop  SET tenlop_nc = '" + textBox1.Text.ToUpper() + "' WHERE id = '" + id_xoa + "'");
                if (check == true)
                {
                    load_data();
                    MessageBox.Show("Sửa thành công!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Sửa thất bại!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
                MessageBox.Show("Sửa thất bại! Do đã trùng dữ liệu.", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Boolean check = ketnoi.exedata("DELETE FROM tenlop WHERE id = '"+id_xoa+"'");
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

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                textBox1.Text = Convert.ToString(dataGridView1.CurrentRow.Cells["tenlop_nc"].Value);
                id_xoa = Convert.ToString(dataGridView1.CurrentRow.Cells["id"].Value);
            }
        }

        private bool kiemtracotontai(string find)
        {
           
            for (int i = 0; i < dataGridView1.Rows.Count; i++)
            {
                string xxx = Convert.ToString(dataGridView1.Rows[i].Cells["tenlop_nc"].Value);
                if (xxx == find )
                return true; 
                    
            }
            return false;
        }

        private void DataGridView1_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            
        }

        private void DataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
           
        }
    }
}
