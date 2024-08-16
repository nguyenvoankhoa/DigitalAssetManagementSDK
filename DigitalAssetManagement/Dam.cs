using DigitalAssetManagement.Action;

namespace DigitalAssetManagement
{
    public class Dam
    {
        private readonly HttpClient _httpClient;
        private readonly FileService _fileService;
        private readonly string baseUrl = "http://localhost:8080/";

        private Account _account;

        public Dam(Account account) : this()
        {
            _account = account;
        }

        public Dam()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri(baseUrl)
            };
            _fileService = new FileService(_httpClient);
        }

        public async Task<string> UploadAsset(ImageUploadParam param)
        {
            return await _fileService.UploadAsync(param, _account);
        }

        public async Task<object> GetAsset(string path, Dictionary<string, string>? options = null)
        {
            return await _fileService.GetAssetAsync(path, options);
        }

        public async Task<object> GetAsset(string tenantId, string publicId, Dictionary<string, string>? options = null)
        {
            return await _fileService.GetAssetAsync($"{tenantId}/{publicId}", options);
        }
    }


}
