using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace _66840_Mehmet_Said_Unlu_T8
{
    public partial class Form2 : Form
    {
        private int score;
        private double timeLeft;
        private string currentQuestion;

        public Form2()
        {
            InitializeComponent();
            InitializeGame();
        }

        private void InitializeGame()
        {
            score = 0;
            timeLeft = 10.0;

            UpdateScore();
            UpdateTime();

            Timer timer = new Timer();
            timer.Interval = 100;
            timer.Tick += timer1_Tick;
            timer.Start();

            ShowNextQuestion();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timeLeft -= 0.1;
            UpdateTime();

            if (timeLeft <= 0)
            {
                ((Timer)sender).Stop();

                if (!CheckAnswer(textBox1.Text.Trim()))
                {
                    MessageBox.Show("Game Over", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    ShowNextQuestion();
                }
            }
        }
        private bool CheckAnswer(string input)
        {
            return input.Equals(currentQuestion);
        }

        private void ShowNextQuestion()
        {
            timeLeft = 10.0;
            UpdateTime();

            if (GameData.Mode == GameData.GameMode.WordOnly)
            {
                currentQuestion = GameData.Words[new Random().Next(GameData.Words.Count)];
            }
            else if (GameData.Mode == GameData.GameMode.SentencesOnly)
            {
                currentQuestion = GameData.Sentences[new Random().Next(GameData.Sentences.Count)];
            }
            else if (GameData.Mode == GameData.GameMode.Both)
            {
                currentQuestion = GameData.All[new Random().Next(GameData.All.Count)];
            }

            labelQuastions.Text = currentQuestion;
        }

        private void UpdateScore()
        {
            labelScore.Text = $"Score: {score}";
        }

        private void UpdateTime()
        {
            labeltime.Text = $"Time: {timeLeft.ToString("0.0")}s";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (textBox1.Text.Trim().Equals(currentQuestion))
            {
                score++;
                UpdateScore();
                ShowNextQuestion();
                textBox1.Clear();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            this.Hide();
            f1.ShowDialog();
            this.Close();
        }
            
    }
}
