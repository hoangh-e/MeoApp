namespace Meow.Views
{
    public partial class TrangBinhChonMeo : ContentPage
    {
        private readonly BinhChonMeoViewModel moHinh = new(new MeoService());

        public TrangBinhChonMeo()
        {
            InitializeComponent();
            BindingContext = moHinh;
        }

        // protected async override void OnAppearing()
        // {
        //     base.OnAppearing();
        //     await moHinh.KhoiTaoDuLieuAsync();
        // }
    }
}
