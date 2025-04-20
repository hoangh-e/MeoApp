namespace Meow.Controls
{
    public class BoChiaChuoi : ContentView
    {
        private StackLayout boCucMuc;

        public static readonly BindableProperty ChuoiDauVaoProperty =
            BindableProperty.Create(nameof(ChuoiDauVao), typeof(string), typeof(BoChiaChuoi), null, propertyChanged: OnChuoiThayDoi);

        public string ChuoiDauVao
        {
            get => (string)GetValue(ChuoiDauVaoProperty);
            set => SetValue(ChuoiDauVaoProperty, value);
        }

        public BoChiaChuoi()
        {
            boCucMuc = new StackLayout
            {
                Spacing = 6,
                Orientation = StackOrientation.Horizontal
            };

            Content = new ScrollView
            {
                HorizontalScrollBarVisibility = ScrollBarVisibility.Never,
                Orientation = ScrollOrientation.Horizontal,
                Content = boCucMuc
            };
        }

        private static void OnChuoiThayDoi(BindableObject bindable, object oldValue, object newValue)
        {
            if (bindable is BoChiaChuoi chiaChuoi)
            {
                chiaChuoi.CapNhat();
            }
        }

        private void CapNhat()
        {
            boCucMuc.Children.Clear();

            if (!string.IsNullOrWhiteSpace(ChuoiDauVao))
            {
                string chuoiDaLoc = ChuoiDauVao.Replace(",", "");
                string[] mucs = chuoiDaLoc.Split(' ');

                foreach (string muc in mucs)
                {
                    Label nhan = new()
                    {
                        Text = muc,
                        FontFamily = "Roboto#500",
                        FontSize = 12,
                        CharacterSpacing = 0.4,
                        HorizontalTextAlignment = TextAlignment.Center,
                        VerticalTextAlignment = TextAlignment.Center
                    };
                    nhan.SetAppThemeColor(Label.TextColorProperty, Color.FromArgb("#703edb"), Color.FromArgb("#e68fff"));

                    MyBorder vien = new()
                    {
                        Content = nhan,
                        Padding = new Thickness(8, 5, 8, 5),
                        StrokeShape = new RoundRectangle { CornerRadius = new CornerRadius(8) },
                        StrokeThickness = 0
                    };
                    vien.SetAppThemeColor(Border.BackgroundColorProperty, Color.FromArgb("#e4e2f3"), Color.FromArgb("#30133b"));

                    boCucMuc.Children.Add(vien);
                }
            }
        }
    }
}
