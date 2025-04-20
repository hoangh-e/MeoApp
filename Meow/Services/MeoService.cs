namespace Meow.Services
{
    public class MeoService : IMeoService
    {
        private readonly HttpClient _httpClient;

        public MeoService()
        {
            _httpClient = new HttpClient();
            _httpClient.BaseAddress = new Uri(APIConstants.APIBaseUrl);
            _httpClient.DefaultRequestHeaders.Add("x-api-key", APIConstants.APIKey);
            _httpClient.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/json"));
        }

        public async Task<List<Meo>> LayMeoNgauNhien()
        {
            var phanHoi = await _httpClient.GetAsync(APIConstants.EndPointMeoNgauNhienTuyChinh);

            if (phanHoi.IsSuccessStatusCode)
            {
                string noiDung = await phanHoi.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Meo>>(noiDung);
            }

            return default;
        }

        public async Task<List<PhanHoiMeoYeuThich>> LayDanhSachYeuThich()
        {
            var phanHoi = await _httpClient.GetAsync(APIConstants.EndPointMeoYeuThich);

            if (phanHoi.IsSuccessStatusCode)
            {
                string noiDung = await phanHoi.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<PhanHoiMeoYeuThich>>(noiDung);
            }

            return default;
        }

        public async Task<string> ThemMeoYeuThich(string maAnhMeo)
        {
            var yeuCau = new YeuCauMeoYeuThich { MaAnhMeo = maAnhMeo };
            var noiDung = JsonSerializer.Serialize(yeuCau);
            var content = new StringContent(noiDung, Encoding.UTF8, "application/json");

            var phanHoi = await _httpClient.PostAsync(APIConstants.EndPointMeoYeuThich, content);
            if (phanHoi.IsSuccessStatusCode)
            {
                return await phanHoi.Content.ReadAsStringAsync();
            }

            return default;
        }

        public async Task<string> XoaMeoYeuThich(int maYeuThich)
        {
            var phanHoi = await _httpClient.DeleteAsync($"{APIConstants.EndPointMeoYeuThich}/{maYeuThich}");

            if (phanHoi.IsSuccessStatusCode)
            {
                return await phanHoi.Content.ReadAsStringAsync();
            }

            return default;
        }

        public async Task<string> XoaMeoYeuThichTheoMaAnh(string maAnh)
        {
            var danhSach = await LayDanhSachYeuThich();
            var meoYeuThich = danhSach.FirstOrDefault(x => x.MaAnhMeo == maAnh);

            if (meoYeuThich != null)
            {
                var phanHoi = await _httpClient.DeleteAsync($"{APIConstants.EndPointMeoYeuThich}/{meoYeuThich.MaYeuThich}");

                if (phanHoi.IsSuccessStatusCode)
                {
                    return await phanHoi.Content.ReadAsStringAsync();
                }
            }

            return default;
        }

        public async Task<List<Meo>> LayMeoTheoGiong(string maGiong)
        {
            var phanHoi = await _httpClient.GetAsync($"{APIConstants.EndPointsMeoNgauNhienTheoGiongTuyChinh}&breed_ids={maGiong}");

            if (phanHoi.IsSuccessStatusCode)
            {
                string noiDung = await phanHoi.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<Meo>>(noiDung);
            }

            return default;
        }

        public async Task<List<GiongMeo>> LayDanhSachGiong()
        {
            var phanHoi = await _httpClient.GetAsync(APIConstants.EndPointGiongLoai);

            if (phanHoi.IsSuccessStatusCode)
            {
                string noiDung = await phanHoi.Content.ReadAsStringAsync();
                return JsonSerializer.Deserialize<List<GiongMeo>>(noiDung);
            }

            return default;
        }
    }
}
