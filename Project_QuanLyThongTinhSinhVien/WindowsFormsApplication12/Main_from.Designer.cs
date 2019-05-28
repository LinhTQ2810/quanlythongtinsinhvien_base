namespace WindowsFormsApplication12
{
    partial class Main_from
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Main_from));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ketnoicsdlToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thoatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.timkiemquequanToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ngaysinhToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.masinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thêmLớpHọcNiênKhóaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.themsinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.suasinhvienToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.xoaSinhViênToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.thôngTinPhầnMềmToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.hToolStripMenuItem,
            this.timkiemToolStripMenuItem,
            this.cToolStripMenuItem,
            this.thôngTinPhầnMềmToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(484, 24);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // hToolStripMenuItem
            // 
            this.hToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ketnoicsdlToolStripMenuItem,
            this.thoatToolStripMenuItem});
            this.hToolStripMenuItem.Name = "hToolStripMenuItem";
            this.hToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.hToolStripMenuItem.Text = "Hệ Thống";
            // 
            // ketnoicsdlToolStripMenuItem
            // 
            this.ketnoicsdlToolStripMenuItem.Image = ((System.Drawing.Image)(resources.GetObject("ketnoicsdlToolStripMenuItem.Image")));
            this.ketnoicsdlToolStripMenuItem.Name = "ketnoicsdlToolStripMenuItem";
            this.ketnoicsdlToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.ketnoicsdlToolStripMenuItem.Text = "Kết nối cơ sở dữ liệu";
            this.ketnoicsdlToolStripMenuItem.Click += new System.EventHandler(this.ketnoicsdlToolStripMenuItem_Click);
            // 
            // thoatToolStripMenuItem
            // 
            this.thoatToolStripMenuItem.Name = "thoatToolStripMenuItem";
            this.thoatToolStripMenuItem.Size = new System.Drawing.Size(181, 22);
            this.thoatToolStripMenuItem.Text = "Thoát";
            this.thoatToolStripMenuItem.Click += new System.EventHandler(this.thoatToolStripMenuItem_Click);
            // 
            // timkiemToolStripMenuItem
            // 
            this.timkiemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.timkiemquequanToolStripMenuItem,
            this.ngaysinhToolStripMenuItem,
            this.masinhvienToolStripMenuItem});
            this.timkiemToolStripMenuItem.Name = "timkiemToolStripMenuItem";
            this.timkiemToolStripMenuItem.Size = new System.Drawing.Size(68, 20);
            this.timkiemToolStripMenuItem.Text = "Tìm kiếm";
            this.timkiemToolStripMenuItem.Visible = false;
            // 
            // timkiemquequanToolStripMenuItem
            // 
            this.timkiemquequanToolStripMenuItem.Name = "timkiemquequanToolStripMenuItem";
            this.timkiemquequanToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.timkiemquequanToolStripMenuItem.Text = "Quê quán";
            this.timkiemquequanToolStripMenuItem.Click += new System.EventHandler(this.timkiemquequanToolStripMenuItem_Click);
            // 
            // ngaysinhToolStripMenuItem
            // 
            this.ngaysinhToolStripMenuItem.Name = "ngaysinhToolStripMenuItem";
            this.ngaysinhToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.ngaysinhToolStripMenuItem.Text = "Ngày sinh";
            this.ngaysinhToolStripMenuItem.Click += new System.EventHandler(this.ngaysinhToolStripMenuItem_Click);
            // 
            // masinhvienToolStripMenuItem
            // 
            this.masinhvienToolStripMenuItem.Name = "masinhvienToolStripMenuItem";
            this.masinhvienToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.masinhvienToolStripMenuItem.Text = "Mã sinh viên";
            this.masinhvienToolStripMenuItem.Click += new System.EventHandler(this.masinhvienToolStripMenuItem_Click);
            // 
            // cToolStripMenuItem
            // 
            this.cToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.thêmLớpHọcNiênKhóaToolStripMenuItem,
            this.themsinhvienToolStripMenuItem,
            this.suasinhvienToolStripMenuItem,
            this.xoaSinhViênToolStripMenuItem});
            this.cToolStripMenuItem.Name = "cToolStripMenuItem";
            this.cToolStripMenuItem.Size = new System.Drawing.Size(124, 20);
            this.cToolStripMenuItem.Text = "Chỉnh sửa thông tin";
            this.cToolStripMenuItem.Visible = false;
            // 
            // thêmLớpHọcNiênKhóaToolStripMenuItem
            // 
            this.thêmLớpHọcNiênKhóaToolStripMenuItem.Name = "thêmLớpHọcNiênKhóaToolStripMenuItem";
            this.thêmLớpHọcNiênKhóaToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.thêmLớpHọcNiênKhóaToolStripMenuItem.Text = "Thêm lớp học niên khóa";
            this.thêmLớpHọcNiênKhóaToolStripMenuItem.Click += new System.EventHandler(this.thêmLớpHọcNiênKhóaToolStripMenuItem_Click);
            // 
            // themsinhvienToolStripMenuItem
            // 
            this.themsinhvienToolStripMenuItem.Name = "themsinhvienToolStripMenuItem";
            this.themsinhvienToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.themsinhvienToolStripMenuItem.Text = "Thêm sinh viên";
            this.themsinhvienToolStripMenuItem.Click += new System.EventHandler(this.themsinhvienToolStripMenuItem_Click);
            // 
            // suasinhvienToolStripMenuItem
            // 
            this.suasinhvienToolStripMenuItem.Name = "suasinhvienToolStripMenuItem";
            this.suasinhvienToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.suasinhvienToolStripMenuItem.Text = "Sửa thông tin sinh viên";
            this.suasinhvienToolStripMenuItem.Click += new System.EventHandler(this.suasinhvienToolStripMenuItem_Click);
            // 
            // xoaSinhViênToolStripMenuItem
            // 
            this.xoaSinhViênToolStripMenuItem.Name = "xoaSinhViênToolStripMenuItem";
            this.xoaSinhViênToolStripMenuItem.Size = new System.Drawing.Size(202, 22);
            this.xoaSinhViênToolStripMenuItem.Text = "Xóa sinh viên";
            this.xoaSinhViênToolStripMenuItem.Click += new System.EventHandler(this.xoaSinhViênToolStripMenuItem_Click);
            // 
            // thôngTinPhầnMềmToolStripMenuItem
            // 
            this.thôngTinPhầnMềmToolStripMenuItem.Name = "thôngTinPhầnMềmToolStripMenuItem";
            this.thôngTinPhầnMềmToolStripMenuItem.Size = new System.Drawing.Size(131, 20);
            this.thôngTinPhầnMềmToolStripMenuItem.Text = "Thông tin phần mềm";
            this.thôngTinPhầnMềmToolStripMenuItem.Click += new System.EventHandler(this.ThôngTinPhầnMềmToolStripMenuItem_Click);
            // 
            // Main_from
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(484, 262);
            this.Controls.Add(this.menuStrip1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main_from";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Quản lý thông tin sinh viên";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Main_from_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Main_from_FormClosed);
            this.Load += new System.EventHandler(this.Main_from_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem hToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ketnoicsdlToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thoatToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timkiemToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem themsinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem suasinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem xoaSinhViênToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem timkiemquequanToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ngaysinhToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem masinhvienToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thêmLớpHọcNiênKhóaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem thôngTinPhầnMềmToolStripMenuItem;
    }
}