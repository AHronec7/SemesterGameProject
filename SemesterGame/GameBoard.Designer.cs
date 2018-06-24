namespace SemesterGame
{
    partial class GameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            this.PlayerLabel1 = new System.Windows.Forms.Label();
            this.DealCardsButton = new System.Windows.Forms.Button();
            this.CardPictureBox = new System.Windows.Forms.PictureBox();
            this.BackButton = new System.Windows.Forms.Button();
            this.CardsImageList = new System.Windows.Forms.ImageList(this.components);
            this.PlayerLabelTwo = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // PlayerLabel1
            // 
            this.PlayerLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLabel1.Location = new System.Drawing.Point(12, 9);
            this.PlayerLabel1.Name = "PlayerLabel1";
            this.PlayerLabel1.Size = new System.Drawing.Size(90, 19);
            this.PlayerLabel1.TabIndex = 0;
            // 
            // DealCardsButton
            // 
            this.DealCardsButton.Location = new System.Drawing.Point(691, 391);
            this.DealCardsButton.Name = "DealCardsButton";
            this.DealCardsButton.Size = new System.Drawing.Size(75, 29);
            this.DealCardsButton.TabIndex = 1;
            this.DealCardsButton.Text = "Deal";
            this.DealCardsButton.UseVisualStyleBackColor = true;
            this.DealCardsButton.Click += new System.EventHandler(this.DealCardsButton_Click);
            // 
            // CardPictureBox
            // 
            this.CardPictureBox.Location = new System.Drawing.Point(12, 40);
            this.CardPictureBox.Name = "CardPictureBox";
            this.CardPictureBox.Size = new System.Drawing.Size(100, 121);
            this.CardPictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.CardPictureBox.TabIndex = 2;
            this.CardPictureBox.TabStop = false;
            // 
            // BackButton
            // 
            this.BackButton.Location = new System.Drawing.Point(29, 391);
            this.BackButton.Name = "BackButton";
            this.BackButton.Size = new System.Drawing.Size(75, 23);
            this.BackButton.TabIndex = 3;
            this.BackButton.Text = "Back ";
            this.BackButton.UseVisualStyleBackColor = true;
            this.BackButton.Click += new System.EventHandler(this.BackButton_Click);
            // 
            // CardsImageList
            // 
            this.CardsImageList.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("CardsImageList.ImageStream")));
            this.CardsImageList.TransparentColor = System.Drawing.Color.Transparent;
            this.CardsImageList.Images.SetKeyName(0, "2_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(1, "2_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(2, "2_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(3, "2_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(4, "3_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(5, "3_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(6, "3_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(7, "3_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(8, "4_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(9, "4_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(10, "4_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(11, "4_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(12, "5_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(13, "5_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(14, "5_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(15, "5_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(16, "6_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(17, "6_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(18, "6_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(19, "6_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(20, "7_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(21, "7_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(22, "7_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(23, "7_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(24, "8_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(25, "8_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(26, "8_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(27, "8_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(28, "9_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(29, "9_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(30, "9_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(31, "9_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(32, "10_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(33, "10_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(34, "10_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(35, "10_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(36, "Ace_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(37, "Ace_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(38, "Ace_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(39, "Ace_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(40, "Backface_Blue.bmp");
            this.CardsImageList.Images.SetKeyName(41, "Backface_Red.bmp");
            this.CardsImageList.Images.SetKeyName(42, "Jack_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(43, "Jack_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(44, "Jack_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(45, "Jack_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(46, "Joker_Black.bmp");
            this.CardsImageList.Images.SetKeyName(47, "Joker_Red.bmp");
            this.CardsImageList.Images.SetKeyName(48, "King_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(49, "King_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(50, "King_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(51, "King_Spades.bmp");
            this.CardsImageList.Images.SetKeyName(52, "Queen_Clubs.bmp");
            this.CardsImageList.Images.SetKeyName(53, "Queen_Diamonds.bmp");
            this.CardsImageList.Images.SetKeyName(54, "Queen_Hearts.bmp");
            this.CardsImageList.Images.SetKeyName(55, "Queen_Spades.bmp");
            // 
            // PlayerLabelTwo
            // 
            this.PlayerLabelTwo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PlayerLabelTwo.Location = new System.Drawing.Point(666, 9);
            this.PlayerLabelTwo.Name = "PlayerLabelTwo";
            this.PlayerLabelTwo.Size = new System.Drawing.Size(100, 19);
            this.PlayerLabelTwo.TabIndex = 4;
            // 
            // GameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackgroundImage = global::SemesterGame.Properties.Resources.FeltTable;
            this.ClientSize = new System.Drawing.Size(778, 432);
            this.Controls.Add(this.PlayerLabelTwo);
            this.Controls.Add(this.BackButton);
            this.Controls.Add(this.CardPictureBox);
            this.Controls.Add(this.DealCardsButton);
            this.Controls.Add(this.PlayerLabel1);
            this.Name = "GameBoard";
            this.Text = "GameBoard";
            this.Load += new System.EventHandler(this.GameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CardPictureBox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label PlayerLabel1;
        private System.Windows.Forms.Button DealCardsButton;
        private System.Windows.Forms.PictureBox CardPictureBox;
        private System.Windows.Forms.Button BackButton;
        private System.Windows.Forms.ImageList CardsImageList;
        private System.Windows.Forms.Label PlayerLabelTwo;
    }
}