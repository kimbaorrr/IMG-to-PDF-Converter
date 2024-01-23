using iText.IO.Image;
using iText.Kernel.Geom;
using iText.Kernel.Pdf;
using iText.Layout;
using iText.Layout.Element;
using System;
using System.IO;
using Path = System.IO.Path;

namespace IMG_to_PDF_Converter.Models
{
    internal class ChuyenDoi
    {
        public string[] DS_Tep { get; set; }
        public string TenTepSauCD { get; set; }
        public Tuple<string, bool> ThongBao { get; set; }
        public string Duong_Dan_Luu_Tep { get; set; }
        public bool GhiDeTep { get; set; }
        public int Do_Dai_Mang { get; set; }
        /// <summary>
        /// Default Constructor
        /// </summary>
        public ChuyenDoi()
        {
            this.Do_Dai_Mang = 255;
            this.DS_Tep = new string[this.Do_Dai_Mang];
            this.TenTepSauCD = "Converted";
            this.ThongBao = Tuple.Create("", false);
            this.Duong_Dan_Luu_Tep = @"D:\";
            this.GhiDeTep = false;
        }
        /// <summary>
        /// Chuyển đổi các tệp sang PDF
        /// </summary>
        public void chuyenDoi_Tep_PDF()
        {
            try
            {
                string filePath = Path.Combine(this.Duong_Dan_Luu_Tep, this.TenTepSauCD + ".pdf");
                if (File.Exists(filePath) && !this.GhiDeTep)
                    this.TenTepSauCD = this.TenTepSauCD + DateTime.Now.ToString("-ddMMyyyyHHmmss");
                PdfWriter writer = new PdfWriter(filePath);
                using (PdfDocument pdf = new PdfDocument(writer))
                {
                    Document a = new Document(pdf, PageSize.A4);
                    foreach (string i in this.DS_Tep)
                    {
                        Image image = new Image(ImageDataFactory.Create(i));
                        float maxWidth = a.GetPdfDocument().GetDefaultPageSize().GetWidth() - a.GetLeftMargin() - a.GetRightMargin();
                        float maxHeight = a.GetPdfDocument().GetDefaultPageSize().GetHeight() - a.GetTopMargin() - a.GetBottomMargin(); ;
                        if (image.GetImageHeight() > maxHeight || image.GetImageWidth() > maxWidth)
                            image.ScaleToFit(maxWidth, maxHeight);
                        a.Add(image);
                    }
                    a.Close();
                    this.ThongBao = Tuple.Create("Chuyển đổi thành công !", true);
                }
            }
            catch (Exception ex)
            {
                this.ThongBao = Tuple.Create("Quá trình chuyển đổi không thành công !\nLỗi: " + ex.Message, false);
                log_errors(ex.Message);
            }
        }
        public static void log_errors(string message)
        {
            File.AppendAllText(@"D:\IMG-to-PDF_Errors.txt", "\n" + DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss zz") + "\t" + message);
        }
    }
}
