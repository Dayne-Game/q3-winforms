namespace Question3_winform
{
    partial class MainGame
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
            this.GameTitle = new System.Windows.Forms.Label();
            this.GuessTitle = new System.Windows.Forms.Label();
            this.Difficulty = new System.Windows.Forms.Label();
            this.GuessInput = new System.Windows.Forms.TextBox();
            this.Guess_Submit_Btn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // GameTitle
            // 
            this.GameTitle.AutoSize = true;
            this.GameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.GameTitle.Location = new System.Drawing.Point(24, 19);
            this.GameTitle.Name = "GameTitle";
            this.GameTitle.Size = new System.Drawing.Size(732, 63);
            this.GameTitle.TabIndex = 0;
            this.GameTitle.Text = "Welcome to the Guess Game";
            // 
            // GuessTitle
            // 
            this.GuessTitle.AutoSize = true;
            this.GuessTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.GuessTitle.Location = new System.Drawing.Point(27, 143);
            this.GuessTitle.Name = "GuessTitle";
            this.GuessTitle.Size = new System.Drawing.Size(298, 46);
            this.GuessTitle.TabIndex = 1;
            this.GuessTitle.Text = "Enter Guess >>";
            // 
            // Difficulty
            // 
            this.Difficulty.AutoSize = true;
            this.Difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.Difficulty.Location = new System.Drawing.Point(400, 151);
            this.Difficulty.Name = "Difficulty";
            this.Difficulty.Size = new System.Drawing.Size(356, 37);
            this.Difficulty.TabIndex = 2;
            this.Difficulty.Text = "Selected Difficulty: Easy";
            // 
            // GuessInput
            // 
            this.GuessInput.Location = new System.Drawing.Point(35, 244);
            this.GuessInput.Name = "GuessInput";
            this.GuessInput.Size = new System.Drawing.Size(100, 31);
            this.GuessInput.TabIndex = 3;
            // 
            // Guess_Submit_Btn
            // 
            this.Guess_Submit_Btn.Location = new System.Drawing.Point(499, 224);
            this.Guess_Submit_Btn.Name = "Guess_Submit_Btn";
            this.Guess_Submit_Btn.Size = new System.Drawing.Size(164, 71);
            this.Guess_Submit_Btn.TabIndex = 4;
            this.Guess_Submit_Btn.Text = "Submit Guess";
            this.Guess_Submit_Btn.UseVisualStyleBackColor = true;
            this.Guess_Submit_Btn.Click += new System.EventHandler(this.Guess_Submit_Btn_Click);
            // 
            // MainGame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Guess_Submit_Btn);
            this.Controls.Add(this.GuessInput);
            this.Controls.Add(this.Difficulty);
            this.Controls.Add(this.GuessTitle);
            this.Controls.Add(this.GameTitle);
            this.Name = "MainGame";
            this.Text = "MainGame";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label GameTitle;
        private System.Windows.Forms.Label GuessTitle;
        private System.Windows.Forms.Label Difficulty;
        private System.Windows.Forms.TextBox GuessInput;
        private System.Windows.Forms.Button Guess_Submit_Btn;
    }
}