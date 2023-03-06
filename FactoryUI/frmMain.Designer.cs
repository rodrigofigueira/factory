namespace FactoryUI
{
    partial class FrmMain
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.PbFighter = new System.Windows.Forms.PictureBox();
            this.CbChoiceGame = new System.Windows.Forms.ComboBox();
            this.CbChoiceFighter = new System.Windows.Forms.ComboBox();
            this.BtnFireball = new System.Windows.Forms.Button();
            this.BtnDragonPunch = new System.Windows.Forms.Button();
            this.BtnShowMainImage = new System.Windows.Forms.Button();
            this.LblMoveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.PbFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // PbFighter
            // 
            this.PbFighter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.PbFighter.Location = new System.Drawing.Point(12, 12);
            this.PbFighter.Name = "PbFighter";
            this.PbFighter.Size = new System.Drawing.Size(415, 377);
            this.PbFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.PbFighter.TabIndex = 0;
            this.PbFighter.TabStop = false;
            // 
            // CbChoiceGame
            // 
            this.CbChoiceGame.FormattingEnabled = true;
            this.CbChoiceGame.Location = new System.Drawing.Point(513, 12);
            this.CbChoiceGame.Name = "CbChoiceGame";
            this.CbChoiceGame.Size = new System.Drawing.Size(246, 23);
            this.CbChoiceGame.TabIndex = 0;
            this.CbChoiceGame.SelectedIndexChanged += new System.EventHandler(this.CbChoiceGame_SelectedIndexChanged);
            // 
            // CbChoiceFighter
            // 
            this.CbChoiceFighter.FormattingEnabled = true;
            this.CbChoiceFighter.Location = new System.Drawing.Point(513, 51);
            this.CbChoiceFighter.Name = "CbChoiceFighter";
            this.CbChoiceFighter.Size = new System.Drawing.Size(246, 23);
            this.CbChoiceFighter.TabIndex = 1;
            this.CbChoiceFighter.SelectedIndexChanged += new System.EventHandler(this.CbChoiceFighter_SelectedIndexChanged);
            // 
            // BtnFireball
            // 
            this.BtnFireball.Location = new System.Drawing.Point(513, 127);
            this.BtnFireball.Name = "BtnFireball";
            this.BtnFireball.Size = new System.Drawing.Size(246, 23);
            this.BtnFireball.TabIndex = 3;
            this.BtnFireball.Text = "Fireball";
            this.BtnFireball.UseVisualStyleBackColor = true;
            this.BtnFireball.Click += new System.EventHandler(this.BtnFireball_Click);
            // 
            // BtnDragonPunch
            // 
            this.BtnDragonPunch.Location = new System.Drawing.Point(513, 156);
            this.BtnDragonPunch.Name = "BtnDragonPunch";
            this.BtnDragonPunch.Size = new System.Drawing.Size(246, 23);
            this.BtnDragonPunch.TabIndex = 4;
            this.BtnDragonPunch.Text = "Dragon Punch";
            this.BtnDragonPunch.UseVisualStyleBackColor = true;
            this.BtnDragonPunch.Click += new System.EventHandler(this.BtnDragonPunch_Click);
            // 
            // BtnShowMainImage
            // 
            this.BtnShowMainImage.Location = new System.Drawing.Point(513, 94);
            this.BtnShowMainImage.Name = "BtnShowMainImage";
            this.BtnShowMainImage.Size = new System.Drawing.Size(246, 23);
            this.BtnShowMainImage.TabIndex = 2;
            this.BtnShowMainImage.Text = "Main";
            this.BtnShowMainImage.UseVisualStyleBackColor = true;
            this.BtnShowMainImage.Click += new System.EventHandler(this.BtnShowMainImage_Click);
            // 
            // LblMoveName
            // 
            this.LblMoveName.AutoSize = true;
            this.LblMoveName.Location = new System.Drawing.Point(12, 404);
            this.LblMoveName.Name = "LblMoveName";
            this.LblMoveName.Size = new System.Drawing.Size(0, 15);
            this.LblMoveName.TabIndex = 8;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.LblMoveName);
            this.Controls.Add(this.BtnShowMainImage);
            this.Controls.Add(this.BtnDragonPunch);
            this.Controls.Add(this.BtnFireball);
            this.Controls.Add(this.CbChoiceFighter);
            this.Controls.Add(this.CbChoiceGame);
            this.Controls.Add(this.PbFighter);
            this.MaximizeBox = false;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Shoto Fighter Factory";
            ((System.ComponentModel.ISupportInitialize)(this.PbFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox PbFighter;        
        private ComboBox CbChoiceGame;
        private ComboBox CbChoiceFighter;
        private Button BtnFireball;
        private Button BtnDragonPunch;
        private Button BtnShowMainImage;
        private Label LblMoveName;
    }
}