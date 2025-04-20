namespace Meow;

public static class MauiProgram
{
    public static MauiApp CreateMauiApp()
    {
        var builder = MauiApp.CreateBuilder();
        builder
            .UseMauiApp<App>()
            .UseSkiaSharp()
            .UseFFImageLoading()
            .UseMauiCommunityToolkit()
            .UseMaterialComponents()
            .ConfigureFonts(fonts =>
            {
                fonts.AddFont("Roboto-Regular.ttf", "Roboto#400");
                fonts.AddFont("Roboto-Medium.ttf", "Roboto#500");
                fonts.AddFont("Roboto-Bold.ttf", "Roboto#700");
            });

        builder.Services.AddSingleton<IMeoService, MeoService>();

        builder.Services.AddSingleton<BinhChonMeoViewModel>();
        builder.Services.AddTransient<TrangBinhChonMeo>();

        builder.Services.AddSingleton<GiongMeoViewModel>();
        builder.Services.AddTransient<TrangGiongMeo>();

        builder.Services.AddSingleton<MeoYeuThichViewModel>();
        builder.Services.AddTransient<TrangMeoYeuThich>();

#if DEBUG
        builder.Logging.AddDebug();
#endif

        return builder.Build();
    }
}
