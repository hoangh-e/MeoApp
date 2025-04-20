namespace Meow.ViewModels
{
    public partial class GiongMeoViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<GiongMeo> danhSachGiong;

        [ObservableProperty]
        private GiongMeo giongMeoDuocChon;

        [ObservableProperty]
        private List<Meo> meoTheoGiong;

        [ObservableProperty]
        private bool dangTaiGiong;

        private readonly IMeoService _MeoService;

        partial void OnGiongMeoDuocChonChanged(GiongMeo giaTri)
        {
            LayMeoTheoGiongAsync(giaTri.MaGiong);
        }

        public GiongMeoViewModel(IMeoService MeoService)
        {
            TieuDe = "Giống mèo";
            _MeoService = MeoService;
            KhoiTaoAsync();
        }

        public async Task KhoiTaoAsync()
        {
            DangXuLy = true;

            DanhSachGiong = await _MeoService.LayDanhSachGiong();
            GiongMeoDuocChon = DanhSachGiong.FirstOrDefault();
            MeoTheoGiong = await _MeoService.LayMeoTheoGiong(GiongMeoDuocChon.MaGiong);

            DangXuLy = false;
        }

        public async Task LayMeoTheoGiongAsync(string maGiong)
        {
            DangTaiGiong = true;

            MeoTheoGiong = await _MeoService.LayMeoTheoGiong(maGiong);

            DangTaiGiong = false;
        }
    }
}
