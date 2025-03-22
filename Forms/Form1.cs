// AnimeClient/Form1.cs
using AnimeClient.Controls;
using AnimeClient.Models;
using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Drawing;
using AnimeClient.Forms;

namespace AnimeClient
{
    public partial class Form1 : Form
    {
        private readonly ApiClient _apiClient;
        private List<AnimeDto> _animeList = new List<AnimeDto>();
        private AnimeDto _anime; // Добавьте это поле
        public Form1()
        {
            InitializeComponent();
            _apiClient = new ApiClient();
            this.flowLayoutPanelReviews = new System.Windows.Forms.FlowLayoutPanel();
        }

        private async void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string password = txtPassword.Text;

            var token = await _apiClient.LoginAsync(email, password);

            lblMessage.Visible = true;

            if (string.IsNullOrEmpty(token))
            {
                lblMessage.Text = "Неверные данные для входа.";
            }
            else
            {
                lblMessage.Text = "Успешный вход!";
                btnGetAnime.Enabled = true;  // Включаем кнопку для получения аниме
            }
        }

        // AnimeClient/Form1.cs
        private async void btnGetAnime_Click(object sender, EventArgs e)
        {
            string title = txtSearchTitle.Text;
            string genre = txtSearchGenre.Text;
            int? year = int.TryParse(txtSearchYear.Text, out int parsedYear) ? parsedYear : (int?)null;
            float? minRating = float.TryParse(txtMinRating.Text, out float parsedMinRating) ? parsedMinRating : (float?)null;
            float? maxRating = float.TryParse(txtMaxRating.Text, out float parsedMaxRating) ? parsedMaxRating : (float?)null;

            _animeList = await _apiClient.GetAllAnimeAsync(title, genre, year, minRating, maxRating);

            if (_animeList == null || _animeList.Count == 0)
            {
                lblMessage.Text = "Нет данных или ошибка загрузки.";
                return;
            }

            flowLayoutPanel.Controls.Clear();

            foreach (var anime in _animeList)
            {
                var card = new AnimeCard
                {
                    Title = anime.Title,
                    Description = anime.Description,
                    Image = LoadImageFromUrl(anime.ImageUrl)
                };

                // Подписываемся на событие CardClicked
                card.CardClicked += (s, ev) => ShowAnimeDetails(anime);
                flowLayoutPanel.Controls.Add(card);
            }

            lblMessage.Text = "Аниме загружены!";
        }

        private void ShowAnimeDetails(AnimeDto anime)
        {
            Console.WriteLine("Открываем детали аниме: " + anime.Title);
            var detailsForm = new AnimeDetailsForm(anime, _apiClient); // Передайте _apiClient
            detailsForm.ShowDialog();
        }

        private Image LoadImageFromUrl(string url)
        {
            try
            {
                using (var webClient = new System.Net.WebClient())
                {
                    var imageData = webClient.DownloadData(url);
                    using (var stream = new System.IO.MemoryStream(imageData))
                    {
                        return Image.FromStream(stream);
                    }
                }
            }
            catch
            {
                return Properties.Resources.DefaultImage; // Заглушка, если изображение не загружено
            }
        }

        private async void LoadReviews()
        {
            try
            {
                // Получаем список комментариев для текущего аниме
                var reviews = await _apiClient.GetReviewsByAnimeIdAsync(_anime.Id);

                // Очищаем текущие комментарии
                flowLayoutPanelReviews.Controls.Clear();

                // Добавляем каждый комментарий в flowLayoutPanelReviews
                foreach (var review in reviews)
                {
                    var reviewControl = new ReviewControl(review);
                    flowLayoutPanelReviews.Controls.Add(reviewControl);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Ошибка при загрузке комментариев: " + ex.Message);
            }
        }

        //private void lstAnime_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (lstAnime.SelectedIndex != -1)
        //    {
        //        lblDescription.Visible = true;

        //        var selectedAnime = _animeList[lstAnime.SelectedIndex];

        //        lblDescription.Text = $"{selectedAnime.Title} ({selectedAnime.ReleaseYear})\n\n" +
        //                              $"{selectedAnime.Description}\n\n" +
        //                              $"Жанр: {selectedAnime.Genre ?? "Неизвестно"}\n" +
        //                              $"Студия: {selectedAnime.Studio ?? "Неизвестно"}\n" +
        //                              $"Рейтинг: {selectedAnime.Rating}";
        //    }
        //}

        private void btnOpenRegisterForm_Click(object sender, EventArgs e)
        {
            var registerForm = new RegisterForm(_apiClient);
            registerForm.ShowDialog();
        }

     

    }
}