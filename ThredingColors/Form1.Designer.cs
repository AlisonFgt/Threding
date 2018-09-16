namespace ThredingColors
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
            this.btnBlue = new System.Windows.Forms.Button();
            this.btnRed = new System.Windows.Forms.Button();
            this.btnPink = new System.Windows.Forms.Button();
            this.btnGreen = new System.Windows.Forms.Button();
            this.btnShow = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnBlue
            // 
            this.btnBlue.Location = new System.Drawing.Point(770, 87);
            this.btnBlue.Name = "btnBlue";
            this.btnBlue.Size = new System.Drawing.Size(75, 23);
            this.btnBlue.TabIndex = 0;
            this.btnBlue.Text = "Blue";
            this.btnBlue.UseVisualStyleBackColor = true;
            this.btnBlue.Click += new System.EventHandler(this.btnBlue_Click);
            // 
            // btnRed
            // 
            this.btnRed.Location = new System.Drawing.Point(864, 87);
            this.btnRed.Name = "btnRed";
            this.btnRed.Size = new System.Drawing.Size(75, 23);
            this.btnRed.TabIndex = 1;
            this.btnRed.Text = "Red";
            this.btnRed.UseVisualStyleBackColor = true;
            this.btnRed.Click += new System.EventHandler(this.btnRed_Click);
            // 
            // btnPink
            // 
            this.btnPink.Location = new System.Drawing.Point(770, 126);
            this.btnPink.Name = "btnPink";
            this.btnPink.Size = new System.Drawing.Size(75, 23);
            this.btnPink.TabIndex = 2;
            this.btnPink.Text = "Pink";
            this.btnPink.UseVisualStyleBackColor = true;
            this.btnPink.Click += new System.EventHandler(this.btnPink_Click);
            // 
            // btnGreen
            // 
            this.btnGreen.Location = new System.Drawing.Point(864, 126);
            this.btnGreen.Name = "btnGreen";
            this.btnGreen.Size = new System.Drawing.Size(75, 23);
            this.btnGreen.TabIndex = 3;
            this.btnGreen.Text = "Green";
            this.btnGreen.UseVisualStyleBackColor = true;
            this.btnGreen.Click += new System.EventHandler(this.btnGreen_Click);
            // 
            // btnShow
            // 
            this.btnShow.Location = new System.Drawing.Point(808, 171);
            this.btnShow.Name = "btnShow";
            this.btnShow.Size = new System.Drawing.Size(100, 23);
            this.btnShow.TabIndex = 4;
            this.btnShow.Text = "Go to show";
            this.btnShow.UseVisualStyleBackColor = true;
            this.btnShow.Click += new System.EventHandler(this.btnShow_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1672, 719);
            this.Controls.Add(this.btnShow);
            this.Controls.Add(this.btnGreen);
            this.Controls.Add(this.btnPink);
            this.Controls.Add(this.btnRed);
            this.Controls.Add(this.btnBlue);
            this.Name = "Form1";
            this.Text = "Thread!";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnBlue;
        private System.Windows.Forms.Button btnRed;
        private System.Windows.Forms.Button btnPink;
        private System.Windows.Forms.Button btnGreen;
        private System.Windows.Forms.Button btnShow;
    }
}

