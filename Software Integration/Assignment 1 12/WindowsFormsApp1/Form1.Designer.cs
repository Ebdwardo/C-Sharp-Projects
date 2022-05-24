
namespace WindowsFormsApp1
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
            this.lowerLim = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.upperLim = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.guess = new System.Windows.Forms.TextBox();
            this.playButton = new System.Windows.Forms.Button();
            this.SecretNumButton = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.attempts = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(66, 62);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(60, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Lower Limit";
            // 
            // lowerLim
            // 
            this.lowerLim.Location = new System.Drawing.Point(152, 59);
            this.lowerLim.Name = "lowerLim";
            this.lowerLim.Size = new System.Drawing.Size(100, 20);
            this.lowerLim.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(289, 62);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Upper Limit";
            // 
            // upperLim
            // 
            this.upperLim.Location = new System.Drawing.Point(360, 59);
            this.upperLim.Name = "upperLim";
            this.upperLim.Size = new System.Drawing.Size(100, 20);
            this.upperLim.TabIndex = 3;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(66, 112);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Make a Guess";
            // 
            // guess
            // 
            this.guess.Location = new System.Drawing.Point(152, 112);
            this.guess.Name = "guess";
            this.guess.Size = new System.Drawing.Size(100, 20);
            this.guess.TabIndex = 5;
            // 
            // playButton
            // 
            this.playButton.Location = new System.Drawing.Point(293, 110);
            this.playButton.Name = "playButton";
            this.playButton.Size = new System.Drawing.Size(56, 23);
            this.playButton.TabIndex = 6;
            this.playButton.Text = "Play ";
            this.playButton.UseVisualStyleBackColor = true;
            this.playButton.Click += new System.EventHandler(this.playButton_Click);
            // 
            // SecretNumButton
            // 
            this.SecretNumButton.Location = new System.Drawing.Point(508, 57);
            this.SecretNumButton.Name = "SecretNumButton";
            this.SecretNumButton.Size = new System.Drawing.Size(148, 23);
            this.SecretNumButton.TabIndex = 7;
            this.SecretNumButton.Text = "Generate a Secret Number";
            this.SecretNumButton.UseVisualStyleBackColor = true;
            this.SecretNumButton.Click += new System.EventHandler(this.SecretNumButton_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(313, 165);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 8;
            this.label4.Text = "label4";
            this.label4.Visible = false;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(239, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(200, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Welcome to the Number Guessing Game";
            // 
            // attempts
            // 
            this.attempts.AutoSize = true;
            this.attempts.Location = new System.Drawing.Point(375, 115);
            this.attempts.Name = "attempts";
            this.attempts.Size = new System.Drawing.Size(112, 13);
            this.attempts.TabIndex = 10;
            this.attempts.Text = "Number of Attempts: 0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(710, 211);
            this.Controls.Add(this.attempts);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.SecretNumButton);
            this.Controls.Add(this.playButton);
            this.Controls.Add(this.guess);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.upperLim);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lowerLim);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox lowerLim;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox upperLim;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox guess;
        private System.Windows.Forms.Button playButton;
        private System.Windows.Forms.Button SecretNumButton;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label attempts;
    }
}

