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
            this.excellentLabel = new System.Windows.Forms.Label();
            this.greatLabel = new System.Windows.Forms.Label();
            this.okLabel = new System.Windows.Forms.Label();
            this.missLabel = new System.Windows.Forms.Label();
            this.exCount = new System.Windows.Forms.Label();
            this.grCount = new System.Windows.Forms.Label();
            this.oCount = new System.Windows.Forms.Label();
            this.msCount = new System.Windows.Forms.Label();
            this.countLabel = new System.Windows.Forms.Label();
            this.noteCounter = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.timerCount = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // gameTimer
            // 
            this.gameTimer.Enabled = true;
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.gameTimer_Tick);
            // 
            // excellentLabel
            // 
            this.excellentLabel.AutoSize = true;
            this.excellentLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.excellentLabel.ForeColor = System.Drawing.Color.ForestGreen;
            this.excellentLabel.Location = new System.Drawing.Point(1, 66);
            this.excellentLabel.Name = "excellentLabel";
            this.excellentLabel.Size = new System.Drawing.Size(73, 16);
            this.excellentLabel.TabIndex = 4;
            this.excellentLabel.Text = "Excellent:";
            // 
            // greatLabel
            // 
            this.greatLabel.AutoSize = true;
            this.greatLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.greatLabel.ForeColor = System.Drawing.Color.LimeGreen;
            this.greatLabel.Location = new System.Drawing.Point(28, 126);
            this.greatLabel.Name = "greatLabel";
            this.greatLabel.Size = new System.Drawing.Size(50, 16);
            this.greatLabel.TabIndex = 5;
            this.greatLabel.Text = "Great:";
            this.greatLabel.Click += new System.EventHandler(this.label2_Click);
            // 
            // okLabel
            // 
            this.okLabel.AutoSize = true;
            this.okLabel.BackColor = System.Drawing.Color.Black;
            this.okLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okLabel.ForeColor = System.Drawing.Color.GreenYellow;
            this.okLabel.Location = new System.Drawing.Point(42, 188);
            this.okLabel.Name = "okLabel";
            this.okLabel.Size = new System.Drawing.Size(32, 16);
            this.okLabel.TabIndex = 6;
            this.okLabel.Text = "OK:";
            // 
            // missLabel
            // 
            this.missLabel.AutoSize = true;
            this.missLabel.Font = new System.Drawing.Font("MS Reference Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.missLabel.ForeColor = System.Drawing.Color.Red;
            this.missLabel.Location = new System.Drawing.Point(36, 251);
            this.missLabel.Name = "missLabel";
            this.missLabel.Size = new System.Drawing.Size(42, 16);
            this.missLabel.TabIndex = 8;
            this.missLabel.Text = "Miss:";
            this.missLabel.Click += new System.EventHandler(this.missLabel_Click);
            // 
            // exCount
            // 
            this.exCount.AutoSize = true;
            this.exCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exCount.ForeColor = System.Drawing.Color.ForestGreen;
            this.exCount.Location = new System.Drawing.Point(70, 47);
            this.exCount.Name = "exCount";
            this.exCount.Size = new System.Drawing.Size(36, 39);
            this.exCount.TabIndex = 9;
            this.exCount.Text = "0";
            // 
            // grCount
            // 
            this.grCount.AutoSize = true;
            this.grCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grCount.ForeColor = System.Drawing.Color.LimeGreen;
            this.grCount.Location = new System.Drawing.Point(70, 107);
            this.grCount.Name = "grCount";
            this.grCount.Size = new System.Drawing.Size(36, 39);
            this.grCount.TabIndex = 10;
            this.grCount.Text = "0";
            this.grCount.Click += new System.EventHandler(this.label2_Click_1);
            // 
            // oCount
            // 
            this.oCount.AutoSize = true;
            this.oCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.oCount.ForeColor = System.Drawing.Color.GreenYellow;
            this.oCount.Location = new System.Drawing.Point(70, 169);
            this.oCount.Name = "oCount";
            this.oCount.Size = new System.Drawing.Size(36, 39);
            this.oCount.TabIndex = 11;
            this.oCount.Text = "0";
            // 
            // msCount
            // 
            this.msCount.AutoSize = true;
            this.msCount.BackColor = System.Drawing.Color.Black;
            this.msCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 26.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.msCount.ForeColor = System.Drawing.Color.Snow;
            this.msCount.Location = new System.Drawing.Point(70, 232);
            this.msCount.Name = "msCount";
            this.msCount.Size = new System.Drawing.Size(36, 39);
            this.msCount.TabIndex = 12;
            this.msCount.Text = "0";
            // 
            // countLabel
            // 
            this.countLabel.AutoSize = true;
            this.countLabel.ForeColor = System.Drawing.Color.DarkOrange;
            this.countLabel.Location = new System.Drawing.Point(532, 320);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(61, 13);
            this.countLabel.TabIndex = 13;
            this.countLabel.Text = "Note Count";
            // 
            // noteCounter
            // 
            this.noteCounter.AutoSize = true;
            this.noteCounter.Font = new System.Drawing.Font("Bell Gothic Std Black", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.noteCounter.ForeColor = System.Drawing.Color.DarkOrange;
            this.noteCounter.Location = new System.Drawing.Point(520, 338);
            this.noteCounter.Name = "noteCounter";
            this.noteCounter.Size = new System.Drawing.Size(83, 32);
            this.noteCounter.TabIndex = 14;
            this.noteCounter.Text = "0/100";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 311);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 15;
            this.label1.Text = "label1";
            // 
            // timerCount
            // 
            this.timerCount.BackColor = System.Drawing.Color.White;
            this.timerCount.Location = new System.Drawing.Point(28, 338);
            this.timerCount.Name = "timerCount";
            this.timerCount.Size = new System.Drawing.Size(109, 13);
            this.timerCount.TabIndex = 16;
            this.timerCount.Text = "Timer Count";
            // 
            // GameScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.Controls.Add(this.timerCount);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.noteCounter);
            this.Controls.Add(this.countLabel);
            this.Controls.Add(this.msCount);
            this.Controls.Add(this.oCount);
            this.Controls.Add(this.grCount);
            this.Controls.Add(this.exCount);
            this.Controls.Add(this.missLabel);
            this.Controls.Add(this.okLabel);
            this.Controls.Add(this.greatLabel);
            this.Controls.Add(this.excellentLabel);
            this.DoubleBuffered = true;
            this.Name = "GameScreen";
            this.Size = new System.Drawing.Size(628, 383);
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.GameScreen_Paint);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.GameScreen_KeyUp);
            this.PreviewKeyDown += new System.Windows.Forms.PreviewKeyDownEventHandler(this.GameScreen_PreviewKeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer gameTimer;
        private System.Windows.Forms.Label excellentLabel;
        private System.Windows.Forms.Label greatLabel;
        private System.Windows.Forms.Label okLabel;
        private System.Windows.Forms.Label missLabel;
        private System.Windows.Forms.Label exCount;
        private System.Windows.Forms.Label grCount;
        private System.Windows.Forms.Label oCount;
        private System.Windows.Forms.Label msCount;
        private System.Windows.Forms.Label countLabel;
        private System.Windows.Forms.Label noteCounter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label timerCount;
    }
}
