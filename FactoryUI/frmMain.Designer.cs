namespace FactoryUI
{
    partial class frmMain
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
            this.pbFighter = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cbChoiceGame = new System.Windows.Forms.ComboBox();
            this.cbChoiceFighter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFireball = new System.Windows.Forms.Button();
            this.btnDragonPunch = new System.Windows.Forms.Button();
            this.btnShowMainImage = new System.Windows.Forms.Button();
            this.lblMoveName = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pbFighter)).BeginInit();
            this.SuspendLayout();
            // 
            // pbFighter
            // 
            this.pbFighter.BackColor = System.Drawing.SystemColors.HighlightText;
            this.pbFighter.Location = new System.Drawing.Point(12, 12);
            this.pbFighter.Name = "pbFighter";
            this.pbFighter.Size = new System.Drawing.Size(415, 377);
            this.pbFighter.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pbFighter.TabIndex = 0;
            this.pbFighter.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(469, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 15);
            this.label1.TabIndex = 1;
            this.label1.Text = "Game";
            // 
            // cbChoiceGame
            // 
            this.cbChoiceGame.FormattingEnabled = true;
            this.cbChoiceGame.Location = new System.Drawing.Point(513, 12);
            this.cbChoiceGame.Name = "cbChoiceGame";
            this.cbChoiceGame.Size = new System.Drawing.Size(246, 23);
            this.cbChoiceGame.TabIndex = 2;
            this.cbChoiceGame.SelectedIndexChanged += new System.EventHandler(this.cbChoiceGame_SelectedIndexChanged);
            // 
            // cbChoiceFighter
            // 
            this.cbChoiceFighter.FormattingEnabled = true;
            this.cbChoiceFighter.Location = new System.Drawing.Point(513, 51);
            this.cbChoiceFighter.Name = "cbChoiceFighter";
            this.cbChoiceFighter.Size = new System.Drawing.Size(246, 23);
            this.cbChoiceFighter.TabIndex = 4;
            this.cbChoiceFighter.SelectedIndexChanged += new System.EventHandler(this.cbChoiceFighter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(463, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 15);
            this.label2.TabIndex = 3;
            this.label2.Text = "Fighter";
            // 
            // btnFireball
            // 
            this.btnFireball.Location = new System.Drawing.Point(513, 127);
            this.btnFireball.Name = "btnFireball";
            this.btnFireball.Size = new System.Drawing.Size(246, 23);
            this.btnFireball.TabIndex = 5;
            this.btnFireball.Text = "Fireball";
            this.btnFireball.UseVisualStyleBackColor = true;
            this.btnFireball.Click += new System.EventHandler(this.btnFireball_Click);
            // 
            // btnDragonPunch
            // 
            this.btnDragonPunch.Location = new System.Drawing.Point(513, 156);
            this.btnDragonPunch.Name = "btnDragonPunch";
            this.btnDragonPunch.Size = new System.Drawing.Size(246, 23);
            this.btnDragonPunch.TabIndex = 6;
            this.btnDragonPunch.Text = "Dragon Punch";
            this.btnDragonPunch.UseVisualStyleBackColor = true;
            this.btnDragonPunch.Click += new System.EventHandler(this.btnDragonPunch_Click);
            // 
            // btnShowMainImage
            // 
            this.btnShowMainImage.Location = new System.Drawing.Point(513, 94);
            this.btnShowMainImage.Name = "btnShowMainImage";
            this.btnShowMainImage.Size = new System.Drawing.Size(246, 23);
            this.btnShowMainImage.TabIndex = 7;
            this.btnShowMainImage.Text = "Main";
            this.btnShowMainImage.UseVisualStyleBackColor = true;
            this.btnShowMainImage.Click += new System.EventHandler(this.btnShowMainImage_Click);
            // 
            // lblMoveName
            // 
            this.lblMoveName.AutoSize = true;
            this.lblMoveName.Location = new System.Drawing.Point(12, 404);
            this.lblMoveName.Name = "lblMoveName";
            this.lblMoveName.Size = new System.Drawing.Size(0, 15);
            this.lblMoveName.TabIndex = 8;
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(777, 450);
            this.Controls.Add(this.lblMoveName);
            this.Controls.Add(this.btnShowMainImage);
            this.Controls.Add(this.btnDragonPunch);
            this.Controls.Add(this.btnFireball);
            this.Controls.Add(this.cbChoiceFighter);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cbChoiceGame);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pbFighter);
            this.Name = "frmMain";
            this.Text = "Shoto Fighter Factory";
            ((System.ComponentModel.ISupportInitialize)(this.pbFighter)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private PictureBox pbFighter;
        private Label label1;
        private ComboBox cbChoiceGame;
        private ComboBox cbChoiceFighter;
        private Label label2;
        private Button btnFireball;
        private Button btnDragonPunch;
        private Button btnShowMainImage;
        private Label lblMoveName;
    }
}