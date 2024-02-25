namespace NumberGuesserGUI
{
    partial class startMenu
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
            this.label2 = new System.Windows.Forms.Label();
            this.levelEasy = new System.Windows.Forms.RadioButton();
            this.levelMedium = new System.Windows.Forms.RadioButton();
            this.levelHard = new System.Windows.Forms.RadioButton();
            this.startGame = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Akira Expanded", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(159, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Number Guesser Game";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Caviar Dreams", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(293, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(207, 27);
            this.label2.TabIndex = 1;
            this.label2.Text = "Choose a level: ";
            // 
            // levelEasy
            // 
            this.levelEasy.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelEasy.AutoSize = true;
            this.levelEasy.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelEasy.Location = new System.Drawing.Point(304, 187);
            this.levelEasy.Name = "levelEasy";
            this.levelEasy.Size = new System.Drawing.Size(171, 23);
            this.levelEasy.TabIndex = 2;
            this.levelEasy.TabStop = true;
            this.levelEasy.Text = "Easy (8 attempts)";
            this.levelEasy.UseVisualStyleBackColor = true;
            // 
            // levelMedium
            // 
            this.levelMedium.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelMedium.AutoSize = true;
            this.levelMedium.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelMedium.Location = new System.Drawing.Point(304, 229);
            this.levelMedium.Name = "levelMedium";
            this.levelMedium.Size = new System.Drawing.Size(196, 23);
            this.levelMedium.TabIndex = 3;
            this.levelMedium.TabStop = true;
            this.levelMedium.Text = "Medium (5 attempts)";
            this.levelMedium.UseVisualStyleBackColor = true;
            // 
            // levelHard
            // 
            this.levelHard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.levelHard.AutoSize = true;
            this.levelHard.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.levelHard.Location = new System.Drawing.Point(304, 269);
            this.levelHard.Name = "levelHard";
            this.levelHard.Size = new System.Drawing.Size(174, 23);
            this.levelHard.TabIndex = 4;
            this.levelHard.TabStop = true;
            this.levelHard.Text = "Hard (3 attempts)";
            this.levelHard.UseVisualStyleBackColor = true;
            // 
            // startGame
            // 
            this.startGame.BackColor = System.Drawing.Color.LightSkyBlue;
            this.startGame.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.startGame.Cursor = System.Windows.Forms.Cursors.Default;
            this.startGame.Font = new System.Drawing.Font("Caviar Dreams", 12F, System.Drawing.FontStyle.Bold);
            this.startGame.Location = new System.Drawing.Point(299, 341);
            this.startGame.Name = "startGame";
            this.startGame.Size = new System.Drawing.Size(196, 43);
            this.startGame.TabIndex = 5;
            this.startGame.Text = "Start Game";
            this.startGame.UseVisualStyleBackColor = false;
            this.startGame.Click += new System.EventHandler(this.startGame_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.LightSteelBlue;
            this.ClientSize = new System.Drawing.Size(782, 443);
            this.Controls.Add(this.startGame);
            this.Controls.Add(this.levelHard);
            this.Controls.Add(this.levelMedium);
            this.Controls.Add(this.levelEasy);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RadioButton levelEasy;
        private System.Windows.Forms.RadioButton levelMedium;
        private System.Windows.Forms.RadioButton levelHard;
        private System.Windows.Forms.Button startGame;
    }
}

