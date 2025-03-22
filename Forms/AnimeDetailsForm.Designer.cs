using System.Windows.Forms;

namespace AnimeClient.Forms
{
    partial class AnimeDetailsForm
    {
        private System.ComponentModel.IContainer components = null;
        private Label lblTitle;
        private Label lblDescription;
        private Label lblGenre;
        private Label lblStudio;
        private Label lblRating;
        private PictureBox picImage;
        private FlowLayoutPanel flowLayoutPanelReviews;
        private TextBox txtReview;
        private Button btnAddReview;
        private Button btnClose;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblGenre = new System.Windows.Forms.Label();
            this.lblStudio = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.picImage = new System.Windows.Forms.PictureBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.flowLayoutPanelReviews = new System.Windows.Forms.FlowLayoutPanel();
            this.txtReview = new System.Windows.Forms.TextBox();
            this.btnAddReview = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(12, 140);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(500, 40);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Название";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Location = new System.Drawing.Point(12, 190);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(500, 100);
            this.lblDescription.TabIndex = 1;
            this.lblDescription.Text = "Описание";
            // 
            // lblGenre
            // 
            this.lblGenre.Location = new System.Drawing.Point(12, 300);
            this.lblGenre.Name = "lblGenre";
            this.lblGenre.Size = new System.Drawing.Size(500, 20);
            this.lblGenre.TabIndex = 2;
            this.lblGenre.Text = "Жанр: Неизвестно";
            // 
            // lblStudio
            // 
            this.lblStudio.Location = new System.Drawing.Point(12, 330);
            this.lblStudio.Name = "lblStudio";
            this.lblStudio.Size = new System.Drawing.Size(500, 20);
            this.lblStudio.TabIndex = 3;
            this.lblStudio.Text = "Студия: Неизвестно";
            // 
            // lblRating
            // 
            this.lblRating.Location = new System.Drawing.Point(12, 360);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(500, 20);
            this.lblRating.TabIndex = 4;
            this.lblRating.Text = "Рейтинг: Неизвестно";
            // 
            // picImage
            // 
            this.picImage.Location = new System.Drawing.Point(12, 12);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(500, 125);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 5;
            this.picImage.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(412, 440);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(100, 30);
            this.btnClose.TabIndex = 6;
            this.btnClose.Text = "Закрыть";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // flowLayoutPanelReviews
            // 
            this.flowLayoutPanelReviews.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.flowLayoutPanelReviews.AutoScroll = true;
            this.flowLayoutPanelReviews.Location = new System.Drawing.Point(12, 480);
            this.flowLayoutPanelReviews.Name = "flowLayoutPanelReviews";
            this.flowLayoutPanelReviews.Size = new System.Drawing.Size(500, 150);
            this.flowLayoutPanelReviews.TabIndex = 7;
            // 
            // txtReview
            // 
            this.txtReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtReview.Location = new System.Drawing.Point(12, 640);
            this.txtReview.Name = "txtReview";
            this.txtReview.Size = new System.Drawing.Size(350, 26);
            this.txtReview.TabIndex = 8;
            // 
            // btnAddReview
            // 
            this.btnAddReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddReview.Location = new System.Drawing.Point(372, 640);
            this.btnAddReview.Name = "btnAddReview";
            this.btnAddReview.Size = new System.Drawing.Size(140, 30);
            this.btnAddReview.TabIndex = 9;
            this.btnAddReview.Text = "Добавить";
            this.btnAddReview.Click += new System.EventHandler(this.btnAddReview_Click);
            // 
            // AnimeDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(524, 682);
            this.Controls.Add(this.btnAddReview);
            this.Controls.Add(this.txtReview);
            this.Controls.Add(this.flowLayoutPanelReviews);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.picImage);
            this.Controls.Add(this.lblRating);
            this.Controls.Add(this.lblStudio);
            this.Controls.Add(this.lblGenre);
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Name = "AnimeDetailsForm";
            this.Text = "Детали аниме";
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
    }
}