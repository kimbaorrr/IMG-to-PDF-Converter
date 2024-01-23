namespace IMG_to_PDF_Converter
{
    partial class Form1
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.kryptonLabel1 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel2 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonLabel3 = new Krypton.Toolkit.KryptonLabel();
            this.btn_ChuyenDoi = new Krypton.Toolkit.KryptonButton();
            this.btn_LamLai = new Krypton.Toolkit.KryptonButton();
            this.btn_Thoat = new Krypton.Toolkit.KryptonButton();
            this.txt_Name = new Krypton.Toolkit.KryptonTextBox();
            this.txt_Address = new Krypton.Toolkit.KryptonTextBox();
            this.txt_ChooseFiles = new Krypton.Toolkit.KryptonButton();
            this.txt_ViTriLuuTep = new Krypton.Toolkit.KryptonTextBox();
            this.kryptonLabel4 = new Krypton.Toolkit.KryptonLabel();
            this.kryptonPanel1 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel3 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonPanel2 = new Krypton.Toolkit.KryptonPanel();
            this.kryptonGroupBox1 = new Krypton.Toolkit.KryptonGroupBox();
            this.combo_TimeType = new Krypton.Toolkit.KryptonComboBox();
            this.chkBox_NenZip = new Krypton.Toolkit.KryptonCheckBox();
            this.num_TatMay = new Krypton.Toolkit.KryptonNumericUpDown();
            this.chkBox_TatMay = new Krypton.Toolkit.KryptonCheckBox();
            this.chkBox_XoaTepGoc = new Krypton.Toolkit.KryptonCheckBox();
            this.chkBox_GhiDe = new Krypton.Toolkit.KryptonCheckBox();
            this.chkBox_OpenFolder = new Krypton.Toolkit.KryptonCheckBox();
            this.chkBox_Reset = new Krypton.Toolkit.KryptonCheckBox();
            this.txt_SaveFile = new Krypton.Toolkit.KryptonButton();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).BeginInit();
            this.kryptonPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).BeginInit();
            this.kryptonPanel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).BeginInit();
            this.kryptonPanel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).BeginInit();
            this.kryptonGroupBox1.Panel.SuspendLayout();
            this.kryptonGroupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.combo_TimeType)).BeginInit();
            this.SuspendLayout();
            // 
            // kryptonLabel1
            // 
            this.kryptonLabel1.LabelStyle = Krypton.Toolkit.LabelStyle.BoldPanel;
            this.kryptonLabel1.Location = new System.Drawing.Point(400, 40);
            this.kryptonLabel1.Name = "kryptonLabel1";
            this.kryptonLabel1.Size = new System.Drawing.Size(572, 69);
            this.kryptonLabel1.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kryptonLabel1.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel1.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel1.TabIndex = 0;
            this.kryptonLabel1.Values.Text = "IMG-to-PDF Converter";
            // 
            // kryptonLabel2
            // 
            this.kryptonLabel2.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel2.Location = new System.Drawing.Point(156, 132);
            this.kryptonLabel2.Name = "kryptonLabel2";
            this.kryptonLabel2.Size = new System.Drawing.Size(218, 40);
            this.kryptonLabel2.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kryptonLabel2.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel2.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel2.TabIndex = 1;
            this.kryptonLabel2.Values.Text = "Đường dẫn tệp";
            // 
            // kryptonLabel3
            // 
            this.kryptonLabel3.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel3.Location = new System.Drawing.Point(38, 42);
            this.kryptonLabel3.Name = "kryptonLabel3";
            this.kryptonLabel3.Size = new System.Drawing.Size(336, 40);
            this.kryptonLabel3.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kryptonLabel3.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel3.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel3.TabIndex = 2;
            this.kryptonLabel3.Values.Text = "Tên tệp sau chuyển đổi";
            // 
            // btn_ChuyenDoi
            // 
            this.btn_ChuyenDoi.CornerRoundingRadius = -1F;
            this.btn_ChuyenDoi.Location = new System.Drawing.Point(37, 18);
            this.btn_ChuyenDoi.Name = "btn_ChuyenDoi";
            this.btn_ChuyenDoi.Size = new System.Drawing.Size(316, 122);
            this.btn_ChuyenDoi.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_ChuyenDoi.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_ChuyenDoi.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_ChuyenDoi.TabIndex = 3;
            this.btn_ChuyenDoi.ToolTipValues.Description = "Bắt đầu chuyển đổi (các) tệp hình ảnh sang PDF";
            this.btn_ChuyenDoi.ToolTipValues.EnableToolTips = true;
            this.btn_ChuyenDoi.ToolTipValues.Heading = "Chú thích";
            this.btn_ChuyenDoi.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.btn_ChuyenDoi.Values.Image = global::IMG_to_PDF_Converter.Properties.Resources.submit;
            this.btn_ChuyenDoi.Values.Text = "&Chuyển đổi";
            this.btn_ChuyenDoi.Click += new System.EventHandler(this.btn_chuyenDoi_Click);
            // 
            // btn_LamLai
            // 
            this.btn_LamLai.CornerRoundingRadius = -1F;
            this.btn_LamLai.Location = new System.Drawing.Point(497, 18);
            this.btn_LamLai.Name = "btn_LamLai";
            this.btn_LamLai.Size = new System.Drawing.Size(316, 122);
            this.btn_LamLai.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_LamLai.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_LamLai.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_LamLai.TabIndex = 4;
            this.btn_LamLai.ToolTipValues.Description = "Thực hiện Reset tất cả tham số đầu vào";
            this.btn_LamLai.ToolTipValues.EnableToolTips = true;
            this.btn_LamLai.ToolTipValues.Heading = "Chú thích";
            this.btn_LamLai.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.btn_LamLai.Values.Image = ((System.Drawing.Image)(resources.GetObject("btn_LamLai.Values.Image")));
            this.btn_LamLai.Values.Text = "&Làm lại";
            this.btn_LamLai.Click += new System.EventHandler(this.btn_lamLai_Click);
            // 
            // btn_Thoat
            // 
            this.btn_Thoat.CornerRoundingRadius = -1F;
            this.btn_Thoat.Location = new System.Drawing.Point(957, 18);
            this.btn_Thoat.Name = "btn_Thoat";
            this.btn_Thoat.Size = new System.Drawing.Size(316, 122);
            this.btn_Thoat.StateCommon.Content.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.btn_Thoat.StateCommon.Content.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.btn_Thoat.StateCommon.Content.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.btn_Thoat.TabIndex = 5;
            this.btn_Thoat.ToolTipValues.Description = "Thoát khỏi chương trình";
            this.btn_Thoat.ToolTipValues.EnableToolTips = true;
            this.btn_Thoat.ToolTipValues.Heading = "Chú thích";
            this.btn_Thoat.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.btn_Thoat.Values.Image = global::IMG_to_PDF_Converter.Properties.Resources.exit;
            this.btn_Thoat.Values.Text = "&Thoát";
            this.btn_Thoat.Click += new System.EventHandler(this.btn_thoatChuongTrinh_Click);
            // 
            // txt_Name
            // 
            this.txt_Name.CueHint.CueHintText = "Ví dụ: ABCD,...";
            this.txt_Name.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txt_Name.Location = new System.Drawing.Point(410, 42);
            this.txt_Name.Name = "txt_Name";
            this.txt_Name.Size = new System.Drawing.Size(842, 47);
            this.txt_Name.TabIndex = 7;
            this.txt_Name.TextChanged += new System.EventHandler(this.Form1_Load);
            // 
            // txt_Address
            // 
            this.txt_Address.CueHint.CueHintText = "Chọn tệp để chuyển đổi !";
            this.txt_Address.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txt_Address.Location = new System.Drawing.Point(410, 132);
            this.txt_Address.Name = "txt_Address";
            this.txt_Address.ReadOnly = true;
            this.txt_Address.Size = new System.Drawing.Size(783, 47);
            this.txt_Address.TabIndex = 8;
            this.txt_Address.TextChanged += new System.EventHandler(this.Form1_Load);
            this.txt_Address.Click += new System.EventHandler(this.txt_ChooseFiles_Click);
            // 
            // txt_ChooseFiles
            // 
            this.txt_ChooseFiles.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.txt_ChooseFiles.CornerRoundingRadius = -1F;
            this.txt_ChooseFiles.Location = new System.Drawing.Point(1193, 131);
            this.txt_ChooseFiles.Name = "txt_ChooseFiles";
            this.txt_ChooseFiles.Size = new System.Drawing.Size(60, 45);
            this.txt_ChooseFiles.TabIndex = 9;
            this.txt_ChooseFiles.Values.Text = "...";
            this.txt_ChooseFiles.Click += new System.EventHandler(this.txt_ChooseFiles_Click);
            // 
            // txt_ViTriLuuTep
            // 
            this.txt_ViTriLuuTep.CueHint.CueHintText = "Ví dụ: C:\\Desktop";
            this.txt_ViTriLuuTep.CueHint.Padding = new System.Windows.Forms.Padding(0);
            this.txt_ViTriLuuTep.Location = new System.Drawing.Point(410, 222);
            this.txt_ViTriLuuTep.Name = "txt_ViTriLuuTep";
            this.txt_ViTriLuuTep.ReadOnly = true;
            this.txt_ViTriLuuTep.Size = new System.Drawing.Size(783, 48);
            this.txt_ViTriLuuTep.TabIndex = 11;
            this.txt_ViTriLuuTep.Text = "D:\\";
            this.txt_ViTriLuuTep.Click += new System.EventHandler(this.txt_SaveFile_Click);
            // 
            // kryptonLabel4
            // 
            this.kryptonLabel4.LabelStyle = Krypton.Toolkit.LabelStyle.NormalPanel;
            this.kryptonLabel4.Location = new System.Drawing.Point(195, 222);
            this.kryptonLabel4.Name = "kryptonLabel4";
            this.kryptonLabel4.Size = new System.Drawing.Size(179, 40);
            this.kryptonLabel4.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.kryptonLabel4.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.kryptonLabel4.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.kryptonLabel4.TabIndex = 10;
            this.kryptonLabel4.Values.Text = "Vị trí lưu tệp";
            // 
            // kryptonPanel1
            // 
            this.kryptonPanel1.Controls.Add(this.kryptonPanel3);
            this.kryptonPanel1.Controls.Add(this.kryptonLabel1);
            this.kryptonPanel1.Controls.Add(this.kryptonPanel2);
            this.kryptonPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.kryptonPanel1.Location = new System.Drawing.Point(0, 0);
            this.kryptonPanel1.Name = "kryptonPanel1";
            this.kryptonPanel1.Size = new System.Drawing.Size(1373, 861);
            this.kryptonPanel1.TabIndex = 12;
            // 
            // kryptonPanel3
            // 
            this.kryptonPanel3.Controls.Add(this.btn_Thoat);
            this.kryptonPanel3.Controls.Add(this.btn_LamLai);
            this.kryptonPanel3.Controls.Add(this.btn_ChuyenDoi);
            this.kryptonPanel3.Location = new System.Drawing.Point(36, 692);
            this.kryptonPanel3.Name = "kryptonPanel3";
            this.kryptonPanel3.Size = new System.Drawing.Size(1305, 159);
            this.kryptonPanel3.TabIndex = 14;
            // 
            // kryptonPanel2
            // 
            this.kryptonPanel2.Controls.Add(this.kryptonGroupBox1);
            this.kryptonPanel2.Controls.Add(this.txt_SaveFile);
            this.kryptonPanel2.Controls.Add(this.txt_ViTriLuuTep);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel4);
            this.kryptonPanel2.Controls.Add(this.txt_ChooseFiles);
            this.kryptonPanel2.Controls.Add(this.txt_Address);
            this.kryptonPanel2.Controls.Add(this.txt_Name);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel3);
            this.kryptonPanel2.Controls.Add(this.kryptonLabel2);
            this.kryptonPanel2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.kryptonPanel2.Location = new System.Drawing.Point(36, 138);
            this.kryptonPanel2.Name = "kryptonPanel2";
            this.kryptonPanel2.Size = new System.Drawing.Size(1305, 537);
            this.kryptonPanel2.TabIndex = 13;
            // 
            // kryptonGroupBox1
            // 
            this.kryptonGroupBox1.CaptionStyle = Krypton.Toolkit.LabelStyle.GroupBoxCaption;
            this.kryptonGroupBox1.GroupBackStyle = Krypton.Toolkit.PaletteBackStyle.ControlGroupBox;
            this.kryptonGroupBox1.GroupBorderStyle = Krypton.Toolkit.PaletteBorderStyle.ControlGroupBox;
            this.kryptonGroupBox1.Location = new System.Drawing.Point(45, 291);
            this.kryptonGroupBox1.Name = "kryptonGroupBox1";
            // 
            // kryptonGroupBox1.Panel
            // 
            this.kryptonGroupBox1.Panel.Controls.Add(this.combo_TimeType);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_NenZip);
            this.kryptonGroupBox1.Panel.Controls.Add(this.num_TatMay);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_TatMay);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_XoaTepGoc);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_GhiDe);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_OpenFolder);
            this.kryptonGroupBox1.Panel.Controls.Add(this.chkBox_Reset);
            this.kryptonGroupBox1.Size = new System.Drawing.Size(1215, 221);
            this.kryptonGroupBox1.TabIndex = 15;
            this.kryptonGroupBox1.Values.Heading = "Các tùy chọn (Sau khi hoàn tất)";
            // 
            // combo_TimeType
            // 
            this.combo_TimeType.CornerRoundingRadius = -1F;
            this.combo_TimeType.DropDownWidth = 105;
            this.combo_TimeType.IntegralHeight = false;
            this.combo_TimeType.Location = new System.Drawing.Point(1049, 23);
            this.combo_TimeType.Name = "combo_TimeType";
            this.combo_TimeType.Size = new System.Drawing.Size(114, 45);
            this.combo_TimeType.StateCommon.ComboBox.Content.TextH = Krypton.Toolkit.PaletteRelativeAlign.Near;
            this.combo_TimeType.TabIndex = 22;
            // 
            // chkBox_NenZip
            // 
            this.chkBox_NenZip.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_NenZip.Location = new System.Drawing.Point(736, 96);
            this.chkBox_NenZip.Name = "chkBox_NenZip";
            this.chkBox_NenZip.Size = new System.Drawing.Size(284, 40);
            this.chkBox_NenZip.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_NenZip.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_NenZip.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_NenZip.TabIndex = 21;
            this.chkBox_NenZip.ToolTipValues.Description = "Thực hiện nén (các) tệp gốc sau khi hoàn tất";
            this.chkBox_NenZip.ToolTipValues.EnableToolTips = true;
            this.chkBox_NenZip.ToolTipValues.Heading = "Chú thích";
            this.chkBox_NenZip.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_NenZip.Values.Text = "Nén tệp gốc (*.zip)";
            // 
            // num_TatMay
            // 
            this.num_TatMay.Location = new System.Drawing.Point(939, 23);
            this.num_TatMay.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.num_TatMay.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.num_TatMay.Name = "num_TatMay";
            this.num_TatMay.Size = new System.Drawing.Size(104, 46);
            this.num_TatMay.TabIndex = 19;
            this.num_TatMay.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // chkBox_TatMay
            // 
            this.chkBox_TatMay.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_TatMay.Location = new System.Drawing.Point(736, 29);
            this.chkBox_TatMay.Name = "chkBox_TatMay";
            this.chkBox_TatMay.Size = new System.Drawing.Size(199, 40);
            this.chkBox_TatMay.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_TatMay.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_TatMay.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_TatMay.TabIndex = 18;
            this.chkBox_TatMay.ToolTipValues.Description = "Thực hiện tắt máy sau \"n\" giờ/phút/giây sau khi hoàn thành";
            this.chkBox_TatMay.ToolTipValues.EnableToolTips = true;
            this.chkBox_TatMay.ToolTipValues.Heading = "Chú thích";
            this.chkBox_TatMay.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_TatMay.Values.Text = "Tắt máy sau ";
            // 
            // chkBox_XoaTepGoc
            // 
            this.chkBox_XoaTepGoc.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_XoaTepGoc.Location = new System.Drawing.Point(367, 96);
            this.chkBox_XoaTepGoc.Name = "chkBox_XoaTepGoc";
            this.chkBox_XoaTepGoc.Size = new System.Drawing.Size(194, 40);
            this.chkBox_XoaTepGoc.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_XoaTepGoc.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_XoaTepGoc.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_XoaTepGoc.TabIndex = 16;
            this.chkBox_XoaTepGoc.ToolTipValues.Description = "Xóa (các) tệp gốc sau khi hoàn tất";
            this.chkBox_XoaTepGoc.ToolTipValues.EnableToolTips = true;
            this.chkBox_XoaTepGoc.ToolTipValues.Heading = "Chú thích";
            this.chkBox_XoaTepGoc.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_XoaTepGoc.Values.Text = "Xóa tệp gốc";
            this.chkBox_XoaTepGoc.CheckedChanged += new System.EventHandler(this.chkBox_XoaTepGoc_CheckedChanged);
            // 
            // chkBox_GhiDe
            // 
            this.chkBox_GhiDe.Checked = true;
            this.chkBox_GhiDe.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_GhiDe.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_GhiDe.Location = new System.Drawing.Point(368, 29);
            this.chkBox_GhiDe.Name = "chkBox_GhiDe";
            this.chkBox_GhiDe.Size = new System.Drawing.Size(306, 40);
            this.chkBox_GhiDe.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_GhiDe.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_GhiDe.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_GhiDe.TabIndex = 15;
            this.chkBox_GhiDe.ToolTipValues.Description = "Ghi đề tệp đã tồn tại tại \"Vị trí lưu tệp\"";
            this.chkBox_GhiDe.ToolTipValues.EnableToolTips = true;
            this.chkBox_GhiDe.ToolTipValues.Heading = "Chú thích";
            this.chkBox_GhiDe.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_GhiDe.Values.Text = "Ghi đè tệp đã tồn tại";
            // 
            // chkBox_OpenFolder
            // 
            this.chkBox_OpenFolder.Checked = true;
            this.chkBox_OpenFolder.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_OpenFolder.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_OpenFolder.Location = new System.Drawing.Point(51, 29);
            this.chkBox_OpenFolder.Name = "chkBox_OpenFolder";
            this.chkBox_OpenFolder.Size = new System.Drawing.Size(255, 40);
            this.chkBox_OpenFolder.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_OpenFolder.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_OpenFolder.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_OpenFolder.TabIndex = 13;
            this.chkBox_OpenFolder.ToolTipValues.Description = "Tự động mở thư mục đích (được định nghĩa trên trường \"Vị trí lưu tệp\") khi hoàn t" +
    "ất";
            this.chkBox_OpenFolder.ToolTipValues.EnableToolTips = true;
            this.chkBox_OpenFolder.ToolTipValues.Heading = "Chú thích";
            this.chkBox_OpenFolder.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_OpenFolder.Values.Text = "Mở thư mục đích";
            // 
            // chkBox_Reset
            // 
            this.chkBox_Reset.Checked = true;
            this.chkBox_Reset.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chkBox_Reset.LabelStyle = Krypton.Toolkit.LabelStyle.NormalControl;
            this.chkBox_Reset.Location = new System.Drawing.Point(51, 96);
            this.chkBox_Reset.Name = "chkBox_Reset";
            this.chkBox_Reset.Size = new System.Drawing.Size(240, 40);
            this.chkBox_Reset.StateCommon.ShortText.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.chkBox_Reset.StateCommon.ShortText.ImageStyle = Krypton.Toolkit.PaletteImageStyle.Inherit;
            this.chkBox_Reset.StateCommon.ShortText.Trim = Krypton.Toolkit.PaletteTextTrim.Inherit;
            this.chkBox_Reset.TabIndex = 14;
            this.chkBox_Reset.ToolTipValues.Description = "Tự động nhấn nút \"Làm lại\" sau khi hoàn tất";
            this.chkBox_Reset.ToolTipValues.EnableToolTips = true;
            this.chkBox_Reset.ToolTipValues.Heading = "Chú thích";
            this.chkBox_Reset.ToolTipValues.ToolTipStyle = Krypton.Toolkit.LabelStyle.SuperTip;
            this.chkBox_Reset.Values.Text = "Tự động làm lại";
            // 
            // txt_SaveFile
            // 
            this.txt_SaveFile.ButtonStyle = Krypton.Toolkit.ButtonStyle.Alternate;
            this.txt_SaveFile.CornerRoundingRadius = -1F;
            this.txt_SaveFile.Location = new System.Drawing.Point(1193, 222);
            this.txt_SaveFile.Name = "txt_SaveFile";
            this.txt_SaveFile.Size = new System.Drawing.Size(60, 45);
            this.txt_SaveFile.TabIndex = 12;
            this.txt_SaveFile.Values.Text = "...";
            this.txt_SaveFile.Click += new System.EventHandler(this.txt_SaveFile_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1373, 861);
            this.Controls.Add(this.kryptonPanel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "IMG-to-PDF Converter";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel1)).EndInit();
            this.kryptonPanel1.ResumeLayout(false);
            this.kryptonPanel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel3)).EndInit();
            this.kryptonPanel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.kryptonPanel2)).EndInit();
            this.kryptonPanel2.ResumeLayout(false);
            this.kryptonPanel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1.Panel)).EndInit();
            this.kryptonGroupBox1.Panel.ResumeLayout(false);
            this.kryptonGroupBox1.Panel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.kryptonGroupBox1)).EndInit();
            this.kryptonGroupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.combo_TimeType)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Krypton.Toolkit.KryptonLabel kryptonLabel1;
        private Krypton.Toolkit.KryptonLabel kryptonLabel2;
        private Krypton.Toolkit.KryptonLabel kryptonLabel3;
        private Krypton.Toolkit.KryptonButton btn_ChuyenDoi;
        private Krypton.Toolkit.KryptonButton btn_LamLai;
        private Krypton.Toolkit.KryptonButton btn_Thoat;
        private Krypton.Toolkit.KryptonTextBox txt_Name;
        private Krypton.Toolkit.KryptonTextBox txt_Address;
        private Krypton.Toolkit.KryptonButton txt_ChooseFiles;
        private Krypton.Toolkit.KryptonTextBox txt_ViTriLuuTep;
        private Krypton.Toolkit.KryptonLabel kryptonLabel4;
        private Krypton.Toolkit.KryptonPanel kryptonPanel1;
        private Krypton.Toolkit.KryptonPanel kryptonPanel2;
        private Krypton.Toolkit.KryptonPanel kryptonPanel3;
        private Krypton.Toolkit.KryptonButton txt_SaveFile;
        private Krypton.Toolkit.KryptonGroupBox kryptonGroupBox1;
        private Krypton.Toolkit.KryptonCheckBox chkBox_OpenFolder;
        private Krypton.Toolkit.KryptonCheckBox chkBox_Reset;
        private Krypton.Toolkit.KryptonCheckBox chkBox_XoaTepGoc;
        private Krypton.Toolkit.KryptonCheckBox chkBox_GhiDe;
        private Krypton.Toolkit.KryptonNumericUpDown num_TatMay;
        private Krypton.Toolkit.KryptonCheckBox chkBox_TatMay;
        private Krypton.Toolkit.KryptonCheckBox chkBox_NenZip;
        private Krypton.Toolkit.KryptonComboBox combo_TimeType;
    }
}

