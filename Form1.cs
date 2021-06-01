//Made by Ewan Peterson ICS3U

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Pong
{
    public partial class Form1 : Form
    {
        Rectangle player1 = new Rectangle(30, 120, 10, 60);
        Rectangle player2 = new Rectangle(30, 250, 10, 60);
        Rectangle ball = new Rectangle(295, 200, 10, 10);

        //scores
        int player1Score = 0;
        int player2Score = 0;

        //ball and player speeds
        int playerSpeed = 4;
        int ballXSpeed = 0;
        int ballYSpeed = 0;
        int ballBaseSpeed = 8;
        int ballTravelSpeed = 8;

        //rally and player turn variables
        int rally = 0;
        int playerTurn = 1;

        //keydown variables
        bool wDown = false;
        bool sDown = false;
        bool aDown = false;
        bool dDown = false;
        bool upArrowDown = false;
        bool downArrowDown = false;
        bool leftDown = false;
        bool rightDown = false;

        SolidBrush blueBrush = new SolidBrush(Color.DodgerBlue);
        SolidBrush whiteBrush = new SolidBrush(Color.White);
        Pen borderPen = new Pen(Color.Aqua, 4);


        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = true;
                    break;
                case Keys.S:
                    sDown = true;
                    break;
                case Keys.A:
                    aDown = true;
                    break;
                case Keys.D:
                    dDown = true;
                    break;
                case Keys.Up:
                    upArrowDown = true;
                    break;
                case Keys.Down:
                    downArrowDown = true;
                    break;
                case Keys.Left:
                    leftDown = true;
                    break;
                case Keys.Right:
                    rightDown = true;
                    break;
            }
        }

        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.W:
                    wDown = false;
                    break;
                case Keys.S:
                    sDown = false;
                    break;
                case Keys.A:
                    aDown = false;
                    break;
                case Keys.D:
                    dDown = false;
                    break;
                case Keys.Up:
                    upArrowDown = false;
                    break;
                case Keys.Down:
                    downArrowDown = false;
                    break;
                case Keys.Left:
                    leftDown = false;
                    break;
                case Keys.Right:
                    rightDown = false;
                    break;
            }
        }

        private void gameTimer_Tick(object sender, EventArgs e)
        {
            //move ball
            ball.X += ballXSpeed;
            ball.Y += ballYSpeed;

            //move player
            if (wDown == true && player1.Y > 0)
            {
                player1.Y -= playerSpeed;
            }

            if (sDown == true && player1.Y < this.Height - player1.Height)
            {
                player1.Y += playerSpeed;
            }

            if (aDown == true && player1.X > 0)
            {
                player1.X -= playerSpeed;
            }

            if (dDown == true && player1.X < this.Width - player1.Width)
            {
                player1.X += playerSpeed;
            }

            if (upArrowDown == true && player2.Y > 0)
            {
                player2.Y -= playerSpeed;
            }

            if (downArrowDown == true && player2.Y < this.Height - player2.Height)
            {
                player2.Y += playerSpeed;
            }

            if (leftDown == true && player2.X > 0)
            {
                player2.X -= playerSpeed;
            }

            if (rightDown == true && player2.X < this.Width - player2.Width)
            {
                player2.X += playerSpeed;
            }


            //ball collision with wall

            if (ball.Y < 0 || ball.Y > this.Height - ball.Height)
            {
                ballYSpeed *= -1;
            }
            if (ball.X > this.Width - ball.Width)
            {
                ballXSpeed *= -1;
                ball.X = this.Width - ball.Width;
            }


            //ball collision player

            if (player1.IntersectsWith(ball) && playerTurn == 1)
            {
                if (ballXSpeed == 0)
                {
                    ballXSpeed = ballBaseSpeed;
                    ballYSpeed = ballBaseSpeed;
                }
                else if (ballXSpeed < ballTravelSpeed)
                {
                    ballXSpeed = ballTravelSpeed;
                }
                playerTurn = 2;
                rally++;
                rallyLabel.Text = $"{rally}";

                if (rally % 2 == 0)
                {
                    ballTravelSpeed++;
                }
            }
            else if (player2.IntersectsWith(ball) && playerTurn == 2)
            {
                if (ballXSpeed == 0)
                {
                    ballXSpeed = ballBaseSpeed;
                    ballYSpeed = ballBaseSpeed;
                }
                else if (ballXSpeed < ballTravelSpeed)
                {
                    ballXSpeed = ballTravelSpeed;
                }
                playerTurn = 1;
                rally++;
                rallyLabel.Text = $"{rally}";

                if (rally % 2 == 0)
                {
                    ballTravelSpeed++;
                }
            }

            //player score

            if (ball.X < 0)
            {
                if (playerTurn == 1)
                {
                    player2Score++;
                    p2scoreLabel.Text = $"{player2Score}";
                    ballXSpeed = 0;
                    ballYSpeed = 0;

                    ball.X = 295;
                    ball.Y = 230;

                    player1.Y = 120;
                    player1.X = 30;
                    player2.Y = 250;
                    player2.X = 30;

                    rally = 0;
                    ballTravelSpeed = ballBaseSpeed;
                }
                else
                {
                    player1Score++;
                    p1scoreLabel.Text = $"{player1Score}";
                    ballXSpeed = 0;
                    ballYSpeed = 0;

                    ball.X = 295;
                    ball.Y = 195;

                    player1.Y = 120;
                    player1.X = 30;
                    player2.Y = 250;
                    player2.X = 30;
                    rally = 0;
                    ballTravelSpeed = ballBaseSpeed;
                }
            }


            //game over

            if (player1Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 1 Wins!!";
            }
            else if (player2Score == 3)
            {
                gameTimer.Enabled = false;
                winLabel.Visible = true;
                winLabel.Text = "Player 2 Wins!!";
            }

            Refresh();
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.FillRectangle(whiteBrush, player1);
            e.Graphics.FillRectangle(whiteBrush, player2);
            e.Graphics.FillRectangle(blueBrush, ball); ;

            if (playerTurn == 1)
            {
                e.Graphics.DrawRectangle(borderPen, player1);
            }
            else
            {
                e.Graphics.DrawRectangle(borderPen, player2);
            }

        }
    }
}
