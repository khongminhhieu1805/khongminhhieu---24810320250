namespace hoccsharp
{
    public class SanPham
    {
        public string MaSP { get; set; } = string.Empty;
        public string TenSP { get; set; } = string.Empty;
        public string DanhMuc { get; set; } = string.Empty;
        public decimal DonGia { get; set; }
        public int SoLuong { get; set; }
        public string DuongDanAnh { get; set; } = string.Empty;

        public SanPham() { }

        public SanPham(string maSP, string tenSP, string danhMuc, decimal donGia, int soLuong, string duongDanAnh)
        {
            MaSP = maSP;
            TenSP = tenSP;
            DanhMuc = danhMuc;
            DonGia = donGia;
            SoLuong = soLuong;
            DuongDanAnh = duongDanAnh;
        }
    }
}