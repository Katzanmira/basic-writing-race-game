namespace _66840_Mehmet_Said_Unlu_T8
{
    partial class Form2
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
            this.components = new System.ComponentModel.Container();
            this.labeltime = new System.Windows.Forms.Label();
            this.labelScore = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.labelQuastions = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // labeltime
            // 
            this.labeltime.AutoSize = true;
            this.labeltime.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labeltime.Location = new System.Drawing.Point(93, 83);
            this.labeltime.Name = "labeltime";
            this.labeltime.Size = new System.Drawing.Size(104, 42);
            this.labeltime.TabIndex = 0;
            this.labeltime.Text = "Time";
            // 
            // labelScore
            // 
            this.labelScore.AutoSize = true;
            this.labelScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelScore.Location = new System.Drawing.Point(724, 83);
            this.labelScore.Name = "labelScore";
            this.labelScore.Size = new System.Drawing.Size(121, 42);
            this.labelScore.TabIndex = 1;
            this.labelScore.Text = "Score";
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.textBox1.Location = new System.Drawing.Point(100, 281);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(745, 44);
            this.textBox1.TabIndex = 2;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // labelQuastions
            // 
            this.labelQuastions.AutoSize = true;
            this.labelQuastions.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.875F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.labelQuastions.Location = new System.Drawing.Point(299, 203);
            this.labelQuastions.Name = "labelQuastions";
            this.labelQuastions.Size = new System.Drawing.Size(355, 42);
            this.labelQuastions.TabIndex = 3;
            this.labelQuastions.Text = "Words or Sentence";
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Cyan;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.125F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.button1.Location = new System.Drawing.Point(267, 374);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(387, 94);
            this.button1.TabIndex = 4;
            this.button1.Text = "Return to Menu";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Salmon;
            this.ClientSize = new System.Drawing.Size(970, 503);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.labelQuastions);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.labelScore);
            this.Controls.Add(this.labeltime);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labeltime;
        private System.Windows.Forms.Label labelScore;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label labelQuastions;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Timer timer1;
    }
}