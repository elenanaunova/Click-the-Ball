namespace ProektVP
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
            this.choice2 = new System.Windows.Forms.Button();
            this.choiceStart = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.SystemColors.Highlight;
            this.choice2.FlatAppearance.BorderSize = 0;
            this.choice2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choice2.Font = new System.Drawing.Font("Jokerman", 12.7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.ForeColor = System.Drawing.Color.White;
            this.choice2.Location = new System.Drawing.Point(393, 203);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(81, 46);
            this.choice2.TabIndex = 0;
            this.choice2.Text = "EXIT";
            this.choice2.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.choice2.UseVisualStyleBackColor = false;
            this.choice2.Click += new System.EventHandler(this.choice2_Click);
            // 
            // choiceStart
            // 
            this.choiceStart.BackColor = System.Drawing.SystemColors.Highlight;
            this.choiceStart.FlatAppearance.BorderSize = 0;
            this.choiceStart.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.choiceStart.Font = new System.Drawing.Font("Jokerman", 12F);
            this.choiceStart.ForeColor = System.Drawing.Color.White;
            this.choiceStart.Location = new System.Drawing.Point(20, 184);
            this.choiceStart.Name = "choiceStart";
            this.choiceStart.Size = new System.Drawing.Size(96, 45);
            this.choiceStart.TabIndex = 1;
            this.choiceStart.Text = "START";
            this.choiceStart.UseVisualStyleBackColor = false;
            this.choiceStart.Click += new System.EventHandler(this.choiceStart_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.pictureBox1.BackgroundImage = global::ProektVP.Properties.Resources.bukvi;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.Location = new System.Drawing.Point(119, 75);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(287, 111);
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = global::ProektVP.Properties.Resources.pozadina1;
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox2.Location = new System.Drawing.Point(167, 213);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(194, 169);
            this.pictureBox2.TabIndex = 3;
            this.pictureBox2.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::ProektVP.Properties.Resources.pozadina;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(492, 493);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.choiceStart);
            this.Controls.Add(this.choice2);
            this.ForeColor = System.Drawing.Color.Coral;
            this.MaximumSize = new System.Drawing.Size(510, 540);
            this.MinimumSize = new System.Drawing.Size(510, 540);
            this.Name = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button choice2;
        private System.Windows.Forms.Button choiceStart;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
    }
}

