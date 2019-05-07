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

namespace Question3_winform
{
    public partial class Form1 : Form
    {
        static Messages messages = new Messages();
        static string case_number = "";
        public Form1()
        {
            InitializeComponent();
            Title.Text = messages.Case_Select_UI;
        }

        private void Easy_Select_Click(object sender, EventArgs e)
        {
            case_number = "1";
            MainGame game = new MainGame(case_number);
            game.Show();

        }

        private void Medium_Select_Click(object sender, EventArgs e)
        {
            case_number = "2";
            MainGame game = new MainGame(case_number);
            game.Show();
        }

        private void Hard_Select_Click(object sender, EventArgs e)
        {
            case_number = "3";
            MainGame game = new MainGame(case_number);
            game.Show();
        }
    }
}
