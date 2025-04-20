// BangVeDanhGia.cs
namespace Meow.Controls
{
    internal class BangVeDanhGia : IDrawable
    {
        public int SoLuong { get; set; }
        public float KichThuocPhanTu { get; set; }
        public float KhoangCachPhanTu { get; set; }
        public double GiaTri { get; set; }

        public Color MauDaDanhGia { get; set; }
        public Color MauChuaDanhGia { get; set; }

        public Color MauVien { get; set; }
        public float DoDayVien { get; set; }

        public string DuongDanHinhDang { get; set; }

        public void Draw(ICanvas ve, RectF khung)
        {
            ve.Antialias = true;

            for (int i = 0; i < SoLuong; i++)
            {
                VePhanTuDanhGia(ve, khung, i);
            }
        }

        private void VePhanTuDanhGia(ICanvas ve, RectF khung, int viTri)
        {
            ve.SaveState();

            ve.Translate(viTri * KichThuocPhanTu + viTri * KhoangCachPhanTu + DoDayVien, DoDayVien);

            var taoDuong = new PathBuilder();
            var hinhDang = taoDuong.BuildPath(DuongDanHinhDang);
            var hinhThuNho = hinhDang.AsScaledPath(
                (KichThuocPhanTu - DoDayVien) /
                (hinhDang.Bounds.Width < hinhDang.Bounds.Height ? hinhDang.Bounds.Width : hinhDang.Bounds.Height)
            );

            VeHinhDang(ve, hinhThuNho, MauVien, MauChuaDanhGia, DoDayVien, null);

            if (viTri < GiaTri)
            {
                var vungCat = new PathF();
                vungCat.AppendRectangle(
                    0, 0,
                    Convert.ToSingle(hinhThuNho.Bounds.Width * (GiaTri - viTri)),
                    hinhThuNho.Bounds.Height
                );

                VeHinhDang(ve, hinhThuNho, MauVien, MauDaDanhGia, DoDayVien, vungCat);
            }

            ve.RestoreState();
        }

        private void VeHinhDang(ICanvas ve, PathF hinh, Color vien, Color mauNen, float doDay, PathF vungCat)
        {
            ve.StrokeColor = vien;
            ve.StrokeSize = doDay;
            ve.FillColor = mauNen;

            if (vungCat is not null)
                ve.ClipPath(vungCat);

            ve.DrawPath(hinh);
            ve.FillPath(hinh);
        }
    }
}
