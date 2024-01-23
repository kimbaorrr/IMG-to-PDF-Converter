using IMG_to_PDF_Converter.Models;
using Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace IMG_to_PDF_Converter
{
    public partial class Form1 : KryptonForm
    {
        private string[] fileNames { get; set; }
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            this.btn_ChuyenDoi.Enabled = this.chk_NULL();
            foreach (list_TimeType i in Enum.GetValues(typeof(list_TimeType)))
                this.combo_TimeType.Items.Add(i);
            this.combo_TimeType.SelectedIndex = 0;
        }

        private void txt_ChooseFiles_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog a = new OpenFileDialog())
            {
                a.Title = "Chọn các tệp cần chuyển đổi";
                a.Filter = "All Image Files|*.jpg;*.jpeg;*.png;*.bmp;*.webp;*.jpeg;|PNG Images (*.png)|*.png|JPG Images (*.jpg)|*.jpg|WebP Images (*.webp)|*.webp|Jpeg Images (*.jpeg)|*.jpeg";
                a.Multiselect = true;
                a.AddExtension = true;
                if (DialogResult.OK == a.ShowDialog())
                {
                    Array.Sort(a.FileNames);
                    this.fileNames = a.FileNames;
                    this.txt_Address.Text = Path.GetDirectoryName(a.FileNames[0]);
                }
            }
        }

        private void btn_thoatChuongTrinh_Click(object sender, EventArgs e)
        {
            DialogResult thongBao = this.thongBao("Bạn chắc chắn muốn thoát khỏi chương trình ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == thongBao)
                Application.Exit();
        }

        private void btn_chuyenDoi_Click(object sender, EventArgs e)
        {
            ChuyenDoi a = new ChuyenDoi()
            {
                Do_Dai_Mang = this.fileNames.Length,
                DS_Tep = this.fileNames,
                TenTepSauCD = this.txt_Name.Text,
                Duong_Dan_Luu_Tep = this.txt_ViTriLuuTep.Text
            };
            if (this.chkBox_GhiDe.Checked)
                a.GhiDeTep = true;
            a.chuyenDoi_Tep_PDF();
            Cursor.Current = Cursors.WaitCursor;
            if (a.ThongBao.Item2)
            {
                this.thongBao(a.ThongBao.Item1, MessageBoxButtons.OK, MessageBoxIcon.Information);
                Cursor.Current = Cursors.Default;
            }
            else
            {
                this.thongBao(a.ThongBao.Item1, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            this.tuyChon();
        }

        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            // Reset fields
            this.txt_Address.Clear();
            this.txt_Name.Clear();
            this.txt_ViTriLuuTep.Text = @"D:\";
            // Reset Checkboxs
            this.chkBox_OpenFolder.Checked = true;
            this.chkBox_Reset.Checked = true;
            this.chkBox_GhiDe.Checked = true;
            this.chkBox_XoaTepGoc.Checked = false;
            this.chkBox_TatMay.Checked = false;
            // Selected textBox "Name"
            this.txt_Name.Focus();
        }

        private void txt_SaveFile_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog b = new FolderBrowserDialog())
            {
                b.Description = "Chọn vị trí lưu tệp";
                b.ShowNewFolderButton = true;
                if (DialogResult.OK == b.ShowDialog())
                    this.txt_ViTriLuuTep.Text = b.SelectedPath;
            }
        }

        private void chkBox_XoaTepGoc_CheckedChanged(object sender, EventArgs e)
        {
            if (this.chkBox_XoaTepGoc.Checked)
            {
                DialogResult a = this.thongBao("Bạn chắc chắn muốn xóa tệp gốc sau khi chuyển đổi ?", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                if (a == DialogResult.OK)
                    this.chkBox_XoaTepGoc.Checked = true;
                else
                    this.chkBox_XoaTepGoc.Checked = false;
            }
        }
        /// <summary>
        /// Các tùy chọn sau khi hoàn thành
        /// </summary>
        private void tuyChon()
        {
            try
            {
                if (this.chkBox_XoaTepGoc.Checked)
                {
                    foreach (string s in this.fileNames)
                        File.Delete(s);
                    MessageBox.Show("Đã xóa " + this.fileNames.Length + " tệp gốc !", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                if (this.chkBox_OpenFolder.Checked)
                    Process.Start(this.txt_ViTriLuuTep.Text);
                if (this.chkBox_Reset.Checked)
                    this.btn_LamLai.PerformClick();
                if (this.chkBox_TatMay.Checked)
                {
                    switch (this.combo_TimeType.SelectedValue)
                    {
                        case "giờ":
                            Process.Start("shutdown", "/s /t " + this.num_TatMay.Value * 3600);
                            break;
                        case "phút":
                            Process.Start("shutdown", "/s /t " + this.num_TatMay.Value * 60);
                            break;
                        case "giây":
                            Process.Start("shutdown", "/s /t " + this.num_TatMay.Value);
                            break;
                    }
                }
            }
            catch (Exception ex)
            {
                ChuyenDoi.log_errors(ex.Message);
            }
        }
        /// <summary>
        /// Xuất bảng thông báo cho người dùng
        /// </summary>
        /// <param name="message">Nội dung</param>
        /// <param name="button">Nút</param>
        /// <param name="icon">Biểu tượng</param>
        /// <returns></returns>
        private DialogResult thongBao(string message, MessageBoxButtons button, MessageBoxIcon icon) =>
            MessageBox.Show(message, "Thông báo", button, icon);
        /// <summary>
        /// Kiểm tra điều kiện các biến có NULL không ?
        /// </summary>
        /// <returns></returns>
        private bool chk_NULL()
        {
            if (!string.IsNullOrEmpty(this.txt_Name.Text) && this.fileNames != null && !string.IsNullOrEmpty(this.txt_SaveFile.Text))
                return true;
            return false;
        }
        private enum list_TimeType
        {
            giờ,
            phút,
            giây
        }
    }
}
