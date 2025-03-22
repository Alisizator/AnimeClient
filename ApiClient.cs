// AnimeClient/ApiClient.cs
using AnimeClient.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.IdentityModel.Tokens.Jwt;

namespace AnimeClient
{
    public class ApiClient
    {
        private readonly HttpClient _httpClient;
        private string _jwtToken;

        public ApiClient()
        {
            _httpClient = new HttpClient
            {
                BaseAddress = new Uri("https://localhost:7256/api/") // Укажите URL вашего API
            };
        }

        public int GetUserIdFromToken()
        {
            if (string.IsNullOrEmpty(_jwtToken))
                throw new InvalidOperationException("Токен не установлен.");

            var tokenHandler = new JwtSecurityTokenHandler();
            var token = tokenHandler.ReadJwtToken(_jwtToken);

            var userIdClaim = token.Claims.FirstOrDefault(c => c.Type == ClaimTypes.NameIdentifier);
            if (userIdClaim == null)
                throw new InvalidOperationException("Токен не содержит идентификатора пользователя.");

            return int.Parse(userIdClaim.Value);
        }

        // Логин и получение токена
        public async Task<string> LoginAsync(string email, string password)
        {
            var loginData = new
            {
                Email = email,
                Password = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(loginData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("auth/login", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(jsonResponse);
                _jwtToken = result.token;
                return _jwtToken;
            }

            return null;
        }

        // Получение аниме с API с поддержкой фильтрации
        public async Task<List<AnimeDto>> GetAllAnimeAsync(
            string title = null,
            string genre = null,
            int? year = null,
            float? minRating = null,
            float? maxRating = null)
        {
            if (string.IsNullOrEmpty(_jwtToken)) return null;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _jwtToken);

            // Формируем URL с параметрами
            var queryParams = new List<string>();
            if (!string.IsNullOrEmpty(title)) queryParams.Add($"title={title}");
            if (!string.IsNullOrEmpty(genre)) queryParams.Add($"genre={genre}");
            if (year.HasValue) queryParams.Add($"year={year}");
            if (minRating.HasValue) queryParams.Add($"minRating={minRating}");
            if (maxRating.HasValue) queryParams.Add($"maxRating={maxRating}");

            var queryString = queryParams.Any() ? "?" + string.Join("&", queryParams) : string.Empty;
            var response = await _httpClient.GetAsync($"anime{queryString}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();

                // Парсим JSON, убирая $values
                JObject parsedJson = JObject.Parse(jsonResponse);
                JArray animeArray = (JArray)parsedJson["$values"];

                return animeArray.ToObject<List<AnimeDto>>();
            }

            return null;
        }

        // AnimeClient/ApiClient.cs
        public async Task<string> RegisterAsync(string username, string email, string password)
        {
            var registerData = new
            {
                Username = username,
                Email = email,
                Password = password
            };

            var content = new StringContent(JsonConvert.SerializeObject(registerData), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("auth/register", content);

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                dynamic result = JsonConvert.DeserializeObject(jsonResponse);
                return result.message;
            }
            else
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                return $"Ошибка: {errorResponse}";
            }
        }

        public async Task<List<ReviewDto>> GetReviewsByAnimeIdAsync(int animeId)
        {
            if (string.IsNullOrEmpty(_jwtToken)) return null;

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _jwtToken);
            var response = await _httpClient.GetAsync($"review/{animeId}");

            if (response.IsSuccessStatusCode)
            {
                var jsonResponse = await response.Content.ReadAsStringAsync();
                return JsonConvert.DeserializeObject<List<ReviewDto>>(jsonResponse);
            }

            return null;
        }

        public async Task AddReviewAsync(ReviewDto review)
        {
            if (string.IsNullOrEmpty(_jwtToken))
                throw new InvalidOperationException("Токен не установлен.");

            _httpClient.DefaultRequestHeaders.Authorization = new AuthenticationHeaderValue("Bearer", _jwtToken);

            // Создаем упрощенный объект для отправки
            var reviewRequest = new
            {
                AnimeId = review.AnimeId,
                UserId = review.UserId,
                Text = review.Text
            };

            var content = new StringContent(JsonConvert.SerializeObject(reviewRequest), Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync("review", content);

            if (!response.IsSuccessStatusCode)
            {
                var errorResponse = await response.Content.ReadAsStringAsync();
                throw new Exception($"Ошибка: {response.StatusCode}. {errorResponse}");
            }
        }
    }


}