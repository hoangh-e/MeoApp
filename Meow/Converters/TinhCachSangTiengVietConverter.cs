using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using Microsoft.Maui.Controls;

namespace Meow.Converters
{
    public class TinhCachSangTiengVietConverter : IValueConverter
    {
        private static readonly Dictionary<string, string> TuDienTinhCach = new()
{
    { "Affectionate", "Tình_cảm" },
    { "Social", "Hòa_đồng" },
    { "Intelligent", "Thông_minh" },
    { "Playful", "Vui_tươi" },
    { "Active", "Năng_động" },
    { "Loyal", "Trung_thành" },
    { "Gentle", "Nhẹ_nhàng" },
    { "Curious", "Tò_mò" },
    { "Independent", "Độc_lập" },
    { "Calm", "Điềm_tĩnh" },
    { "Energetic", "Năng_nổ" },
    { "Interactive", "Tương_tác" },
    { "Lively", "Sống_động" },
    { "Sensitive", "Nhạy_cảm" },
    { "Easy-going", "Dễ_tính" },
    { "Sensible", "Nhạy_bén" },
    { "Agile", "Nhanh_nhẹn" },
    { "Fun-loving", "Yêu_đời" },
    { "Relaxed", "Thư_thái" },
    { "Friendly", "Thân_thiện" },
    { "Alert", "Cảnh_giác" },
    { "Demanding", "Khó_tính" },
    { "Dependent", "Phụ_thuộc" },
    { "Patient", "Kiên_nhẫn" },
    { "Easy", "Dễ_chịu" },
    { "Going", "Hoạt_bát" } 
};
        public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
        {
            if (value is not string tinhCachGoc || string.IsNullOrWhiteSpace(tinhCachGoc))
                return string.Empty;

            var tuKhoa = tinhCachGoc
                .Split(new[] { ',', ';' }, StringSplitOptions.RemoveEmptyEntries)
                .Select(t => t.Trim());

            var danhSachViet = tuKhoa.Select(t =>
                TuDienTinhCach.TryGetValue(t, out var tiengViet) ? tiengViet : t);

            return string.Join(", ", danhSachViet);
        }

        public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture) =>
            throw new NotImplementedException();
    }
}
