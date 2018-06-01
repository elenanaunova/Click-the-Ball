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
            this.label1 = new System.Windows.Forms.Label();
            this.choice1 = new System.Windows.Forms.Button();
            this.choice2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Matura MT Script Capitals", 22F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Cyan;
            this.label1.Location = new System.Drawing.Point(106, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(235, 50);
            this.label1.TabIndex = 0;
            this.label1.Text = "Choose game";
            // 
            // choice1
            // 
            this.choice1.BackColor = System.Drawing.SystemColors.InfoText;
            this.choice1.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.choice1.FlatAppearance.BorderSize = 5;
            this.choice1.Font = new System.Drawing.Font("Bahnschrift", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice1.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.choice1.Location = new System.Drawing.Point(124, 127);
            this.choice1.Name = "choice1";
            this.choice1.Size = new System.Drawing.Size(226, 36);
            this.choice1.TabIndex = 1;
            this.choice1.Text = "Click the ball";
            this.choice1.UseVisualStyleBackColor = false;
            this.choice1.Click += new System.EventHandler(this.choice1_Click);
            // 
            // choice2
            // 
            this.choice2.BackColor = System.Drawing.SystemColors.InfoText;
            this.choice2.FlatAppearance.BorderColor = System.Drawing.Color.Black;
            this.choice2.FlatAppearance.BorderSize = 0;
            this.choice2.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Black;
            this.choice2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.choice2.Font = new System.Drawing.Font("Bahnschrift", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.choice2.ForeColor = System.Drawing.Color.DarkTurquoise;
            this.choice2.Location = new System.Drawing.Point(124, 190);
            this.choice2.Name = "choice2";
            this.choice2.Size = new System.Drawing.Size(226, 36);
            this.choice2.TabIndex = 2;
            this.choice2.Text = "Move the ball";
            this.choice2.UseVisualStyleBackColor = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuText;
            this.ClientSize = new System.Drawing.Size(483, 386);
            this.Controls.Add(this.choice2);
            this.Controls.Add(this.choice1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button choice1;
        private System.Windows.Forms.Button choice2;
    }
}

