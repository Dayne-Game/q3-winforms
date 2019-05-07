using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Question3_winform.Models;
using System.Diagnostics;

namespace Question3_winform
{
    public partial class Score : Form
    {
        static Scoring score = new Scoring();
        static GameExtended game = new GameExtended();
        static Messages messages = new Messages();
        static string level_difficulty = "";
        public Score(string win_lose, int rough_score, string difficulty)
        {
            InitializeComponent();
            ScoreTitle.Text = win_lose;
            level_difficulty = difficulty;
            score.Rough_Score_Value = rough_score;
            score.Convert_Rough_Score_Into_True_Score();
            Debug.WriteLine(game.difficulty_level);
            NameTitle.Text = messages.Enter_Name;
        }

        private void Name_Submit_btn_Click(object sender, EventArgs e)
        {
            if (score.Check_Five_Char_Name(NameInput.Text))
            {
                score.Five_Character_Name = NameInput.Text;
                ScoreDisplay.Text = score.Display_Five_Character_Name_And_True_Score_From_Score_And_Name_Database(level_difficulty);
            }
            else
            {
                NameTitle.Text = "Your Name is Too Long or No Name is Entererd";
            }
        }
    }
}
