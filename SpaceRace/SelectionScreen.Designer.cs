﻿namespace SpaceRace
{
    partial class SelectionScreen
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.titleLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.quitButton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.p2PictureBox = new System.Windows.Forms.PictureBox();
            this.p1PictureBox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // titleLabel
            // 
            this.titleLabel.BackColor = System.Drawing.Color.Black;
            this.titleLabel.Font = new System.Drawing.Font("Digital-7 Mono", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.White;
            this.titleLabel.Location = new System.Drawing.Point(18, 49);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(503, 39);
            this.titleLabel.TabIndex = 0;
            this.titleLabel.Text = "Player 1                   Player 2";
            // 
            // startButton
            // 
            this.startButton.BackColor = System.Drawing.Color.Black;
            this.startButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.startButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Lime;
            this.startButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startButton.ForeColor = System.Drawing.Color.White;
            this.startButton.Location = new System.Drawing.Point(573, 49);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(179, 75);
            this.startButton.TabIndex = 4;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = false;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            this.startButton.Enter += new System.EventHandler(this.startButton_Enter);
            // 
            // quitButton
            // 
            this.quitButton.BackColor = System.Drawing.Color.Black;
            this.quitButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.White;
            this.quitButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Red;
            this.quitButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.quitButton.Font = new System.Drawing.Font("Digital-7 Mono", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quitButton.ForeColor = System.Drawing.Color.White;
            this.quitButton.Location = new System.Drawing.Point(573, 177);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(179, 75);
            this.quitButton.TabIndex = 5;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = false;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            this.quitButton.Enter += new System.EventHandler(this.quitButton_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(330, 536);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "label1";
            // 
            // p2PictureBox
            // 
            this.p2PictureBox.BackgroundImage = global::SpaceRace.Properties.Resources.kindpng_490723;
            this.p2PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p2PictureBox.Location = new System.Drawing.Point(275, 91);
            this.p2PictureBox.Name = "p2PictureBox";
            this.p2PictureBox.Size = new System.Drawing.Size(246, 425);
            this.p2PictureBox.TabIndex = 7;
            this.p2PictureBox.TabStop = false;
            // 
            // p1PictureBox
            // 
            this.p1PictureBox.BackgroundImage = global::SpaceRace.Properties.Resources.kindpng_490723;
            this.p1PictureBox.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.p1PictureBox.Location = new System.Drawing.Point(23, 91);
            this.p1PictureBox.Name = "p1PictureBox";
            this.p1PictureBox.Size = new System.Drawing.Size(246, 425);
            this.p1PictureBox.TabIndex = 6;
            this.p1PictureBox.TabStop = false;
            // 
            // SelectionScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(144F, 144F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.label1);
            this.Controls.Add(this.p2PictureBox);
            this.Controls.Add(this.p1PictureBox);
            this.Controls.Add(this.quitButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.titleLabel);
            this.Name = "SelectionScreen";
            this.Size = new System.Drawing.Size(800, 700);
            ((System.ComponentModel.ISupportInitialize)(this.p2PictureBox)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.p1PictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button quitButton;
        private System.Windows.Forms.PictureBox p1PictureBox;
        private System.Windows.Forms.PictureBox p2PictureBox;
        private System.Windows.Forms.Label label1;
    }
}
