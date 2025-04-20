namespace Meow.ViewModels
{
    public partial class MeoYeuThichViewModel : BaseViewModel
    {
        [ObservableProperty]
        private List<PhanHoiMeoYeuThich> danhSachYeuThich = new();

        [ObservableProperty]
        private PhanHoiMeoYeuThich meoDangChon = new();

        [ObservableProperty]
        private int soCot;

        private readonly IMeoService _MeoService;

        public MeoYeuThichViewModel(IMeoService MeoService)
        {
            TieuDe = "Yêu thích";
            _MeoService = MeoService;
            KhoiTaoDuLieuAsync();
        }

        public async Task KhoiTaoDuLieuAsync()
        {
            await XuLyDuLieuAsync(async () =>
            {
                DanhSachYeuThich = await _MeoService.LayDanhSachYeuThich();
            });
        }

        [RelayCommand]
        public async Task XoaMeoYeuThichAsync()
        {
            await XuLyDuLieuAsync(async () =>
            {
                await _MeoService.XoaMeoYeuThich(MeoDangChon.MaYeuThich);
                DanhSachYeuThich = await _MeoService.LayDanhSachYeuThich();
            });
        }

        private async Task XuLyDuLieuAsync(Func<Task> tacVu)
        {
            DangXuLy = true;
            await tacVu.Invoke();
            DangXuLy = false;
        }
    }
}
