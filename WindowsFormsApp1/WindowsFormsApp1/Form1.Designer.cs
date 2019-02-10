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
            this.lblScore = new System.Windows.Forms.Label();
            this.lblScoreTotal = new System.Windows.Forms.Label();
            this.lblScoreCount = new System.Windows.Forms.Label();
            this.lblAverage = new System.Windows.Forms.Label();
            this.btnClrScores = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.btnExit = new System.Windows.Forms.Button();
            this.txtScore = new System.Windows.Forms.TextBox();
            this.txtScoreTotal = new System.Windows.Forms.TextBox();
            this.txtScoreCount = new System.Windows.Forms.TextBox();
            this.txtAvg = new System.Windows.Forms.TextBox();
            this.btnDisplayScores = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblScore
            // 
            this.lblScore.AutoSize = true;
            this.lblScore.Location = new System.Drawing.Point(45, 40);
            this.lblScore.Name = "lblScore";
            this.lblScore.Size = new System.Drawing.Size(38, 13);
            this.lblScore.TabIndex = 0;
            this.lblScore.Text = "Score:";
            // 
            // lblScoreTotal
            // 
            this.lblScoreTotal.AutoSize = true;
            this.lblScoreTotal.Location = new System.Drawing.Point(18, 71);
            this.lblScoreTotal.Name = "lblScoreTotal";
            this.lblScoreTotal.Size = new System.Drawing.Size(65, 13);
            this.lblScoreTotal.TabIndex = 1;
            this.lblScoreTotal.Text = "Score Total:";
            // 
            // lblScoreCount
            // 
            this.lblScoreCount.AutoSize = true;
            this.lblScoreCount.Location = new System.Drawing.Point(14, 103);
            this.lblScoreCount.Name = "lblScoreCount";
            this.lblScoreCount.Size = new System.Drawing.Size(69, 13);
            this.lblScoreCount.TabIndex = 2;
            this.lblScoreCount.Text = "Score Count:";
            // 
            // lblAverage
            // 
            this.lblAverage.AutoSize = true;
            this.lblAverage.Location = new System.Drawing.Point(33, 134);
            this.lblAverage.Name = "lblAverage";
            this.lblAverage.Size = new System.Drawing.Size(50, 13);
            this.lblAverage.TabIndex = 3;
            this.lblAverage.Text = "Average:";
            // 
            // btnClrScores
            // 
            this.btnClrScores.Location = new System.Drawing.Point(48, 174);
            this.btnClrScores.Name = "btnClrScores";
            this.btnClrScores.Size = new System.Drawing.Size(75, 23);
            this.btnClrScores.TabIndex = 4;
            this.btnClrScores.Text = "Clear Scores";
            this.btnClrScores.UseVisualStyleBackColor = true;
            this.btnClrScores.Click += new System.EventHandler(this.btnClrScores_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(224, 38);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(75, 23);
            this.btnAdd.TabIndex = 5;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
            this.btnAdd.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EnterPress);
            // 
            // btnExit
            // 
            this.btnExit.Location = new System.Drawing.Point(183, 174);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(75, 23);
            this.btnExit.TabIndex = 6;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            this.btnExit.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.EscPress);
            // 
            // txtScore
            // 
            this.txtScore.Location = new System.Drawing.Point(90, 40);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(100, 20);
            this.txtScore.TabIndex = 7;
            // 
            // txtScoreTotal
            // 
            this.txtScoreTotal.Location = new System.Drawing.Point(89, 68);
            this.txtScoreTotal.Name = "txtScoreTotal";
            this.txtScoreTotal.ReadOnly = true;
            this.txtScoreTotal.Size = new System.Drawing.Size(100, 20);
            this.txtScoreTotal.TabIndex = 8;
            // 
            // txtScoreCount
            // 
            this.txtScoreCount.Location = new System.Drawing.Point(89, 100);
            this.txtScoreCount.Name = "txtScoreCount";
            this.txtScoreCount.ReadOnly = true;
            this.txtScoreCount.Size = new System.Drawing.Size(100, 20);
            this.txtScoreCount.TabIndex = 9;
            // 
            // txtAvg
            // 
            this.txtAvg.Location = new System.Drawing.Point(89, 131);
            this.txtAvg.Name = "txtAvg";
            this.txtAvg.ReadOnly = true;
            this.txtAvg.Size = new System.Drawing.Size(100, 20);
            this.txtAvg.TabIndex = 10;
            // 
            // btnDisplayScores
            // 
            this.btnDisplayScores.Location = new System.Drawing.Point(224, 86);
            this.btnDisplayScores.Name = "btnDisplayScores";
            this.btnDisplayScores.Size = new System.Drawing.Size(75, 34);
            this.btnDisplayScores.TabIndex = 11;
            this.btnDisplayScores.Text = "Display Scores";
            this.btnDisplayScores.UseVisualStyleBackColor = true;
            this.btnDisplayScores.Click += new System.EventHandler(this.btnDisplayScores_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(333, 209);
            this.Controls.Add(this.btnDisplayScores);
            this.Controls.Add(this.txtAvg);
            this.Controls.Add(this.txtScoreCount);
            this.Controls.Add(this.txtScoreTotal);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.btnAdd);
            this.Controls.Add(this.btnClrScores);
            this.Controls.Add(this.lblAverage);
            this.Controls.Add(this.lblScoreCount);
            this.Controls.Add(this.lblScoreTotal);
            this.Controls.Add(this.lblScore);
            this.Name = "Form1";
            this.Text = "Score Calculator";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblScore;
        private System.Windows.Forms.Label lblScoreTotal;
        private System.Windows.Forms.Label lblScoreCount;
        private System.Windows.Forms.Label lblAverage;
        private System.Windows.Forms.Button btnClrScores;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.TextBox txtScore;
        private System.Windows.Forms.TextBox txtScoreTotal;
        private System.Windows.Forms.TextBox txtScoreCount;
        private System.Windows.Forms.TextBox txtAvg;
        private System.Windows.Forms.Button btnDisplayScores;
    }
}

