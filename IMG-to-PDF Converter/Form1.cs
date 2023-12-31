﻿using IMG_to_PDF_Converter.Models;
using Krypton.Toolkit;
using System;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Imaging;
using System.IO;
using System.IO.Compression;
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
            DialogResult thongBao = this.thongBao("Bạn chắc chắn muốn thoát khỏi chương trình ?", "Thông báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (DialogResult.OK == thongBao)
                Application.Exit();
        }

        private void btn_chuyenDoi_Click(object sender, EventArgs e)
        {
            try
            {
                ChuyenDoi a = new ChuyenDoi()
                {
                    Do_Dai_Mang = (byte)this.fileNames.Length,
                    DS_Tep = this.fileNames,
                    TenTepSauCD = this.txt_Name.Text,
                    Duong_Dan_Luu_Tep = this.txt_ViTriLuuTep.Text
                };
                if (this.chkBox_GhiDe.Checked)
                    a.GhiDeTep = true;
                a.chuyenDoi_Tep_PDF();
                Cursor.Current = Cursors.WaitCursor;
                if (!string.IsNullOrEmpty(a.ThongBao))
                {
                    this.thongBao(a.ThongBao, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    Cursor.Current = Cursors.Default;
                }
                this.tuyChon();
            }
            catch (Exception ex)
            {
                ChuyenDoi.log_errors(ex.Message);
            }
        }

        private void btn_lamLai_Click(object sender, EventArgs e)
        {
            // Reset fields
            this.txt_Address.Clear();
            this.txt_Name.Clear();
            this.txt_ViTriLuuTep.Text = @"C:\";
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
                DialogResult a = this.thongBao("Bạn chắc chắn muốn xóa tệp gốc sau khi chuyển đổi ?", "Cảnh báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
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
        private DialogResult thongBao(string message, string title, MessageBoxButtons button, MessageBoxIcon icon) =>
            MessageBox.Show(message, title, button, icon);
        private bool chk_NULL()
            => !string.IsNullOrEmpty(this.txt_Name.Text);
        private enum list_TimeType
        {
            giờ,
            phút,
            giây
        }
    }
}
