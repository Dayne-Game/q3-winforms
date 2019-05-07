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
    public partial class MainGame : Form
    {
        static Messages messages = new Messages();
        static GameExtended game = new GameExtended();
        static int rough_score = 0;
        static string win_lose = "";
        static int counter = 0;
        public MainGame(string case_number)
        {
            InitializeComponent();
            counter = 0;
            game.Chosen_Number_Guessed = false;
            GameTitle.Text = messages.Welcome;
            GuessTitle.Text = messages.Enter_Guess;
            Difficulty.Text = game.Change_Max_Number_In_Range_Difficulty(case_number);
            game.Load_Game_Settings();
        }

        private void Guess_Submit_Btn_Click(object sender, EventArgs e)
        {
            while (counter < 3 && !game.Chosen_Number_Guessed)
            {
                int.TryParse(GuessInput.Text, out int user_input);
                GuessTitle.Text = game.Game_Commencing(user_input);
                Debug.WriteLine(game.Guess_Database.Count);
                Debug.WriteLine(game.Chosen_Number_Guessed);
                if (game.Chosen_Number_Guessed == true)
                {
                    rough_score = game.Guess_Database.Count;
                    win_lose = "You Win";
                    Score score = new Score(win_lose, rough_score, game.difficulty_level);
                    score.Show();
                }
                counter++;
                Debug.WriteLine(counter);
                break;
            }
            if (game.Guess_Database.Count == 3 && game.Chosen_Number_Guessed == false)
            {
                win_lose = "You Lost";
                Score score = new Score(win_lose, rough_score, game.difficulty_level);
                score.Show();
            }
        }
    }
}
