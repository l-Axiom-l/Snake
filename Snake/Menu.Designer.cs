namespace Snake
{
    partial class Menu
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
            this.quitButton = new System.Windows.Forms.Button();
            this.startButton = new System.Windows.Forms.Button();
            this.xDim = new System.Windows.Forms.TextBox();
            this.speed = new System.Windows.Forms.TextBox();
            this.yDim = new System.Windows.Forms.TextBox();
            this.xDimLabel = new System.Windows.Forms.Label();
            this.yDimLabel = new System.Windows.Forms.Label();
            this.speedlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // quitButton
            // 
            this.quitButton.Location = new System.Drawing.Point(12, 150);
            this.quitButton.Name = "quitButton";
            this.quitButton.Size = new System.Drawing.Size(311, 29);
            this.quitButton.TabIndex = 0;
            this.quitButton.Text = "Quit";
            this.quitButton.UseVisualStyleBackColor = true;
            this.quitButton.Click += new System.EventHandler(this.quitButton_Click);
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(12, 115);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(311, 29);
            this.startButton.TabIndex = 1;
            this.startButton.Text = "Start";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // xDim
            // 
            this.xDim.Location = new System.Drawing.Point(12, 82);
            this.xDim.Name = "xDim";
            this.xDim.Size = new System.Drawing.Size(150, 27);
            this.xDim.TabIndex = 2;
            this.xDim.Text = "20";
            this.xDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // speed
            // 
            this.speed.Location = new System.Drawing.Point(12, 32);
            this.speed.Name = "speed";
            this.speed.Size = new System.Drawing.Size(311, 27);
            this.speed.TabIndex = 3;
            this.speed.Text = "150";
            this.speed.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // yDim
            // 
            this.yDim.Location = new System.Drawing.Point(173, 82);
            this.yDim.Name = "yDim";
            this.yDim.Size = new System.Drawing.Size(150, 27);
            this.yDim.TabIndex = 4;
            this.yDim.Text = "20";
            this.yDim.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // xDimLabel
            // 
            this.xDimLabel.Location = new System.Drawing.Point(12, 62);
            this.xDimLabel.Name = "xDimLabel";
            this.xDimLabel.Size = new System.Drawing.Size(150, 20);
            this.xDimLabel.TabIndex = 5;
            this.xDimLabel.Text = "XDim";
            this.xDimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // yDimLabel
            // 
            this.yDimLabel.Location = new System.Drawing.Point(173, 62);
            this.yDimLabel.Name = "yDimLabel";
            this.yDimLabel.Size = new System.Drawing.Size(147, 20);
            this.yDimLabel.TabIndex = 6;
            this.yDimLabel.Text = "YDim";
            this.yDimLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speedlabel
            // 
            this.speedlabel.Location = new System.Drawing.Point(12, 4);
            this.speedlabel.Name = "speedlabel";
            this.speedlabel.Size = new System.Drawing.Size(311, 30);
            this.speedlabel.TabIndex = 7;
            this.speedlabel.Text = "Speed";
            this.speedlabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Menu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(332, 186);
            this.Controls.Add(this.speedlabel);
            this.Controls.Add(this.yDimLabel);
            this.Controls.Add(this.xDimLabel);
            this.Controls.Add(this.yDim);
            this.Controls.Add(this.speed);
            this.Controls.Add(this.xDim);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.quitButton);
            this.Name = "Menu";
            this.Text = "Menu";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button quitButton;
        private Button startButton;
        private TextBox xDim;
        private TextBox speed;
        private TextBox yDim;
        private Label xDimLabel;
        private Label yDimLabel;
        private Label speedlabel;
    }
}