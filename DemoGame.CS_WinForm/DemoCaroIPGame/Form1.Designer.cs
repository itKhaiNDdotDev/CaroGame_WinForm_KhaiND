namespace DemoCaroIPGame
{
    partial class MainScreen
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainScreen));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btClose = new System.Windows.Forms.Button();
            this.btNewGame = new System.Windows.Forms.Button();
            this.boxPicCurPlayer = new System.Windows.Forms.PictureBox();
            this.MainLabel = new System.Windows.Forms.Label();
            this.btConnectIP = new System.Windows.Forms.Button();
            this.boxIP = new System.Windows.Forms.TextBox();
            this.coutTimeBar = new System.Windows.Forms.ProgressBar();
            this.boxNameCurPlayer = new System.Windows.Forms.TextBox();
            this.pnPlayBoard = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicCurPlayer)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.panel1.Controls.Add(this.btClose);
            this.panel1.Controls.Add(this.btNewGame);
            this.panel1.Controls.Add(this.boxPicCurPlayer);
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Controls.Add(this.btConnectIP);
            this.panel1.Controls.Add(this.boxIP);
            this.panel1.Controls.Add(this.coutTimeBar);
            this.panel1.Controls.Add(this.boxNameCurPlayer);
            this.panel1.Location = new System.Drawing.Point(883, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(236, 514);
            this.panel1.TabIndex = 2;
            // 
            // btClose
            // 
            this.btClose.BackColor = System.Drawing.Color.Gold;
            this.btClose.Font = new System.Drawing.Font("Oswald", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btClose.ForeColor = System.Drawing.Color.Navy;
            this.btClose.Location = new System.Drawing.Point(3, 54);
            this.btClose.Name = "btClose";
            this.btClose.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btClose.Size = new System.Drawing.Size(230, 50);
            this.btClose.TabIndex = 7;
            this.btClose.Text = "Close";
            this.btClose.UseVisualStyleBackColor = false;
            // 
            // btNewGame
            // 
            this.btNewGame.BackColor = System.Drawing.Color.Gold;
            this.btNewGame.Font = new System.Drawing.Font("Oswald", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btNewGame.ForeColor = System.Drawing.Color.Navy;
            this.btNewGame.Location = new System.Drawing.Point(3, 3);
            this.btNewGame.Name = "btNewGame";
            this.btNewGame.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btNewGame.Size = new System.Drawing.Size(230, 50);
            this.btNewGame.TabIndex = 6;
            this.btNewGame.Text = "New Game";
            this.btNewGame.UseVisualStyleBackColor = false;
            // 
            // boxPicCurPlayer
            // 
            this.boxPicCurPlayer.AccessibleRole = System.Windows.Forms.AccessibleRole.Alert;
            this.boxPicCurPlayer.Anchor = System.Windows.Forms.AnchorStyles.Left;
            this.boxPicCurPlayer.BackColor = System.Drawing.SystemColors.ControlDark;
            this.boxPicCurPlayer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.boxPicCurPlayer.Location = new System.Drawing.Point(52, 157);
            this.boxPicCurPlayer.Name = "boxPicCurPlayer";
            this.boxPicCurPlayer.Size = new System.Drawing.Size(133, 119);
            this.boxPicCurPlayer.TabIndex = 5;
            this.boxPicCurPlayer.TabStop = false;
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Stencil", 30F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.MainLabel.Location = new System.Drawing.Point(19, 356);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.MainLabel.Size = new System.Drawing.Size(197, 141);
            this.MainLabel.TabIndex = 4;
            this.MainLabel.Text = " 5 IN\r\nA LINE \r\n TO WIN! ";
            this.MainLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btConnectIP
            // 
            this.btConnectIP.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btConnectIP.Cursor = System.Windows.Forms.Cursors.Default;
            this.btConnectIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btConnectIP.Location = new System.Drawing.Point(137, 311);
            this.btConnectIP.Name = "btConnectIP";
            this.btConnectIP.Size = new System.Drawing.Size(96, 29);
            this.btConnectIP.TabIndex = 3;
            this.btConnectIP.Text = "Connect";
            this.btConnectIP.UseVisualStyleBackColor = false;
            // 
            // boxIP
            // 
            this.boxIP.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxIP.Location = new System.Drawing.Point(3, 281);
            this.boxIP.Name = "boxIP";
            this.boxIP.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxIP.Size = new System.Drawing.Size(230, 29);
            this.boxIP.TabIndex = 2;
            this.boxIP.Text = "127 . 0 . 0 . 1";
            this.boxIP.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // coutTimeBar
            // 
            this.coutTimeBar.Location = new System.Drawing.Point(3, 143);
            this.coutTimeBar.Name = "coutTimeBar";
            this.coutTimeBar.Size = new System.Drawing.Size(230, 13);
            this.coutTimeBar.TabIndex = 1;
            // 
            // boxNameCurPlayer
            // 
            this.boxNameCurPlayer.Font = new System.Drawing.Font("Times New Roman", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boxNameCurPlayer.Location = new System.Drawing.Point(3, 110);
            this.boxNameCurPlayer.Name = "boxNameCurPlayer";
            this.boxNameCurPlayer.ReadOnly = true;
            this.boxNameCurPlayer.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.boxNameCurPlayer.Size = new System.Drawing.Size(230, 32);
            this.boxNameCurPlayer.TabIndex = 0;
            this.boxNameCurPlayer.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // pnPlayBoard
            // 
            this.pnPlayBoard.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pnPlayBoard.AutoScroll = true;
            this.pnPlayBoard.BackColor = System.Drawing.Color.PaleGoldenrod;
            this.pnPlayBoard.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pnPlayBoard.Location = new System.Drawing.Point(1, 1);
            this.pnPlayBoard.Name = "pnPlayBoard";
            this.pnPlayBoard.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.pnPlayBoard.Size = new System.Drawing.Size(1134, 540);
            this.pnPlayBoard.TabIndex = 0;
            this.pnPlayBoard.Paint += new System.Windows.Forms.PaintEventHandler(this.pnPlayBroad_Paint);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.SystemColors.Desktop;
            this.ClientSize = new System.Drawing.Size(1136, 542);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.pnPlayBoard);
            this.ForeColor = System.Drawing.SystemColors.Desktop;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Location = new System.Drawing.Point(86, 32);
            this.Name = "MainScreen";
            this.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Kcaro Throw IP";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.boxPicCurPlayer)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel pnPlayBoard;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox boxNameCurPlayer;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Button btConnectIP;
        private System.Windows.Forms.TextBox boxIP;
        private System.Windows.Forms.ProgressBar coutTimeBar;
        private System.Windows.Forms.PictureBox boxPicCurPlayer;
        private System.Windows.Forms.Button btClose;
        private System.Windows.Forms.Button btNewGame;
    }
}

