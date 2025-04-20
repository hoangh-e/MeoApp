namespace Meow.ViewModels
{
    public partial class BaseViewModel : ObservableObject
    {
        [ObservableProperty]
        private string tieuDe;

        [ObservableProperty]
        private bool dangXuLy;

        [ObservableProperty]
        private TimeSpan tienTrinh;

        [RelayCommand]
        public void ChuyenGiaoDienSangToiHoacSang()
        {
            AppTheme giaoDienHienTai = Application.Current.RequestedTheme;
            AppTheme giaoDienMoi = giaoDienHienTai == AppTheme.Dark ? AppTheme.Light : AppTheme.Dark;
            Application.Current.UserAppTheme = giaoDienMoi;
        }
    }
}
