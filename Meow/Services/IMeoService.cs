namespace Meow.Services
{
    public interface IMeoService
    {
        Task<List<Meo>> LayMeoNgauNhien();
        Task<List<GiongMeo>> LayDanhSachGiong();
        Task<List<Meo>> LayMeoTheoGiong(string maGiong);

        Task<List<PhanHoiMeoYeuThich>> LayDanhSachYeuThich();
        Task<string> ThemMeoYeuThich(string maAnhMeo);
        Task<string> XoaMeoYeuThich(int maYeuThich);
        Task<string> XoaMeoYeuThichTheoMaAnh(string maAnh);
    }
}