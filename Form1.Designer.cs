
namespace Pong
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
            this.components = new System.ComponentModel.Container();
            this.p1scoreLabel = new System.Windows.Forms.Label();
            this.p2scoreLabel = new System.Windows.Forms.Label();
            this.winLabel = new System.Windows.Forms.Label();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.rallyLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // p1scoreLabel
            // 
            this.p1scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p1scoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p1scoreLabel.ForeColor = System.Drawing.Color.White;
            this.p1scoreLabel.Location = new System.Drawing.Point(152, 9);
            this.p1scoreLabel.Name = "p1scoreLabel";
            this.p1scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.p1scoreLabel.TabIndex = 0;
            this.p1scoreLabel.Text = "0";
            this.p1scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // p2scoreLabel
            // 
            this.p2scoreLabel.BackColor = System.Drawing.Color.Transparent;
            this.p2scoreLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.p2scoreLabel.ForeColor = System.Drawing.Color.White;
            this.p2scoreLabel.Location = new System.Drawing.Point(345, 9);
            this.p2scoreLabel.Name = "p2scoreLabel";
            this.p2scoreLabel.Size = new System.Drawing.Size(100, 23);
            this.p2scoreLabel.TabIndex = 1;
            this.p2scoreLabel.Text = "0";
            this.p2scoreLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // winLabel
            // 
            this.winLabel.BackColor = System.Drawing.Color.Transparent;
            this.winLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.winLabel.ForeColor = System.Drawing.Color.White;
            this.winLabel.Location = new System.Drawing.Point(12, 206);
            this.winLabel.Name = "winLabel";
            this.winLabel.Size = new System.Drawing.Size(576, 71);
            this.winLabel.TabIndex = 2;
            this.winLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // rallyLabel
            // 
            this.rallyLabel.BackColor = System.Drawing.Color.Transparent;
            this.rallyLabel.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rallyLabel.ForeColor = System.Drawing.Color.White;
            this.rallyLabel.Location = new System.Drawing.Point(12, 368);
            this.rallyLabel.Name = "rallyLabel";
            this.rallyLabel.Size = new System.Drawing.Size(576, 23);
            this.rallyLabel.TabIndex = 3;
            this.rallyLabel.Text = "0";
            this.rallyLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(600, 400);
            this.Controls.Add(this.rallyLabel);
            this.Controls.Add(this.winLabel);
            this.Controls.Add(this.p2scoreLabel);
            this.Controls.Add(this.p1scoreLabel);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.Form1_Paint);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label p1scoreLabel;
        private System.Windows.Forms.Label p2scoreLabel;
        private System.Windows.Forms.Label winLabel;
        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label rallyLabel;
    }
}

