namespace Meow.Views
{
    public partial class TrangGiongMeo : ContentPage
    {
        private readonly GiongMeoViewModel moHinh = new(new MeoService());

        public TrangGiongMeo()
        {
            InitializeComponent();
            BindingContext = moHinh;
        }
    }
}