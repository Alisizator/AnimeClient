using AnimeClient;
using AnimeClient.Models;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using AnimeClient.Controls;

namespace AnimeClient.Forms
{
    public partial class AnimeDetailsForm : Form
    {
        private readonly AnimeDto _anime;
        private readonly ApiClient _apiClient; // Добавьте это поле
        public AnimeDetailsForm(AnimeDto anime, ApiClient apiClient)
        {
            Console.WriteLine("Форма деталей аниме создана для: " + anime.Title); // Отладочный вывод
            InitializeComponent();
            _anime = anime;
            _apiClient = apiClient;
            LoadAnimeDetails();
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

        private void LoadAnimeDetails()
        {
            lblTitle.Text = _anime.Title;
            lblDescription.Text = _anime.Description;
            lblGenre.Text = $"Жанр: {_anime.Genre ?? "Неизвестно"}";
            lblStudio.Text = $"Студия: {_anime.Studio ?? "Неизвестно"}";
            lblRating.Text = $"Рейтинг: {_anime.Rating}";
            picImage.Image = LoadImageFromUrl(_anime.ImageUrl);
            LoadReviews();
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

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close(); // Закрываем форму
        }

        private async void btnAddReview_Click(object sender, EventArgs e)
        {
            var reviewText = txtReview.Text;
            if (string.IsNullOrEmpty(reviewText))
            {
                MessageBox.Show("Введите текст комментария.");
                return;
            }

            try
            {
                // Получаем UserId из токена
                var userId = _apiClient.GetUserIdFromToken();

                var review = new ReviewDto
                {
                    AnimeId = _anime.Id,
                    UserId = userId,
                    Text = reviewText
                };
                Console.WriteLine($"Отправка комментария: AnimeId={review.AnimeId}, UserId={review.UserId}, Text={review.Text}");
                await _apiClient.AddReviewAsync(review);
                LoadReviews(); // Обновляем список комментариев
                txtReview.Clear(); // Очищаем поле ввода
            }

            catch (Exception ex)
            {
                MessageBox.Show("Ошибка добавления комментария: " + ex.Message);
            }
        }
    }


}