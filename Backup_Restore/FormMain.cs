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
using Backup_Restore.Repositoies;
using Backup_Restore.Models;

namespace Backup_Restore
{
    public partial class FormMain : DevExpress.XtraEditors.XtraForm
    {

        String nameDevice;
        String strFullPathDevice;
        DatabaseRepository databaseRepository;
        DeviceRepository deviceRepository;
        BackupReposity backupReposity;

        public FormMain()
        {
            InitializeComponent();
            databaseRepository = new DatabaseRepository();
            deviceRepository = new DeviceRepository();
            backupReposity = new BackupReposity();


          
            Program.strDefaultPath = (string)Properties.Settings.Default["path"] ;

            //System.Configuration.SettingsProperty property = new System.Configuration.SettingsProperty("Sample1");
            //Properties.Settings.Default["Sample1"] = SomeStringValue;
            //Properties.Settings.Default.Save();

        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'DS.backup_devices' table. You can move, or remove it, as needed.
         
            gcDatabase.DataSource = databaseRepository.GetDatabases();

            Program.Db = ((DatabaseModel)grvDatabase.GetRow(grvDatabase.FocusedRowHandle)).Name;

            this.txtNameDB.Text = Program.Db;
           
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
                //this.dataTable1TableAdapter.Fill(this.DS.DataTable1, txtTenDB.Text);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void databasesGridControl_Click(object sender, EventArgs e)
        {
        }
        private void createDevice(string nameDevice, string path)
        {
            nameDevice = "DEVICE_" + Program.Db;
            strFullPathDevice = path + nameDevice + ".BAK";
           
            try
            {

                int res = deviceRepository.CreateDevice(Program.device_type, nameDevice, strFullPathDevice);
                if (res > 0)
                {
                   
                    MessageBox.Show(" Tạo Device thành công!", "", MessageBoxButtons.OK);
                    btnDevice.Enabled = false;
                    btnBackUpAd.Enabled = true;
                    txtNameDevice.Text = nameDevice;
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
                createDevice(Program.Db, Program.strDefaultPath);
            }
            else
            {
                FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                //folderBrowser.SelectedPath = Program.strDefaultPathNew;

                if (folderBrowser.ShowDialog() == DialogResult.OK)
                {
                    Program.strDefaultPath = folderBrowser.SelectedPath;
                    Properties.Settings.Default["path"] = Program.strDefaultPath;
                    Properties.Settings.Default.Save();

                    createDevice(Program.Db, Program.strDefaultPath);

                }
            }

        }

        private void fillToolStrip_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }



        private void btnSaoLuu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
        }

        private void LoadBackup()
        {
            if (Program.Db.Trim() == "") return;
            var backups = backupReposity.GetBackupByName(Program.Db);
            gcBackup.DataSource = backups;
            txtCountBackup.Text = backups.Count.ToString();
            grvBackup.FocusInvalidRow();
        }

        private void grvDatabase_RowClick(object sender, DevExpress.XtraGrid.Views.Grid.RowClickEventArgs e)
        {
            Program.Db = ((DatabaseModel)grvDatabase.GetRow(grvDatabase.FocusedRowHandle)).Name;
            
            txtNameDB.Text = Program.Db;
            nameDevice = "DEVICE_" + Program.Db;
            strFullPathDevice = Program.strDefaultPath + nameDevice + ".BAK";
            DeviceModel device = deviceRepository.GetDevices().Find(x => x.Name == nameDevice);
           // MessageBox.Show(" check device" + checkTrungDevice,"", MessageBoxButtons.OK);
            if (device == null)
            {
                this.txtNameDevice.Text = "Chưa có Device";
                this.btnDevice.Enabled = true;
                this.btnBackUpAd.Enabled = false;
            }
            else
            {
                this.txtNameDevice.Text = device.Name;
                this.btnDevice.Enabled = false;
                this.btnBackUpAd.Enabled = true;
                this.btnRestore.Enabled = true;
                this.btnTimeParam.Enabled = true;
            }
          

            LoadBackup();

        }

        private void btnSaoLuuAd_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {

            if (Program.Db.Trim() == "" || nameDevice == "") return;

            bool isInit = false;
            if (ckiNit.Checked == true)
            {
                if (MessageBox.Show("Bạn có muốn xóa các sao lưu cũ ?", "Xác nhận", MessageBoxButtons.OKCancel) == DialogResult.OK)
                    isInit = true;

            }

            try
            {

                int res = backupReposity.CreateBackup(Program.Db, nameDevice, "FULL backup", isInit);

                if (res > 0)
                {                   
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
            LoadBackup();

        }

        private void btnPhucHoi_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            int res;
            int err = 0;
            
            if (grvBackup.DataRowCount == 0)
            {
                MessageBox.Show("Chưa có bản sao lưu nào phụ hồi", "!", MessageBoxButtons.OK);
                return;
            }
            if (grvBackup.FocusedRowHandle < 0)
            {
                MessageBox.Show("Vui lòng chọn bản sao lưu phục hồi ", "!", MessageBoxButtons.OK);
                return;
            }
          
         
            int pos = ((BackupModel)grvBackup.GetRow(grvBackup.FocusedRowHandle)).Position;
            if (btnTimeParam.Checked == false)
            {

                res = backupReposity.RetoreBackup(Program.Db, nameDevice, pos);
                if (res >= 0)
                {                 
                    MessageBox.Show(" Phục hồi thành công!", "", MessageBoxButtons.OK);
                }
            }
            else
            {
                DateTime ngaygioBK = ((BackupModel)grvBackup.GetRow(grvBackup.FocusedRowHandle)).Backup_Start_Date;
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
                        RestoreWithTime(dateStop);
                    }
                    else
                    {
                  
                        FolderBrowserDialog folderBrowser = new FolderBrowserDialog();
                        if (folderBrowser.ShowDialog() == DialogResult.OK)
                        {
                            Program.strDefaultPath = folderBrowser.SelectedPath ;
                            
                            Properties.Settings.Default["path"] = Program.strDefaultPath;
                            Properties.Settings.Default.Save();
                            String strFullPathBackLog = Program.strDefaultPath  + "\\"+ Program.Db + ".TRN";
                            RestoreWithTime(dateStop);
                        }

                        else
                        {
                            return;
                        }
                    }
                }
            }
        }

        
        public void RestoreWithTime(DateTime dateStop)
        {
            String strFullPathBackLog = Program.strDefaultPath + Program.Db + ".TRN";
            int res = backupReposity.RetoreBackupToTime(Program.Db, nameDevice, strFullPathBackLog, dateStop);

            if (res >= 0)
            {

                MessageBox.Show(" Phục hồi thời gian lúc " + dateStop.ToString("yyyy-MM-dd HH:mm:ss") + " Thành công!", "", MessageBoxButtons.OK);

            }
            else
            {
                MessageBox.Show(" Sai đường dẫn backup . Kiểm tra lại  ", "", MessageBoxButtons.OK);
            }
        }


        private void btnThamsotime_CheckedChanged(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng dùng để phục hồi lại dữ liệu sau khi delete,insert, update lỗi ", "", MessageBoxButtons.OK);
            if (btnTimeParam.Checked == true)
            {
                txtInfoRestore.Visible = true;
                dtpDate.Visible = true;
                dtptTimeStop.Visible = true;
                lblinfo.Visible = true;
                ckiNit.Visible = false;
            }
            else
            {
                txtInfoRestore.Visible = false;
                dtpDate.Visible = false;
                dtptTimeStop.Visible = false;
                lblinfo.Visible = false;
                ckiNit.Visible = true;


            }

        }


       
    }
}
