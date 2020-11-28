using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SiteBibliotecaMVC.Models.ViewModels;

namespace SiteBibliotecaMVC.ViewComponents
{
    public class InfoProdutoViewComponent : ViewComponent
    {
        private HttpClient _httpClient;

        public InfoProdutoViewComponent(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IViewComponentResult> InvokeAsync()
        {
            var items = await GetItemsAsync(6);
            return View(items);
        }
        
        private async Task<LivroViewModel> GetItemsAsync(int livroID)
        {
            var url = $"/Livros/{livroID}";
            return await _httpClient.GetFromJsonAsync<LivroViewModel>(url);
        }
    }
}