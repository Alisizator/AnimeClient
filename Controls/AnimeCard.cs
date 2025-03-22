using System;
using System.Drawing;
using System.Windows.Forms;

namespace AnimeClient.Controls
{
    public partial class AnimeCard : UserControl
    {
        public event EventHandler<EventArgs> CardClicked;

        public AnimeCard()
        {
            InitializeComponent();

            // Подписываемся на событие Click для всех дочерних элементов
            SubscribeClickEvent(this);
        }

        private void SubscribeClickEvent(Control control)
        {
            control.Click += AnimeCard_Click; // Подписываемся на событие Click

            // Рекурсивно подписываемся на событие Click для всех дочерних элементов
            foreach (Control childControl in control.Controls)
            {
                SubscribeClickEvent(childControl);
            }
        }

        public string Title
        {
            get => lblTitle.Text;
            set => lblTitle.Text = value;
        }

        public string Description
        {
            get => lblDescription.Text;
            set => lblDescription.Text = value;
        }

        public Image Image
        {
            get => picImage.Image;
            set => picImage.Image = value;
        }

        private void AnimeCard_Click(object sender, EventArgs e)
        {
            Console.WriteLine("Карточка нажата!"); // Отладочный вывод
            CardClicked?.Invoke(this, e);
        }
    }

    partial class AnimeCard
    {
        private System.ComponentModel.IContainer components = null;
        private PictureBox picImage;
        private Label lblTitle;
        private Label lblDescription;

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
            this.picImage = new System.Windows.Forms.PictureBox();
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblDescription = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).BeginInit();
            this.SuspendLayout();
            // 
            // picImage
            // 
            this.picImage.Dock = System.Windows.Forms.DockStyle.Top;
            this.picImage.Location = new System.Drawing.Point(0, 0);
            this.picImage.Name = "picImage";
            this.picImage.Size = new System.Drawing.Size(200, 100);
            this.picImage.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picImage.TabIndex = 0;
            this.picImage.TabStop = false;
            // 
            // lblTitle
            // 
            this.lblTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblTitle.Location = new System.Drawing.Point(0, 100);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(200, 30);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Название";
            this.lblTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblDescription
            // 
            this.lblDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblDescription.Location = new System.Drawing.Point(0, 130);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(200, 70);
            this.lblDescription.TabIndex = 2;
            this.lblDescription.Text = "Описание";
            this.lblDescription.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // AnimeCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.lblDescription);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.picImage);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Name = "AnimeCard";
            this.Size = new System.Drawing.Size(200, 200);
            this.Click += new System.EventHandler(this.AnimeCard_Click);
            ((System.ComponentModel.ISupportInitialize)(this.picImage)).EndInit();
            this.ResumeLayout(false);
        }
    }
}