namespace Flappybird
{
    partial class Form_main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_main));
            this.timer_main = new System.Windows.Forms.Timer(this.components);
            this.pictureBox_bird = new System.Windows.Forms.PictureBox();
            this.pictureBox_ground = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeDown1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeUp1 = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeUp2 = new System.Windows.Forms.PictureBox();
            this.pictureBox_pipeDown2 = new System.Windows.Forms.PictureBox();
            this.label_score = new System.Windows.Forms.Label();
            this.label_speed = new System.Windows.Forms.Label();
            this.label_gameOver = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown2)).BeginInit();
            this.SuspendLayout();
            // 
            // timer_main
            // 
            this.timer_main.Interval = 17;
            this.timer_main.Tick += new System.EventHandler(this.timer_main_Tick);
            // 
            // pictureBox_bird
            // 
            this.pictureBox_bird.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.pictureBox_bird.Image = global::Flappybird.Properties.Resources.bird;
            this.pictureBox_bird.Location = new System.Drawing.Point(158, 231);
            this.pictureBox_bird.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox_bird.Name = "pictureBox_bird";
            this.pictureBox_bird.Size = new System.Drawing.Size(96, 74);
            this.pictureBox_bird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox_bird.TabIndex = 0;
            this.pictureBox_bird.TabStop = false;
            // 
            // pictureBox_ground
            // 
            this.pictureBox_ground.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pictureBox_ground.Image = global::Flappybird.Properties.Resources.ground;
            this.pictureBox_ground.Location = new System.Drawing.Point(0, 851);
            this.pictureBox_ground.Name = "pictureBox_ground";
            this.pictureBox_ground.Size = new System.Drawing.Size(1732, 209);
            this.pictureBox_ground.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_ground.TabIndex = 1;
            this.pictureBox_ground.TabStop = false;
            // 
            // pictureBox_pipeDown1
            // 
            this.pictureBox_pipeDown1.Image = global::Flappybird.Properties.Resources.pipedown;
            this.pictureBox_pipeDown1.Location = new System.Drawing.Point(2013, 0);
            this.pictureBox_pipeDown1.Name = "pictureBox_pipeDown1";
            this.pictureBox_pipeDown1.Size = new System.Drawing.Size(138, 386);
            this.pictureBox_pipeDown1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeDown1.TabIndex = 4;
            this.pictureBox_pipeDown1.TabStop = false;
            this.pictureBox_pipeDown1.Visible = false;
            // 
            // pictureBox_pipeUp1
            // 
            this.pictureBox_pipeUp1.Image = global::Flappybird.Properties.Resources.pipe;
            this.pictureBox_pipeUp1.Location = new System.Drawing.Point(2013, 568);
            this.pictureBox_pipeUp1.Name = "pictureBox_pipeUp1";
            this.pictureBox_pipeUp1.Size = new System.Drawing.Size(138, 355);
            this.pictureBox_pipeUp1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeUp1.TabIndex = 5;
            this.pictureBox_pipeUp1.TabStop = false;
            this.pictureBox_pipeUp1.Visible = false;
            // 
            // pictureBox_pipeUp2
            // 
            this.pictureBox_pipeUp2.Image = global::Flappybird.Properties.Resources.pipe;
            this.pictureBox_pipeUp2.Location = new System.Drawing.Point(734, 543);
            this.pictureBox_pipeUp2.Name = "pictureBox_pipeUp2";
            this.pictureBox_pipeUp2.Size = new System.Drawing.Size(138, 355);
            this.pictureBox_pipeUp2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeUp2.TabIndex = 7;
            this.pictureBox_pipeUp2.TabStop = false;
            this.pictureBox_pipeUp2.Visible = false;
            // 
            // pictureBox_pipeDown2
            // 
            this.pictureBox_pipeDown2.Image = global::Flappybird.Properties.Resources.pipedown;
            this.pictureBox_pipeDown2.Location = new System.Drawing.Point(734, 0);
            this.pictureBox_pipeDown2.Name = "pictureBox_pipeDown2";
            this.pictureBox_pipeDown2.Size = new System.Drawing.Size(138, 386);
            this.pictureBox_pipeDown2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox_pipeDown2.TabIndex = 6;
            this.pictureBox_pipeDown2.TabStop = false;
            this.pictureBox_pipeDown2.Visible = false;
            // 
            // label_score
            // 
            this.label_score.AutoSize = true;
            this.label_score.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.label_score.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_score.Location = new System.Drawing.Point(16, 968);
            this.label_score.Name = "label_score";
            this.label_score.Size = new System.Drawing.Size(250, 74);
            this.label_score.TabIndex = 8;
            this.label_score.Text = "Score: 0";
            // 
            // label_speed
            // 
            this.label_speed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(216)))), ((int)(((byte)(149)))));
            this.label_speed.Font = new System.Drawing.Font("Segoe UI Black", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_speed.Location = new System.Drawing.Point(1278, 957);
            this.label_speed.Name = "label_speed";
            this.label_speed.Size = new System.Drawing.Size(438, 89);
            this.label_speed.TabIndex = 9;
            this.label_speed.Text = "Speed: 1x";
            this.label_speed.TextAlign = System.Drawing.ContentAlignment.TopRight;
            // 
            // label_gameOver
            // 
            this.label_gameOver.Font = new System.Drawing.Font("Segoe UI Black", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_gameOver.Location = new System.Drawing.Point(290, 415);
            this.label_gameOver.Name = "label_gameOver";
            this.label_gameOver.Size = new System.Drawing.Size(1154, 229);
            this.label_gameOver.TabIndex = 10;
            this.label_gameOver.Text = "GAME OVER";
            this.label_gameOver.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Form_main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(112)))), ((int)(((byte)(196)))), ((int)(((byte)(206)))));
            this.ClientSize = new System.Drawing.Size(1732, 1060);
            this.Controls.Add(this.label_gameOver);
            this.Controls.Add(this.label_speed);
            this.Controls.Add(this.label_score);
            this.Controls.Add(this.pictureBox_pipeUp2);
            this.Controls.Add(this.pictureBox_pipeDown2);
            this.Controls.Add(this.pictureBox_pipeUp1);
            this.Controls.Add(this.pictureBox_pipeDown1);
            this.Controls.Add(this.pictureBox_ground);
            this.Controls.Add(this.pictureBox_bird);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "Form_main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Coding Modul - Flappy Bird";
            this.Load += new System.EventHandler(this.Form_main_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_main_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_bird)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_ground)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeUp2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox_pipeDown2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox_bird;
        private System.Windows.Forms.Timer timer_main;
        private System.Windows.Forms.PictureBox pictureBox_ground;
        private System.Windows.Forms.PictureBox pictureBox_pipeDown1;
        private System.Windows.Forms.PictureBox pictureBox_pipeUp1;
        private System.Windows.Forms.PictureBox pictureBox_pipeUp2;
        private System.Windows.Forms.PictureBox pictureBox_pipeDown2;
        private System.Windows.Forms.Label label_score;
        private System.Windows.Forms.Label label_speed;
        private System.Windows.Forms.Label label_gameOver;
    }
}

