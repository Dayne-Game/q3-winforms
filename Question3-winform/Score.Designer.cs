namespace Question3_winform
{
    partial class Score
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
            this.ScoreTitle = new System.Windows.Forms.Label();
            this.NameTitle = new System.Windows.Forms.Label();
            this.NameInput = new System.Windows.Forms.TextBox();
            this.Name_Submit_btn = new System.Windows.Forms.Button();
            this.ScoreDisplay = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // ScoreTitle
            // 
            this.ScoreTitle.AutoSize = true;
            this.ScoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 30F);
            this.ScoreTitle.Location = new System.Drawing.Point(225, 9);
            this.ScoreTitle.Name = "ScoreTitle";
            this.ScoreTitle.Size = new System.Drawing.Size(360, 91);
            this.ScoreTitle.TabIndex = 0;
            this.ScoreTitle.Text = "You Win!";
            // 
            // NameTitle
            // 
            this.NameTitle.AutoSize = true;
            this.NameTitle.Location = new System.Drawing.Point(12, 141);
            this.NameTitle.Name = "NameTitle";
            this.NameTitle.Size = new System.Drawing.Size(359, 25);
            this.NameTitle.TabIndex = 1;
            this.NameTitle.Text = "Enter your name(MAX 5 Characters)";
            // 
            // NameInput
            // 
            this.NameInput.Location = new System.Drawing.Point(17, 180);
            this.NameInput.Name = "NameInput";
            this.NameInput.Size = new System.Drawing.Size(100, 31);
            this.NameInput.TabIndex = 2;
            // 
            // Name_Submit_btn
            // 
            this.Name_Submit_btn.Location = new System.Drawing.Point(493, 143);
            this.Name_Submit_btn.Name = "Name_Submit_btn";
            this.Name_Submit_btn.Size = new System.Drawing.Size(174, 68);
            this.Name_Submit_btn.TabIndex = 3;
            this.Name_Submit_btn.Text = "Submit Name";
            this.Name_Submit_btn.UseVisualStyleBackColor = true;
            this.Name_Submit_btn.Click += new System.EventHandler(this.Name_Submit_btn_Click);
            // 
            // ScoreDisplay
            // 
            this.ScoreDisplay.AutoSize = true;
            this.ScoreDisplay.Font = new System.Drawing.Font("Microsoft Sans Serif", 25F);
            this.ScoreDisplay.Location = new System.Drawing.Point(144, 331);
            this.ScoreDisplay.Name = "ScoreDisplay";
            this.ScoreDisplay.Size = new System.Drawing.Size(0, 76);
            this.ScoreDisplay.TabIndex = 4;
            // 
            // Score
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ScoreDisplay);
            this.Controls.Add(this.Name_Submit_btn);
            this.Controls.Add(this.NameInput);
            this.Controls.Add(this.NameTitle);
            this.Controls.Add(this.ScoreTitle);
            this.Name = "Score";
            this.Text = "Scoring";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label ScoreTitle;
        private System.Windows.Forms.Label NameTitle;
        private System.Windows.Forms.TextBox NameInput;
        private System.Windows.Forms.Button Name_Submit_btn;
        private System.Windows.Forms.Label ScoreDisplay;
    }
}