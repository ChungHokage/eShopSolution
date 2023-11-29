using System;
using System.Net.Http;
using Newtonsoft.Json;
using System.Threading.Tasks;
using eShopSolution.ViewModel.System.Users;
using System.Text;
using eShopSolution.Application.DTO;
using Microsoft.Extensions.Configuration;
using System.Net.Http.Headers;
using System.Runtime.InteropServices.WindowsRuntime;

namespace eShopSolution.AdminApp.Services
{
    public class UserApiClient : IUserApiClient
    {
        private readonly IHttpClientFactory _httpClientFactory;
        private readonly IConfiguration _configuration;

        public UserApiClient(IHttpClientFactory httpClientFactory, IConfiguration configuration)
        {
            _httpClientFactory = httpClientFactory;
            _configuration = configuration;
        }

        public async Task<string> Authenticate(LoginRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.PostAsync("/api/users/authenticate", httpContent);//error
            var token = await response.Content.ReadAsStringAsync();
            return token;
        }

        public async Task<PageResult<UserViewModel>> GetUsersPaging(GetUserPagingRequest request)
        {
            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");
            var client = _httpClientFactory.CreateClient();
            client.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", request.BearerToken);
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);
            var response = await client.GetAsync($"/api/users/paging?pageIndex={request.PageIndex}&pageSize={request.PageSize}" +
                $"&Keyword={request.Keyword}");
            var body = await response.Content.ReadAsStringAsync();
            var users = JsonConvert.DeserializeObject<PageResult<UserViewModel>>(body);
            return users;
        }

        public async Task<bool> RegisterUser(RegisterRequest request)
        {
            var client = _httpClientFactory.CreateClient();
            client.BaseAddress = new Uri(_configuration["BaseAddress"]);

            var json = JsonConvert.SerializeObject(request);
            var httpContent = new StringContent(json, Encoding.UTF8, "application/json");

            var response = await client.PostAsync($"/api/users/register", httpContent);
            return response.IsSuccessStatusCode;
        }
    }
}