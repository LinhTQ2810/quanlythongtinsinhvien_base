using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;

namespace WindowsFormsApplication12
{

    public partial class Main_from : Form
    {
        public Main_from()
        {
            InitializeComponent();
        }

        private void Main_from_Load(object sender, EventArgs e)
        {

        }

        private void timkiemquequanToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form4();
            newf.Show();
        }

        private void ngaysinhToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form5();
            newf.Show();
        }

        private void masinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form6();
            newf.Show();
        }

        private void themsinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form1();
            newf.Show();
        }

        private void suasinhvienToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form2();
            newf.Show();
        }

        private void xoaSinhViênToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form3();
            newf.Show();
        }

        ketnoicsdl ketnoi = new ketnoicsdl();
        private void ketnoicsdlToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string answer = Microsoft.VisualBasic.Interaction.InputBox("Bạn hãy nhập chuỗi kết nối đến cơ sở dữ liệu. Nếu không bạn sẽ không thể sử dụng phần mềm!", "Thông báo", @"Data Source=DESKTOP-F4E2ODN\SQLEXPRESS;Initial Catalog=quanlythongtinsinhvien;Integrated Security=True");

            if (answer.Length > 0)
            {
                ketnoi.set_stringsql(answer);
                if (ketnoi.testconnect() == "True")
                    {
                        // Kết nối thành công mới thực hiện hiển thị ra chức năng của phần mềm
                        MessageBox.Show("Đã kết nối thành công đến cơ sở dữ liệu!", "Thông báo" ,MessageBoxButtons.OK,MessageBoxIcon.None);
                        timkiemToolStripMenuItem.Visible = true;
                        cToolStripMenuItem.Visible = true;
                        // Khi đã kết nối thành công thì ẩn tính năng kết nối cơ sở dữ liệu đi
                        ketnoicsdlToolStripMenuItem.Visible = false;
                    }
                else
                    {
                        MessageBox.Show("Kết nối thất bại đến cơ sở dữ liệu, bạn cần nhập chính xác chuỗi kết nối cơ sở dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
            }
            

        }

        private void thoatToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void thêmLớpHọcNiênKhóaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var newf = new Form7();
            newf.Show();
        }

        private void ThôngTinPhầnMềmToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Phần mềm do nhóm sinh viên, học phần môn lập trình nâng cao thực hiện!","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void Main_from_FormClosed(object sender, FormClosedEventArgs e)
        {
            
        }

        private void Main_from_FormClosing(object sender, FormClosingEventArgs e)
        {
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result;

            // Displays the MessageBox.
            result = MessageBox.Show("Bạn đã chắc chắn muốn thoát khỏi phần mềm?", "Thông báo từ hệ thống", buttons,MessageBoxIcon.Warning);
            if (result == System.Windows.Forms.DialogResult.Yes)
            {
                
            }
            else
            {
                e.Cancel = true;
            }
        }
    }
}
