using KeyMaster_Data.Models;
using KeyMaster_MVC.IService;
using Newtonsoft.Json;
using System.Drawing;

namespace KeyMaster_MVC.Service
{
    public class HangService : IHangService
    {
        private readonly HttpClient _httpClient;
        public HangService(HttpClient httpClient)
        {
            _httpClient = httpClient;   
        }
        public async Task Create(Hang hang)
        {
            await _httpClient.PostAsJsonAsync("https://localhost:7047/api/Hang", hang);
        }

        public async Task Delete(Guid id)
        {
            await _httpClient.DeleteAsync($"https://localhost:7047/api/Hang/{id}");
        }

        public async Task<IEnumerable<Hang>?> GetAllHangs()
        {
            var reponse = await _httpClient.GetStringAsync("https://localhost:7047/api/Hang");
            var hangs = JsonConvert.DeserializeObject<IEnumerable<Hang>>(reponse);
            return hangs;
        }

        public async Task<Hang?> GetHangById(Guid id)
        {
            var reponse = await _httpClient.GetStringAsync($"https://localhost:7047/api/Hang/{id}");
            var hangs = JsonConvert.DeserializeObject<Hang>(reponse);
            return hangs;
        }

        public async Task Update(Hang hang)
        {
            await _httpClient.PutAsJsonAsync($"https://localhost:7047/api/Hang/{hang.IdHang}", hang);
        }
    }
}
