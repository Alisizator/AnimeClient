using AnimeClient.Models;
using System.Windows.Forms;

namespace AnimeClient.Controls
{
    public partial class ReviewControl : UserControl
    {
        public ReviewControl(ReviewDto review)
        {
            InitializeComponent();
            lblUsername.Text = review.Username;
            lblText.Text = review.Text;
            lblDate.Text = review.CreatedAt.ToString("dd.MM.yyyy HH:mm");
        }

        private Label lblUsername;
        private Label lblText;
        private Label lblDate;

        private void InitializeComponent()
        {
            this.lblUsername = new System.Windows.Forms.Label();
            this.lblText = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUsername
            // 
            this.lblUsername.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.lblUsername.Location = new System.Drawing.Point(10, 10);
            this.lblUsername.Name = "lblUsername";
            this.lblUsername.Size = new System.Drawing.Size(200, 20);
            this.lblUsername.TabIndex = 0;
            this.lblUsername.Text = "Username";
            // 
            // lblText
            // 
            this.lblText.Location = new System.Drawing.Point(10, 40);
            this.lblText.Name = "lblText";
            this.lblText.Size = new System.Drawing.Size(300, 59);
            this.lblText.TabIndex = 1;
            this.lblText.Text = "Review Text";
            // 
            // lblDate
            // 
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F);
            this.lblDate.Location = new System.Drawing.Point(239, 10);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(108, 40);
            this.lblDate.TabIndex = 2;
            this.lblDate.Text = "Date";
            // 
            // ReviewControl
            // 
            this.Controls.Add(this.lblUsername);
            this.Controls.Add(this.lblText);
            this.Controls.Add(this.lblDate);
            this.Name = "ReviewControl";
            this.Size = new System.Drawing.Size(350, 142);
            this.ResumeLayout(false);

        }
    }
}