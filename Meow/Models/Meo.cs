namespace Meow.Models
{
    public class Meo
    {
        [JsonPropertyName("breeds")]
        public List<GiongMeo> DanhSachGiong { get; set; }

        [JsonPropertyName("id")]
        public string MaAnh { get; set; }

        [JsonPropertyName("url")]
        public string DuongDanAnh { get; set; }

        [JsonPropertyName("width")]
        public int ChieuRong { get; set; }

        [JsonPropertyName("height")]
        public int ChieuCao { get; set; }
    }

    public class GiongMeo
    {
        [JsonPropertyName("weight")]
        public TrongLuong KhoiLuong { get; set; }

        [JsonPropertyName("id")]
        public string MaGiong { get; set; }

        [JsonPropertyName("name")]
        public string TenGiong { get; set; }

        [JsonPropertyName("cfa_url")]
        public string DuongDanCFA { get; set; }

        [JsonPropertyName("vetstreet_url")]
        public string DuongDanVetstreet { get; set; }

        [JsonPropertyName("vcahospitals_url")]
        public string DuongDanVCA { get; set; }

        [JsonPropertyName("temperament")]
        public string TinhCach { get; set; }

        [JsonPropertyName("origin")]
        public string XuatXu { get; set; }

        [JsonPropertyName("country_codes")]
        public string MaQuocGia { get; set; }

        [JsonPropertyName("country_code")]
        public string VietTatQuocGia { get; set; }

        [JsonPropertyName("description")]
        public string MoTa { get; set; }

        [JsonPropertyName("life_span")]
        public string TuoiTho { get; set; }

        [JsonPropertyName("indoor")]
        public int SongTrongNha { get; set; }

        [JsonPropertyName("lap")]
        public int ThichNgoiLong { get; set; }

        [JsonPropertyName("alt_names")]
        public string TenKhac { get; set; }

        [JsonPropertyName("adaptability")]
        public int DeThichNghi { get; set; }

        [JsonPropertyName("affection_level")]
        public int MucDoTrian { get; set; }

        [JsonPropertyName("child_friendly")]
        public int ThanThienTreEm { get; set; }

        [JsonPropertyName("dog_friendly")]
        public int ThanThienVoiCho { get; set; }

        [JsonPropertyName("energy_level")]
        public int MucNangLuong { get; set; }

        [JsonPropertyName("grooming")]
        public int DeChamSoc { get; set; }

        [JsonPropertyName("health_issues")]
        public int VanDeSucKhoe { get; set; }

        [JsonPropertyName("intelligence")]
        public int TriThongMinh { get; set; }

        [JsonPropertyName("shedding_level")]
        public int MucRungLong { get; set; }

        [JsonPropertyName("social_needs")]
        public int NhuCauXaHoi { get; set; }

        [JsonPropertyName("stranger_friendly")]
        public int ThanThienVoiNguoiLa { get; set; }

        [JsonPropertyName("vocalisation")]
        public int HayKeu { get; set; }

        [JsonPropertyName("experimental")]
        public int ThuNghiem { get; set; }

        [JsonPropertyName("hairless")]
        public int KhongLong { get; set; }

        [JsonPropertyName("natural")]
        public int TuNhien { get; set; }

        [JsonPropertyName("rare")]
        public int HiemGap { get; set; }

        [JsonPropertyName("rex")]
        public int Rex { get; set; }

        [JsonPropertyName("suppressed_tail")]
        public int DuoiNgan { get; set; }

        [JsonPropertyName("short_legs")]
        public int ChanNgan { get; set; }

        [JsonPropertyName("wikipedia_url")]
        public string DuongDanWiki { get; set; }

        [JsonPropertyName("hypoallergenic")]
        public int ItGayDiUng { get; set; }

        [JsonPropertyName("reference_image_id")]
        public string MaAnhThamKhao { get; set; }

        [JsonPropertyName("cat_friendly")]
        public int ThanThienVoiMeo { get; set; }

        [JsonPropertyName("bidability")]
        public int DeHuongDan { get; set; }
    }

    public class TrongLuong
    {
        [JsonPropertyName("imperial")]
        public string DonViImperial { get; set; }

        [JsonPropertyName("metric")]
        public string DonViMetric { get; set; }
    }
}
