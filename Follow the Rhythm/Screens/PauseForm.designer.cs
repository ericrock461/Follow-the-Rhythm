namespace Follow_the_Rhythm
{
    partial class PauseForm
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
            this.instructions = new System.Windows.Forms.Button();
            this.backToSelect = new System.Windows.Forms.Button();
            this.backLabel = new System.Windows.Forms.Label();
            this.unpauseLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // instructions
            // 
            this.instructions.BackColor = System.Drawing.Color.Thistle;
            this.instructions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.instructions.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructions.Location = new System.Drawing.Point(190, 99);
            this.instructions.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.instructions.Name = "instructions";
            this.instructions.Size = new System.Drawing.Size(176, 32);
            this.instructions.TabIndex = 0;
            this.instructions.Text = "Instructions";
            this.instructions.UseVisualStyleBackColor = false;
            this.instructions.Click += new System.EventHandler(this.continueButton_Click);
            this.instructions.Enter += new System.EventHandler(this.button_Enter);
            // 
            // backToSelect
            // 
            this.backToSelect.BackColor = System.Drawing.Color.Thistle;
            this.backToSelect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.backToSelect.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.backToSelect.Location = new System.Drawing.Point(190, 194);
            this.backToSelect.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.backToSelect.Name = "backToSelect";
            this.backToSelect.Size = new System.Drawing.Size(176, 32);
            this.backToSelect.TabIndex = 1;
            this.backToSelect.Text = "Level Select";
            this.backToSelect.UseVisualStyleBackColor = false;
            this.backToSelect.Click += new System.EventHandler(this.exitButton_Click);
            this.backToSelect.Enter += new System.EventHandler(this.button_Enter);
            // 
            // backLabel
            // 
            this.backLabel.BackColor = System.Drawing.Color.Thistle;
            this.backLabel.Location = new System.Drawing.Point(64, 31);
            this.backLabel.Name = "backLabel";
            this.backLabel.Size = new System.Drawing.Size(409, 252);
            this.backLabel.TabIndex = 2;
            // 
            // unpauseLabel
            // 
            this.unpauseLabel.BackColor = System.Drawing.Color.Indigo;
            this.unpauseLabel.ForeColor = System.Drawing.Color.Thistle;
            this.unpauseLabel.Location = new System.Drawing.Point(46, 304);
            this.unpauseLabel.Name = "unpauseLabel";
            this.unpauseLabel.Size = new System.Drawing.Size(159, 23);
            this.unpauseLabel.TabIndex = 3;
            this.unpauseLabel.Text = "Esc: Unpause";
            // 
            // PauseForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Indigo;
            this.ClientSize = new System.Drawing.Size(533, 336);
            this.Controls.Add(this.unpauseLabel);
            this.Controls.Add(this.backToSelect);
            this.Controls.Add(this.instructions);
            this.Controls.Add(this.backLabel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "PauseForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PauseForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button instructions;
        private System.Windows.Forms.Button backToSelect;
        private System.Windows.Forms.Label backLabel;
        private System.Windows.Forms.Label unpauseLabel;
    }
}