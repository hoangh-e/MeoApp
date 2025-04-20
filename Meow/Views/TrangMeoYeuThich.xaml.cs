namespace Meow.Views
{
    public partial class TrangMeoYeuThich : ContentPage
    {
        private readonly MeoYeuThichViewModel moHinh = new(new MeoService());

        public TrangMeoYeuThich()
        {
            InitializeComponent();
            BindingContext = moHinh;
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await moHinh.KhoiTaoDuLieuAsync();
        }

        private void KichThuocTrang_ThayDoi(object sender, EventArgs e)
        {
            moHinh.SoCot = (int)(Width / 174);
        }
    }
}