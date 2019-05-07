namespace Question3_winform
{
    partial class Form1
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
            this.Easy_Select = new System.Windows.Forms.Button();
            this.Medium_Select = new System.Windows.Forms.Button();
            this.Hard_Select = new System.Windows.Forms.Button();
            this.Title = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Easy_Select
            // 
            this.Easy_Select.Location = new System.Drawing.Point(77, 300);
            this.Easy_Select.Name = "Easy_Select";
            this.Easy_Select.Size = new System.Drawing.Size(145, 73);
            this.Easy_Select.TabIndex = 0;
            this.Easy_Select.Text = "Easy";
            this.Easy_Select.UseVisualStyleBackColor = true;
            this.Easy_Select.Click += new System.EventHandler(this.Easy_Select_Click);
            // 
            // Medium_Select
            // 
            this.Medium_Select.Location = new System.Drawing.Point(317, 300);
            this.Medium_Select.Name = "Medium_Select";
            this.Medium_Select.Size = new System.Drawing.Size(145, 73);
            this.Medium_Select.TabIndex = 1;
            this.Medium_Select.Text = "Medium";
            this.Medium_Select.UseVisualStyleBackColor = true;
            this.Medium_Select.Click += new System.EventHandler(this.Medium_Select_Click);
            // 
            // Hard_Select
            // 
            this.Hard_Select.Location = new System.Drawing.Point(564, 300);
            this.Hard_Select.Name = "Hard_Select";
            this.Hard_Select.Size = new System.Drawing.Size(145, 73);
            this.Hard_Select.TabIndex = 2;
            this.Hard_Select.Text = "Hard";
            this.Hard_Select.UseVisualStyleBackColor = true;
            this.Hard_Select.Click += new System.EventHandler(this.Hard_Select_Click);
            // 
            // Title
            // 
            this.Title.AutoSize = true;
            this.Title.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.Title.Location = new System.Drawing.Point(45, 71);
            this.Title.Name = "Title";
            this.Title.Size = new System.Drawing.Size(0, 63);
            this.Title.TabIndex = 3;
            this.Title.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Title);
            this.Controls.Add(this.Hard_Select);
            this.Controls.Add(this.Medium_Select);
            this.Controls.Add(this.Easy_Select);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Easy_Select;
        private System.Windows.Forms.Button Medium_Select;
        private System.Windows.Forms.Button Hard_Select;
        private System.Windows.Forms.Label Title;
    }
}

