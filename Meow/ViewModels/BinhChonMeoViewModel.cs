namespace Meow.ViewModels
{
    public partial class BinhChonMeoViewModel : BaseViewModel
    {
        [ObservableProperty]
        private TrangThaiHienThi giaoDienHienTai = TrangThaiHienThi.KhongCo;

        [ObservableProperty]
        private string anhTraiTim = "icon_heart_outline.png";

        [ObservableProperty]
        private bool hienThiHieuUng;

        [ObservableProperty]
        private bool anNoiDung;

        private readonly IMeoService _MeoService;

        public BinhChonMeoViewModel(IMeoService MeoService)
        {
            TieuDe = "Bình chọn";
            _MeoService = MeoService;
            KhoiTaoDuLieuAsync();
        }

        [ObservableProperty]
        List<Meo> danhSachMeo;

        public async Task KhoiTaoDuLieuAsync()
        {
            AnhTraiTim = "icon_heart_outline.png";
            GiaoDienHienTai = TrangThaiHienThi.KhongCo;

            AnNoiDung = true;
            DanhSachMeo = await _MeoService.LayMeoNgauNhien();
            await Task.Delay(1500);
            AnNoiDung = false;
        }

        [RelayCommand]
        public async Task LayMeoMoiAsync()
        {
            HienThiHieuUng = false;
            await KhoiTaoDuLieuAsync();
        }

        [RelayCommand]
        public async Task XuLyYeuThichMeoAsync()
        {
            DangXuLy = true;

            bool dangThemYeuThich = (GiaoDienHienTai == TrangThaiHienThi.KhongCo);

            await ThayDoiTrangThaiYeuThichAsync(dangThemYeuThich);

            DangXuLy = false;
        }

        private async Task ThayDoiTrangThaiYeuThichAsync(bool laThemMoi)
        {
            if (laThemMoi)
            {
                await _MeoService.ThemMeoYeuThich(DanhSachMeo.FirstOrDefault().MaAnh);
                AnhTraiTim = "icon_heart_solid.png";
                GiaoDienHienTai = TrangThaiHienThi.ThanhCong;

                TienTrinh = TimeSpan.Zero;
                HienThiHieuUng = true;
            }
            else
            {
                HienThiHieuUng = false;
                await _MeoService.XoaMeoYeuThichTheoMaAnh(DanhSachMeo.FirstOrDefault().MaAnh);
                AnhTraiTim = "icon_heart_outline.png";
                GiaoDienHienTai = TrangThaiHienThi.KhongCo;
            }
        }
    }

    public enum TrangThaiHienThi
    {
        KhongCo,
        ThanhCong
    }
}
