// RatingView.cs (REFRACTOR HOÀN TẤT TOÀN BỘ - Bao gồm IsReadOnly ⭐)
namespace Meow.Controls
{
    public class ThanhDanhGia : GraphicsView
    {
        private BangVeDanhGia _boVe;

        #region Thuộc tính Bindable ⭐

        public static readonly BindableProperty SoLuongPhanTuProperty = BindableProperty.Create(
            nameof(SoLuongPhanTu), typeof(int), typeof(ThanhDanhGia), 5,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatSoLuong();
            });

        public int SoLuongPhanTu
        {
            get => (int)GetValue(SoLuongPhanTuProperty);
            set => SetValue(SoLuongPhanTuProperty, value);
        }

        private void CapNhatSoLuong()
        {
            _boVe.SoLuong = SoLuongPhanTu;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty KichThuocPhanTuProperty = BindableProperty.Create(
            nameof(KichThuocPhanTu), typeof(float), typeof(ThanhDanhGia), 24f,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatKichThuocPhanTu();
            });

        public float KichThuocPhanTu
        {
            get => (float)GetValue(KichThuocPhanTuProperty);
            set => SetValue(KichThuocPhanTuProperty, value);
        }

        private void CapNhatKichThuocPhanTu()
        {
            _boVe.KichThuocPhanTu = KichThuocPhanTu;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty KhoangCachPhanTuProperty = BindableProperty.Create(
            nameof(KhoangCachPhanTu), typeof(float), typeof(ThanhDanhGia), 6f,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatKhoangCachPhanTu();
            });

        public float KhoangCachPhanTu
        {
            get => (float)GetValue(KhoangCachPhanTuProperty);
            set => SetValue(KhoangCachPhanTuProperty, value);
        }

        private void CapNhatKhoangCachPhanTu()
        {
            _boVe.KhoangCachPhanTu = KhoangCachPhanTu;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty GiaTriDanhGiaProperty = BindableProperty.Create(
            nameof(GiaTriDanhGia), typeof(double), typeof(ThanhDanhGia), 2.5d,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatGiaTri();
            });

        public double GiaTriDanhGia
        {
            get => (double)GetValue(GiaTriDanhGiaProperty);
            set => SetValue(GiaTriDanhGiaProperty, value);
        }

        private void CapNhatGiaTri()
        {
            _boVe.GiaTri = GiaTriDanhGia;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty MauDaDanhGiaProperty = BindableProperty.Create(
            nameof(MauDaDanhGia), typeof(Color), typeof(ThanhDanhGia), Color.FromArgb("#FFFF00"),
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatMauDaDanhGia();
            });

        public Color MauDaDanhGia
        {
            get => (Color)GetValue(MauDaDanhGiaProperty);
            set => SetValue(MauDaDanhGiaProperty, value);
        }

        private void CapNhatMauDaDanhGia()
        {
            _boVe.MauDaDanhGia = MauDaDanhGia;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty MauChuaDanhGiaProperty = BindableProperty.Create(
            nameof(MauChuaDanhGia), typeof(Color), typeof(ThanhDanhGia), Color.FromArgb("#D3D3D3"),
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatMauChuaDanhGia();
            });

        public Color MauChuaDanhGia
        {
            get => (Color)GetValue(MauChuaDanhGiaProperty);
            set => SetValue(MauChuaDanhGiaProperty, value);
        }

        private void CapNhatMauChuaDanhGia()
        {
            _boVe.MauChuaDanhGia = MauChuaDanhGia;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty MauVienProperty = BindableProperty.Create(
            nameof(MauVien), typeof(Color), typeof(ThanhDanhGia), Color.FromArgb("#FFFFE0"),
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatMauVien();
            });

        public Color MauVien
        {
            get => (Color)GetValue(MauVienProperty);
            set => SetValue(MauVienProperty, value);
        }

        private void CapNhatMauVien()
        {
            _boVe.MauVien = MauVien;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty DoDayVienProperty = BindableProperty.Create(
            nameof(DoDayVien), typeof(float), typeof(ThanhDanhGia), 1f,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatDoDayVien();
            });

        public float DoDayVien
        {
            get => (float)GetValue(DoDayVienProperty);
            set => SetValue(DoDayVienProperty, value);
        }

        private void CapNhatDoDayVien()
        {
            _boVe.DoDayVien = DoDayVien;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty DuongDanHinhDangProperty = BindableProperty.Create(
            nameof(DuongDanHinhDang), typeof(string), typeof(ThanhDanhGia), default(string),
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatHinhDang();
            });

        public string DuongDanHinhDang
        {
            get => (string)GetValue(DuongDanHinhDangProperty);
            set => SetValue(DuongDanHinhDangProperty, value);
        }

        private void CapNhatHinhDang()
        {
            _boVe.DuongDanHinhDang = DuongDanHinhDang;
            CapNhatKichThuoc();
            Invalidate();
        }

        public static readonly BindableProperty ChiDocProperty = BindableProperty.Create(
            nameof(ChiDoc), typeof(bool), typeof(ThanhDanhGia), true,
            propertyChanged: (bindableObject, oldValue, newValue) =>
            {
                if (newValue is not null && bindableObject is ThanhDanhGia danhGia && newValue != oldValue)
                    danhGia.CapNhatChiDoc();
            });

        public bool ChiDoc
        {
            get => (bool)GetValue(ChiDocProperty);
            set => SetValue(ChiDocProperty, value);
        }

        private void CapNhatChiDoc()
        {
            // TODO: xử lý tương tác nếu cần
        }

        #endregion

        private void CapNhatKichThuoc()
        {
            HeightRequest = KichThuocPhanTu + DoDayVien * 2;
            WidthRequest = KichThuocPhanTu * SoLuongPhanTu + KhoangCachPhanTu * (SoLuongPhanTu - 1) + DoDayVien * 2;
        }

        protected override void OnParentSet()
        {
            base.OnParentSet();
            if (Parent is null) return;

            CapNhatMauDaDanhGia();
            CapNhatMauChuaDanhGia();
            CapNhatMauVien();
            CapNhatDoDayVien();
            CapNhatHinhDang();
            CapNhatKhoangCachPhanTu();
            CapNhatKichThuocPhanTu();
            CapNhatSoLuong();
            CapNhatGiaTri();
        }

        public ThanhDanhGia()
        {
            _boVe = new BangVeDanhGia();
            Drawable = _boVe;
        }
    }
}
