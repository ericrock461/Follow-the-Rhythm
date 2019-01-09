namespace Follow_the_Rhythm
{
    partial class GameScreen
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
            this.components = new System.ComponentModel.Container();
            this.gameTimer = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.excellentLabel = new System.Windows.Forms.Label();
            this.greatLabel = new System.Windows.Forms.Label();
            this.okLabel = new System.Windows.Forms.Label();
            this.missLabel = new System.Windows.Forms.Label();
            this.exCount = new System.Windows.Forms.Label();
            this.grCount = new System.Windows.Forms.Label();
            this.oCount = new System.Windows.Forms.Label();
            this.msCount = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.White;
            this.pictureBox1.Location = new System.Drawing.Point(139, 320);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(58, 50);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackColor = System.Drawing.Color.White;
            this.pictureBox2.Location = new System.Drawing.Point(225, 320);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(56, 50);
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.BackColor = System.Drawing.Color.White;
            this.pictureBox3.Location = new System.Drawing.Point(301, 320);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(63, 50);
            this.pictureBox3.TabIndex = 2;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.BackColor = System.Drawing.Color.White;
            this.pictureBox4.Location = new System.Drawing.Point(382, 320);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(60, 50);
            this.pictureBox4.TabIndex = 3;
            this.pictureBox4.TabStop = false;
            // 
            // excellentLabel
            // 
            this.excellentLabel.AutoSize = true;
            this.excellentLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellentLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.excellentLabel.Location = new System.Drawing.Point(12, 102);
            this.excellentLabel.Name = "excellentLabel";
            this.excellentLabel.Size = new System.Drawing.Size(90, 20);
            this.excellentLabel.TabIndex = 4;
            this.excellentLabel.Text = "Excellent:";
            // 
            // greatLabel
            // 
            this.greatLabel.AutoSize = true;
            this.greatLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greatLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.greatLabel.Location = new System.Drawing.Point(12, 135);
            this.greatLabel.Name = "greatLabel";
            this.greatLabel.Size = new System.Drawing.Size(61, 20);
            this.greatLabel.TabIndex = 5;
            this.greatLabel.Text = "Great:";
            this.greatLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Black;
            this.okLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.okLabel.Location = new System.Drawing.Point(17, 175);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(40, 20);
            this.okLabel.TabIndex = 6;
            this.okLabel.Text = "OK:";
            // 
            // missLabel
            // 
            this.missLabel.AutoSize = true;
            this.missLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missLabel.ForeColor = System.Drawing.Color.Red;
            this.missLabel.Location = new System.Drawing.Point(17, 211);
            this.missLabel.Name = "missLabel";
            this.missLabel.Size = new System.Drawing.Size(52, 20);
            this.missLabel.TabIndex = 8;
            this.missLabel.Text = "Miss:";
            this.missLabel.Click += new System.EventHandler(this.missLabel_Click);
            // 
            // exCount
            // 
            this.exCount.AutoSize = true;
            this.exCount.ForeColor = System.Drawing.Color.White;
            this.exCount.Location = new System.Drawing.Point(109, 107);
            this.exCount.Name = "exCount";
            this.exCount.Size = new System.Drawing.Size(35, 13);
            this.exCount.TabIndex = 9;
            this.exCount.Text = "label1";
            // 
            // grCount
            // 
            this.grCount.AutoSize = true;
            this.grCount.ForeColor = System.Drawing.Color.White;
            this.grCount.Location = new System.Drawing.Point(117, 156);
            this.grCount.Name = "grCount";
            this.grCount.Size = new System.Drawing.Size(35, 13);
            this.grCount.TabIndex = 10;
            this.grCount.Text = "label2";
            this.grCount.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // oCount
            // 
            this.oCount.AutoSize = true;
            this.oCount.ForeColor = System.Drawing.Color.White;
            this.oCount.Location = new System.Drawing.Point(115, 196);
            this.oCount.Name = "oCount";
            this.oCount.Size = new System.Drawing.Size(35, 13);
            this.oCount.TabIndex = 11;
            this.oCount.Text = "label3";
            // 
            // msCount
            // 
            this.msCount.AutoSize = true;
            this.msCount.ForeColor = System.Drawing.Color.White;
            this.msCount.Location = new System.Drawing.Point(118, 234);
            this.msCount.Name = "msCount";
            this.msCount.Size = new System.Drawing.Size(35, 13);
            this.msCount.TabIndex = 12;
            this.msCount.Text = "label4";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.msCount);
            this.Controls.Add(this.oCount);
            this.Controls.Add(this.grCount);
            this.Controls.Add(this.exCount);
            this.Controls.Add(this.missLabel);
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.greatLabel);
            this.Controls.Add(this.excellentLabel);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(611, 383);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label excellentLabel;
        private System.Windows.Forms.Label greatLabel;
        private System.Windows.Forms.Label okLabel;
        private System.Windows.Forms.Label missLabel;
        private System.Windows.Forms.Label exCount;
        private System.Windows.Forms.Label grCount;
        private System.Windows.Forms.Label oCount;
        private System.Windows.Forms.Label msCount;
    }
}
