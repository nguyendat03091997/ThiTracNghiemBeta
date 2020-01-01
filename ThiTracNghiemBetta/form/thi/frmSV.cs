﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraBars;
using ThiTracNghiemBetta.form.thi;
using DevExpress.XtraReports.UI;

namespace ThiTracNghiemBetta.form
{
    public partial class frmSV : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        public frmSV()
        {
            InitializeComponent();
        }
        private Form CheckExists(Type ftype)
        {
            foreach (Form f in this.MdiChildren)
                if (f.GetType() == ftype)
                    return f;
            return null;
        }
        private void btnTHI_ItemClick(object sender, ItemClickEventArgs e)
        {

            frmChonMonThi frm = new frmChonMonThi();
            frm.ShowDialog();
           
        }

        private void btnDANGXUAT_ItemClick(object sender, ItemClickEventArgs e)
        {
           /* DialogResult dialogResult = MessageBox.Show("Bạn có chắc muốn đăng xuất?", "CẢNH BÁO", MessageBoxButtons.YesNo);
            if (dialogResult == DialogResult.Yes)
            {
                Program.username = "";
                Program.mlogin = "";
                Program.password = "";
                GiaoVien_DangKy.gv_dk.Clear();
                GiaoVien_DangKy.gv_dkIndex = -1;
                Program.formDangNhap.Show();
                Program.formSV.Hide();
            }
            else if (dialogResult == DialogResult.No)
            {
                //do something else
            }*/
        }

        private void frmSV_Load(object sender, EventArgs e)
        {
            toolStripStatusHOTEN.Text = "Họ Tên: " + Program.mHoTen;
            toolStripStatusMAGV.Text = "Mã SV:" + Program.mUserId;
            toolStripStatusNHOM.Text = "nhóm: SINHVIEN";
            toolStripStatusMALOP.Text = "Mã lớp: " + Program.malop;
            toolStripStatusTENLOP.Text = "Tên lớp: " + Program.tenlop;
        }

        private void btnTRACUUDIEM_ItemClick(object sender, ItemClickEventArgs e)
        {
            new formXemBaiThiSV().Show();
        }
    }
}