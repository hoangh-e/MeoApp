namespace Meow.Models
{
    public class PhanHoiMeoYeuThich
    {
        [JsonPropertyName("id")]
        public int MaYeuThich { get; set; }

        [JsonPropertyName("user_id")]
        public string MaNguoiDung { get; set; }

        [JsonPropertyName("image_id")]
        public string MaAnhMeo { get; set; }

        [JsonPropertyName("sub_id")]
        public string MaPhu { get; set; }

        [JsonPropertyName("created_at")]
        public DateTime NgayTao { get; set; }

        [JsonPropertyName("image")]
        public HinhAnh ThongTinAnh { get; set; }
    }

    public class HinhAnh
    {
        [JsonPropertyName("id")]
        public string MaAnh { get; set; }

        [JsonPropertyName("url")]
        public string DuongDanAnh { get; set; }
    }
}