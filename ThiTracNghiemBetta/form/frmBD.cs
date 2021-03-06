﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace ThiTracNghiemBetta.form
{
    public partial class frmBD : DevExpress.XtraEditors.XtraForm
    {
        public frmBD()
        {
            InitializeComponent();
        }

        private void frmBD_Load(object sender, EventArgs e)
        {

            reloadData();

            defaultCMB();
            normalMode();
            if (Program.mNhom == "TRUONG")
            {
                barbtCancel.Enabled = false;
                barbtSave.Enabled = false;
            }
        }
        private void reloadData()
        {

            /*this.cHITIETBAITHITableAdapter.Connection.ConnectionString = Program.connstr;
            this.cHITIETBAITHITableAdapter.Fill(this.dS.CHITIETBAITHI);*/
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.CHITIETBAITHI' table. You can move, or remove it, as needed.
            this.mONHOCTableAdapter.Connection.ConnectionString = Program.connstr;
            this.mONHOCTableAdapter.Fill(this.dS.MONHOC);
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.GIAOVIEN' table. You can move, or remove it, as needed.
            this.gIAOVIENTableAdapter.Connection.ConnectionString = Program.connstr;
            this.gIAOVIENTableAdapter.Fill(this.dS.GIAOVIEN);

            this.bODETableAdapter.Connection.ConnectionString = Program.connstr;
            // TODO: This line of code loads data into the 'tN_CSDLPTDataSet.BODE' table. You can move, or remove it, as needed.
            this.bODETableAdapter.Fill(this.dS.BODE);
            if (Program.mNhom == "GIANGVIEN")
            {
                bdsBODE.Filter = "MAGV = '" + Program.mUserId + "'";
            } 
            if (Program.mNhom == "TRUONG")
            {
                barbtCancel.Enabled = false;
                barbtSave.Enabled = false;
            }
            
            
        }
        private void defaultCMB()
        {
            cmbDA.SelectedIndex = 0;
            cmbTRINHDO.SelectedIndex = 0;
        }
  
        private void barbtThem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            disableModify();
            enableInputs();
            gc_BD.Enabled = false;
            bdsBODE.AddNew();
           
            txtIDCH.Enabled = true;
            if (Program.mNhom == "GIANGVIEN")
            {
                txtGV.Text = Program.mUserId;
                txtGV.Enabled = false;
                cmbGV.Enabled = false;
            }
            //txtIDCH.Text = "0";
            txtIDCH.Focus();
            Program.Control = "add";
            txtDA.Text = cmbDA.SelectedItem.ToString();
            txtTRINHDO.Text = cmbTRINHDO.SelectedItem.ToString();
            txtMAMH.Text = cmbMH.SelectedValue.ToString();
        }

        private void disableModify()
        {
            barbtRefresh.Enabled = barbtThem.Enabled = barbtXoa.Enabled = barbtSua.Enabled = false;
            barbtCancel.Enabled = barbtSave.Enabled = barbtExit.Enabled = true;
        }

        private void enableModify()
        {
            barbtRefresh.Enabled = barbtThem.Enabled = barbtXoa.Enabled = barbtSua.Enabled = true;
            barbtCancel.Enabled = barbtSave.Enabled = barbtExit.Enabled = true;
            
        }

        private void normalMode()
        {
            enableModify();
            disableInputs();
            gc_BD.Enabled = true;
            barbtSave.Enabled = false;
            if (Program.mNhom == "TRUONG")
            {
                disableModify();
                barbtRefresh.Enabled = true;
                barbtExit.Enabled = true;
            }
            else if (Program.mNhom == "COSO")
            {


            } else 
            if (Program.mNhom == "GIANGVIEN")
            {
               
            }
        }
        private void disableInputs()
        {
            groupF.Enabled = false;
        }

        private void enableInputs()
        {
            groupF.Enabled = true;

        }

        private bool validate()
        {
            string idCH = txtIDCH.Text.ToString().Trim();
            string maGV = txtGV.Text.ToString().Trim();
            string maMH = txtMAMH.Text.ToString().Trim();
            string trinhDo = txtTRINHDO.Text.ToString().Trim();
            string nd = txtND.Text.ToString().Trim();

            string a = txtA.Text.ToString();
            string b = txtB.Text.ToString();
            string c = txtC.Text.ToString();
            string d = txtD.Text.ToString();

            string da = txtDA.Text.ToString();

            if (idCH == "" || maGV == "" || maMH == "" || trinhDo == "" || nd == "" || a == "" || b == "" || c == "" || d == "" || da == "")
            {
                MessageBox.Show("Vui lòng không để trống!");
                return false;
            }
            if (Program.Control == "add")
            {
                if (isMaCHTontai(idCH))
                {
                    return false;
                }
            }
            return true;
        }
        private bool isMaCHTontai(String ma)
        {
            if (bdsBODE.SupportsSearching != true)
            {
                MessageBox.Show("Cannot search the list.");
                return false;
            }

            else
            {
                int foundIndex = bdsBODE.Find("CAUHOI", ma);
                if (foundIndex >= 0)
                {
                    MessageBox.Show("Mã câu hỏi đã tồn tại");
                    return true;
                }
                return false;
            }
        }

        private void cmbGV_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbGV.SelectedValue!=null)
            txtGV.Text = cmbGV.SelectedValue.ToString();
        }

        private void cmbMH_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbMH.SelectedValue!=null)
            txtMAMH.Text = cmbMH.SelectedValue.ToString();

        }

        private void cmbTRINHDO_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbTRINHDO.SelectedItem!=null)
            txtTRINHDO.Text = cmbTRINHDO.SelectedItem.ToString();
        }

        private void cmbDA_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDA.Text = cmbDA.SelectedItem.ToString();
        }

        private void barbtSave_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (!validate()) return;

            try
            {
                this.Validate();
                this.bdsBODE.EndEdit();
                this.bODETableAdapter.Update(this.dS.BODE);
                MessageBox.Show("Đã ghi lại thành công", "", MessageBoxButtons.OK);
                normalMode();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi ghi câu hỏi " + ex.Message, "", MessageBoxButtons.OK);
                return;
            }
        }

        private void barbtSua_ItemClick_1(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBODE.Count == 0) return;
            Program.Control = "edit";
            disableModify();
            enableInputs();
            txtIDCH.Enabled = false;
            gc_BD.Enabled = false;

            cmbDA.SelectedItem = txtDA.Text;
            cmbTRINHDO.SelectedItem = txtTRINHDO.Text;
            cmbMH.SelectedValue = txtMAMH.Text;

            if (Program.mNhom == "GIANGVIEN")
            {
                txtGV.Enabled = false;
                cmbGV.Enabled = false;
            }
        }

        private void barbtXoa_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (bdsBODE.Count == 0) return;
            if (isTonTaiChiTietDeThi(txtIDCH.Text))
            {
                MessageBox.Show("Mã câu hỏi đã tồn tại trong chi tiết bài thi");
                return;
            } 
            if (MessageBox.Show("Bạn có muốn xóa câu " + txtIDCH.Text.Trim() + " ?", "", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                bdsBODE.RemoveAt(bdsBODE.Position);
                this.bODETableAdapter.Update(this.dS.BODE);
                MessageBox.Show("Xóa thành công", "", MessageBoxButtons.OK);
            }
        }

        private bool isTonTaiChiTietDeThi(String ma)
        {

            try
            {
                int kn = Program.KetNoi();
                if (kn == 0)
                {
                    return false;
                }
                String strlenh = "EXEC dbo.SP_TIMCHITIETBAITHI " + ma.Trim();
                Program.myReader = Program.ExecSqlDataReader(strlenh);
                if (Program.myReader.Read() != false)
                {
                    Program.conn.Close();
                    return true;
                }
                return false;
            }
            catch (Exception e)
            {
                MessageBox.Show("Kiểm tra mã câu hỏi thất bại: " + e.Message, "", MessageBoxButtons.OK);
                return false;
            }
        }

        private void barbtRefresh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            reloadData();
        }

        private void barbtCancel_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            bdsBODE.CancelEdit();
            normalMode();
            Program.Control = "";
            gc_BD.Enabled = true;
        }

        private void barbtExit_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (MessageBox.Show("Thoát sẽ mất hết dữ liệu đang thao tác. Bạn muốn thoát không?", "Exit", MessageBoxButtons.OKCancel) == DialogResult.OK)
            {
                if (Program.mNhom == "GIANGVIEN")
                {
                    Program.frmMain.btKHOA.Enabled = Program.frmMain.btGiaoVien.Enabled = Program.frmMain.btLOP.Enabled = Program.frmMain.btMonHoc.Enabled = Program.frmMain.btlogin.Enabled = false;
                    Program.frmMain.btDSDK.Enabled = false;
                    Program.frmMain.btBD.Enabled = true;
                    Program.frmMain.btCancel.Enabled = true;
                }
                else
                {
                    Program.frmMain.btBD.Enabled = Program.frmMain.btCancel.Enabled = Program.frmMain.btDSDK.Enabled = Program.frmMain.btKHOA.Enabled = Program.frmMain.btlogin.Enabled = Program.frmMain.btLOP.Enabled = Program.frmMain.btMonHoc.Enabled = true;
                    Program.frmMain.btnXEMBAITHI.Enabled = Program.frmMain.btnXEMBANGDIEM.Enabled = Program.frmMain.btnXEMDSDANGKY.Enabled = true;
                }
                this.Close();
            }
        }

        private void txtIDCH_KeyPress(object sender, KeyPressEventArgs e)
        {
            Char chr = e.KeyChar;
            if (!Char.IsDigit(chr) && chr !=8)
            {
                e.Handled = true;
            }
        }
    }
}