namespace SemesterGame
{
    partial class PokerGameMainScreen
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
            this.label1 = new System.Windows.Forms.Label();
            this.GO = new System.Windows.Forms.Button();
            this.PlayerSelectListBox = new System.Windows.Forms.ListBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddPlayersTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(357, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(164, 20);
            this.label1.TabIndex = 1;
            this.label1.Text = "Welcome to Poker!!";
        
            // 
            // GO
            // 
            this.GO.Location = new System.Drawing.Point(669, 340);
            this.GO.Name = "GO";
            this.GO.Size = new System.Drawing.Size(75, 39);
            this.GO.TabIndex = 2;
            this.GO.Text = "GO! ";
            this.GO.UseVisualStyleBackColor = true;
            this.GO.Click += new System.EventHandler(this.GO_Click);
            // 
            // PlayerSelectListBox
            // 
            this.PlayerSelectListBox.BackColor = System.Drawing.Color.Gainsboro;
            this.PlayerSelectListBox.FormattingEnabled = true;
            this.PlayerSelectListBox.Location = new System.Drawing.Point(12, 74);
            this.PlayerSelectListBox.MultiColumn = true;
            this.PlayerSelectListBox.Name = "PlayerSelectListBox";
            this.PlayerSelectListBox.Size = new System.Drawing.Size(219, 277);
            this.PlayerSelectListBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(310, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(258, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(172, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "Select Your Player...";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(491, 238);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(197, 15);
            this.label4.TabIndex = 6;
            this.label4.Text = "If you would like to add any players:";
            // 
            // AddPlayersTextBox
            // 
            this.AddPlayersTextBox.Location = new System.Drawing.Point(494, 276);
            this.AddPlayersTextBox.Name = "AddPlayersTextBox";
            this.AddPlayersTextBox.Size = new System.Drawing.Size(164, 20);
            this.AddPlayersTextBox.TabIndex = 7;
            this.AddPlayersTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.AddPlayersTextBox_KeyPress);
            // 
            // PokerGameMainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::SemesterGame.Properties.Resources.poker_background_vintage_playing_cards_34034983;
            this.ClientSize = new System.Drawing.Size(806, 391);
            this.Controls.Add(this.AddPlayersTextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.PlayerSelectListBox);
            this.Controls.Add(this.GO);
            this.Controls.Add(this.label1);
            this.Name = "PokerGameMainScreen";
            this.Text = "PokerGameMainScreen";
            this.Load += new System.EventHandler(this.PokerGameMainScreen_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GO;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox AddPlayersTextBox;
        public System.Windows.Forms.ListBox PlayerSelectListBox;
    }
}