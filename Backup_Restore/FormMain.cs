using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Linq;
using System.Threading;
using System.Windows.Forms;
using DevExpress.XtraEditors;
using System.Data.SqlClient;
using System.IO;

namespace Backup_Restore
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {

        String tenDevice;
        //  String tenDeviceBackLog;

        //   String timeStop;
        int soLuongBanSaoLuu;
        String strRestore;
        //   DateTime timeDate;
        String strFullPathDevice;
        public FormMain()
        {
            InitializeComponent();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.backup_devices' table. You can move, or remove it, as needed.
            this.dataTable1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.databasesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;
            this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);         
           this.databasesTableAdapter.Fill(this.DS.databases);
            Program.Db = ((DataRowView)bdsDatabase[bdsDatabase.Position])["name"].ToString().Trim();
            this.txtTenDB.Text = Program.Db;
            this.dataTable1TableAdapter.Fill(this.DS.DataTable1, Program.Db);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //   Prg.PerformStep();

        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FormMain_FormClosing(object sender, FormClosingEventArgs e)
        {
            Program.LoginForm.Visible = true;
        }

        private void dBNAMEToolStripTextBox_Click(object sender, EventArgs e)
        {

        }

        private void fillToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.dataTable1TableAdapter.Fill(this.DS.DataTable1, txtTenDB.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
        }
        private void taoDevice()
        {
            tenDevice = "DEVICE_" + Program.Db;
            strFullPathDevice = Program.strDefaultPath + tenDevice + ".BAK";

            String query = "USE master\n EXEC sp_addumpdevice '" + Program.device_type + "', '" + tenDevice + "','" + strFullPathDevice + "'";
            try
            {

                Program.myreader = Program.ExecSqlDataReader(query);
                if (Program.myreader != null)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 10;

                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        PrgLoad.Value = i;

                        PrgLoad.PerformStep();
                        Thread.Sleep(10);

                    }

                    PrgLoad.Visible = false;
                    MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                    this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);
                    btnDevice.Enabled = false;
                    btnSaoLuuAd.Enabled = true;
                    txtTenDevice.Text = tenDevice;
                }
                else MessageBox.Show(" Tạo Device thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }

            Program.conn.Close();

        }

        private void barButtonItem3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            if (Directory.Exists(Program.strDefaultPath) == true)
            {
                taoDevice();
            }
            else
            {
                OpenFileDialog folderBrowser = new OpenFileDialog();
                folderBrowser.ValidateNames = false;
                folderBrowser.CheckFileExists = false;
                folderBrowser.CheckPathExists = true;
                folderBrowser.FileName = "Folder Selection.";
                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                    Program.strDefaultPathNew = folderPath + "\\";
                    strFullPathDevice = Program.strDefaultPathNew + tenDevice + ".BAK";

                    String query = "USE master\n EXEC sp_addumpdevice '" + Program.device_type + "', '" + tenDevice + "','" + strFullPathDevice + "'";
                    try
                    {

                        Program.myreader = Program.ExecSqlDataReader(query);
                        if (Program.myreader != null)
                        {

                            int i;
                            this.PrgLoad.Visible = true;
                            this.PrgLoad.Minimum = 0;
                            this.PrgLoad.Maximum = 100;
                            this.PrgLoad.Step = 10;

                            for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                            {
                                PrgLoad.Value = i;

                                PrgLoad.PerformStep();
                                Thread.Sleep(10);

                            }

                            PrgLoad.Visible = false;
                            MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                            this.backup_devicesTableAdapter.Fill(this.DS.backup_devices);
                            btnDevice.Enabled = false;
                            btnSaoLuuAd.Enabled = true;
                            txtTenDevice.Text = tenDevice;
                        }
                        else MessageBox.Show(" Tạo Device thất bại!", "", MessageBoxButtons.OK);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                        return;
                    }

                    Program.conn.Close();

                }
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }
        private void LoadBanSaoLuu()
        {
            if (Program.Db.Trim() == "") return;
            try
            {
                this.dataTable1TableAdapter.Connection.ConnectionString = Program.connstr;
                this.dataTable1TableAdapter.Fill(this.DS.DataTable1, Program.Db);
                if (bdsBackup.Count == 0)
                    txtSoLuongBackup.Text = "0";
                else
                {
                    soLuongBanSaoLuu = int.Parse(((DataRowView)bdsBackup[0])["position"].ToString());

                    txtSoLuongBackup.Text = soLuongBanSaoLuu.ToString();
                }
            }
            catch (Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
        }
        private void grvDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            //  this.dataTable1TableAdapter.Fill(this.DS.DataTable1, dBNAMEToolStripTextBox.Text);
            // txtSoLuongBackup.Text = grvBackup.RowCount.ToString();

            Program.Db = ((DataRowView)bdsDatabase[bdsDatabase.Position])["name"].ToString().Trim();
            txtTenDB.Text = Program.Db;
            tenDevice = "DEVICE_" + Program.Db;
            strFullPathDevice = Program.strDefaultPath + tenDevice + ".BAK";
            int checkTrungDevice = bdsBackup_device.Find("name", tenDevice);
           // MessageBox.Show(" check device" + checkTrungDevice,"", MessageBoxButtons.OK);
            if (checkTrungDevice == -1)
            {
                this.txtTenDevice.Text = "Chưa có Device";
                this.btnDevice.Enabled = true;
                this.btnSaoLuuAd.Enabled = false;
            }
            else
            {
                this.txtTenDevice.Text = ((DataRowView)bdsBackup_device[checkTrungDevice])["name"].ToString().Trim();
                this.btnDevice.Enabled = false;
                this.btnSaoLuuAd.Enabled = true;
                this.btnPhucHoi.Enabled = true;
                this.btnThamsotime.Enabled = true;
            }
            this.dataTable1TableAdapter.Connection.ConnectionString = Program.connstr;
            this.dataTable1TableAdapter.Fill(this.DS.DataTable1, Program.Db);
            this.backup_devicesTableAdapter.Connection.ConnectionString = Program.connstr;

            LoadBanSaoLuu();

        }

        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void PrgLoad_Click(object sender, EventArgs e)
        {
        }

        private void btnSaoLuuAd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Program.Db.Trim() == "" || tenDevice == "") return;

            String strBackup = "BACKUP DATABASE " + Program.Db + " TO " + tenDevice;
            if (ckiNit.Checked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa các sao lưu cũ ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    strBackup = strBackup + " WITH INIT";

            }

            try
            {

                Program.myreader = Program.ExecSqlDataReader(strBackup);

                if (Program.myreader != null)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 10;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        PrgLoad.Value = i;
                        PrgLoad.PerformStep();
                        Thread.Sleep(10);
                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Tạo Backup thành công!", "", MessageBoxButtons.OK);
                }
                else MessageBox.Show(" Tạo Backup thất bại!", "", MessageBoxButtons.OK);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex, "!", MessageBoxButtons.OK);
                return;
            }
            Program.conn.Close();
            LoadBanSaoLuu();

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int err;
            if (this.bdsBackup.Count == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu nào phụ hồi", "!", MessageBoxButtons.OK);
                return;
            }
            if (soLuongBanSaoLuu == 0)
            {
                MessageBox.Show("Vui lòng chọn bản sao lưu phục hồi ", "!", MessageBoxButtons.OK);
                return;
            }
            if (Program.conn != null && Program.conn.State == ConnectionState.Open)
                Program.conn.Close(); // đóng kết nối 
            if (txtTenDB.Text.Trim() == "" || tenDevice == "") return;
            strRestore = "ALTER DATABASE " + txtTenDB.Text + " SET SINGLE_USER WITH ROLLBACK IMMEDIATE " + "USE tempdb ";
            if (btnThamsotime.Checked == false)
            {
                strRestore += "RESTORE DATABASE " + txtTenDB.Text + " FROM " + tenDevice + " WITH FILE= " + soLuongBanSaoLuu + ",REPLACE " + "ALTER DATABASE " + Program.Db + " SET MULTI_USER";
             //   MessageBox.Show(strRestore, "", MessageBoxButtons.OK);
                err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "lỗi phục hồi cơ sở dữ liệu");
                if (err == 0)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 20;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        this.PrgLoad.Value = i;

                        PrgLoad.PerformStep();
                        Thread.Sleep(10);
                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Phục hồi thành công!", "", MessageBoxButtons.OK);

                }
            }
            else
            {
                DateTime ngaygioBK = (DateTime)((DataRowView)bdsBackup[bdsBackup.Position])["backup_start_date"];
                DateTime dateStop = dtpDate.Value.Date + dtptTimeStop.Value.TimeOfDay;
                String dt = dtpDate.Value.ToString("yyyy-MM-dd") + " " + dtptTimeStop.Value.ToString("HH:mm:ss");
                if ((dtpDate.Value.Date < ngaygioBK.Date) || (dtpDate.Value.Date == ngaygioBK.Date && dtptTimeStop.Value.Ticks < ngaygioBK.TimeOfDay.Ticks))
                {
                    MessageBox.Show(" Thời điểm muốn phục hồi phải sau thời điểm sao lưu đã chọn", "", MessageBoxButtons.OK);
                    return;

                }
                if (DateTime.Now < dateStop)
                {
                    MessageBox.Show(" Thời điểm muốn phục hồi phải trước thời điểm hiện tại", "", MessageBoxButtons.OK);
                    return;
                }
                else
                {
                    if (Directory.Exists(Program.strDefaultPath) == true)
                    {
                        RestoreDiaglog(dt);
                    }
                    else
                    {
                        OpenFileDialog folderBrowser = new OpenFileDialog();
                        folderBrowser.ValidateNames = false;
                        folderBrowser.CheckFileExists = false;
                        folderBrowser.CheckPathExists = true;
                        folderBrowser.FileName = "Folder Selection.";
                        if (folderBrowser.ShowDialog() == DialogResult.OK)
                        {
                            string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                            Program.strDefaultPathNew = folderPath + "\\";
                            String strFullPathBackLog = Program.strDefaultPathNew + Program.Db + ".TRN";
                            String pathBack = Program.strDefaultPathNew + tenDevice + ".bak";
                            strRestore += "BACKUP LOG " + Program.Db + " TO DISK='" + strFullPathBackLog + "' WITH INIT\n "
                               + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + pathBack + "' WITH NORECOVERY , REPLACE\n "
                                + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + strFullPathBackLog + "' WITH STOPAT='" + dt
                                + "'\n ALTER DATABASE " + Program.Db + " SET MULTI_USER";
                            MessageBox.Show(" " + strRestore, "", MessageBoxButtons.OK);
                            int Err = Program.ExecSqlNonQuery(strRestore, Program.connstr, "lỗi phục hồi cơ sở dữ liệu");
                            if (Err == 0)
                            {
                                int i;
                                this.PrgLoad.Visible = true;
                                this.PrgLoad.Minimum = 0;
                                this.PrgLoad.Maximum = 100;
                                this.PrgLoad.Step = 20;
                                for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                                {
                                    this.PrgLoad.Value = i;
                                    PrgLoad.PerformStep();
                                    Thread.Sleep(10);

                                }
                                PrgLoad.Visible = false;
                                MessageBox.Show(" Phục hồi thời gian lúc " + dt + " Thành công!", "", MessageBoxButtons.OK);

                            }
                            else
                            {
                                MessageBox.Show(" Sai đường dẫn backup . Kiểm tra lại  ", "", MessageBoxButtons.OK);
                            }
                        }

                        else
                        {
                            return;
                        }
                    }
                }
            }
        }


        private void RestoreDiaglog(String dtStopAt)
        {
            DialogResult rsdiaglog = MessageBox.Show("Thời gian phục hồi: " + dtStopAt, Program.Db + " - Restore dialog", MessageBoxButtons.OKCancel);
            if (rsdiaglog == DialogResult.OK)
            {
                String strFullPathBackLog = Program.strDefaultPath + Program.Db + ".TRN";
                strRestore += "BACKUP LOG " + Program.Db + " TO DISK='" + strFullPathBackLog + "' WITH INIT\n "
                   + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + strFullPathDevice + "' WITH NORECOVERY , REPLACE\n "
                    + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + strFullPathBackLog + "' WITH STOPAT='" + dtStopAt
                    + "'\n ALTER DATABASE " + Program.Db + " SET MULTI_USER";
                int checkErr = Program.ExecSqlNonQuery(strRestore, Program.connstr, "lỗi phục hồi cơ sở dữ liệu");
                if (checkErr == 0)
                {
                    int i;
                    this.PrgLoad.Visible = true;
                    this.PrgLoad.Minimum = 0;
                    this.PrgLoad.Maximum = 100;
                    this.PrgLoad.Step = 20;
                    for (i = this.PrgLoad.Minimum; i <= this.PrgLoad.Maximum; i++)
                    {
                        this.PrgLoad.Value = i;
                        PrgLoad.PerformStep();
                        Thread.Sleep(10);

                    }
                    PrgLoad.Visible = false;
                    MessageBox.Show(" Phục hồi thời gian lúc " + dtStopAt + " Thành công!", "", MessageBoxButtons.OK);

                }
                else
                {
                    MessageBox.Show(" Phục hồi thất bại ", "", MessageBoxButtons.OK);
                }
            }

            else
            {
                return;
            }
        }

        private void dataTable1GridControl_Click(object sender, EventArgs e)
        {
        }

        private void btnThamsotime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng dùng để phục hồi lại dữ liệu sau khi delete,insert, update lỗi ", "", MessageBoxButtons.OK);
            if (btnThamsotime.Checked == true)
            {
                txtInfoPhucHoi.Visible = true;
                dtpDate.Visible = true;
                dtptTimeStop.Visible = true;
                lblinfo.Visible = true;
                ckiNit.Visible = false;
            }
            else
            {
                txtInfoPhucHoi.Visible = false;
                dtpDate.Visible = false;
                dtptTimeStop.Visible = false;
                lblinfo.Visible = false;
                ckiNit.Visible = true;


            }

        }

        private void grvBackup_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            soLuongBanSaoLuu = int.Parse(((DataRowView)bdsBackup[bdsBackup.Position])["position"].ToString());
            // MessageBox.Show(soLuongBanSaoLuu.ToString(), "", MessageBoxButtons.OK);
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog folderBrowser = new OpenFileDialog();
            folderBrowser.ValidateNames = false;
            folderBrowser.CheckFileExists = false;
            folderBrowser.CheckPathExists = true;
            folderBrowser.FileName = "Folder Selection.";
            if (folderBrowser.ShowDialog() == DialogResult.OK)
            {
                string folderPath = Path.GetDirectoryName(folderBrowser.FileName);
                Program.strDefaultPathNew = folderPath + "\\";
                String strFullPathBackLog = Program.strDefaultPathNew + Program.Db + ".TRN";
                String pathBack = Program.strDefaultPathNew + Program.Db + ".bak";
                strRestore += "BACKUP LOG " + Program.Db + " TO DISK='" + strFullPathBackLog + "' WITH INIT\n "
                   + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + pathBack + "' WITH NORECOVERY , REPLACE\n "
                    + "RESTORE DATABASE " + Program.Db + " FROM DISK='" + strFullPathBackLog + "' WITH STOPAT='"
                    + "'\n ALTER DATABASE " + Program.Db + " SET MULTI_USER";
                MessageBox.Show(" " + strRestore, "", MessageBoxButtons.OK);


            }
        }
    }
}
