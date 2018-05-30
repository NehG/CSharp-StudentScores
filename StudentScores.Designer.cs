namespace Assignment1
{
    partial class StudentScores
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
            this.StudentScoresListBox = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.AddNewBtn = new System.Windows.Forms.Button();
            this.UpdateBtn = new System.Windows.Forms.Button();
            this.DeleteBtn = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.ScoreTotalTextBox = new System.Windows.Forms.TextBox();
            this.ScoreCountTextBox = new System.Windows.Forms.TextBox();
            this.AvgTextBox = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // StudentScoresListBox
            // 
            this.StudentScoresListBox.FormattingEnabled = true;
            this.StudentScoresListBox.Items.AddRange(new object[] {
            "NehalGajjar | 95 84 91 92 78",
            "RutviShah | 100 99 98 97",
            "BansariPatel | 100 90 100 90"});
            this.StudentScoresListBox.Location = new System.Drawing.Point(11, 50);
            this.StudentScoresListBox.Name = "StudentScoresListBox";
            this.StudentScoresListBox.Size = new System.Drawing.Size(247, 160);
            this.StudentScoresListBox.TabIndex = 0;
            this.StudentScoresListBox.SelectedIndexChanged += new System.EventHandler(this.StudentScoresListBox_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(11, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(52, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Students:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(111, 233);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Score total:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(104, 258);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(68, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Score count:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(122, 285);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(50, 13);
            this.label4.TabIndex = 4;
            this.label4.Text = "Average:";
            // 
            // AddNewBtn
            // 
            this.AddNewBtn.Location = new System.Drawing.Point(280, 50);
            this.AddNewBtn.Name = "AddNewBtn";
            this.AddNewBtn.Size = new System.Drawing.Size(84, 23);
            this.AddNewBtn.TabIndex = 5;
            this.AddNewBtn.Text = "Add New...";
            this.AddNewBtn.UseVisualStyleBackColor = true;
            this.AddNewBtn.Click += new System.EventHandler(this.AddNewBtn_Click);
            // 
            // UpdateBtn
            // 
            this.UpdateBtn.Location = new System.Drawing.Point(280, 93);
            this.UpdateBtn.Name = "UpdateBtn";
            this.UpdateBtn.Size = new System.Drawing.Size(84, 23);
            this.UpdateBtn.TabIndex = 6;
            this.UpdateBtn.Text = "Update...";
            this.UpdateBtn.UseVisualStyleBackColor = true;
            this.UpdateBtn.Click += new System.EventHandler(this.UpdateBtn_Click);
            // 
            // DeleteBtn
            // 
            this.DeleteBtn.Location = new System.Drawing.Point(280, 143);
            this.DeleteBtn.Name = "DeleteBtn";
            this.DeleteBtn.Size = new System.Drawing.Size(84, 23);
            this.DeleteBtn.TabIndex = 7;
            this.DeleteBtn.Text = "Delete";
            this.DeleteBtn.UseVisualStyleBackColor = true;
            this.DeleteBtn.Click += new System.EventHandler(this.DeleteBtn_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(280, 285);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(84, 23);
            this.ExitBtn.TabIndex = 8;
            this.ExitBtn.Text = "Exit";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // ScoreTotalTextBox
            // 
            this.ScoreTotalTextBox.Location = new System.Drawing.Point(178, 230);
            this.ScoreTotalTextBox.Name = "ScoreTotalTextBox";
            this.ScoreTotalTextBox.Size = new System.Drawing.Size(67, 20);
            this.ScoreTotalTextBox.TabIndex = 9;
            // 
            // ScoreCountTextBox
            // 
            this.ScoreCountTextBox.Location = new System.Drawing.Point(178, 256);
            this.ScoreCountTextBox.Name = "ScoreCountTextBox";
            this.ScoreCountTextBox.Size = new System.Drawing.Size(67, 20);
            this.ScoreCountTextBox.TabIndex = 10;
            // 
            // AvgTextBox
            // 
            this.AvgTextBox.Location = new System.Drawing.Point(178, 282);
            this.AvgTextBox.Name = "AvgTextBox";
            this.AvgTextBox.Size = new System.Drawing.Size(67, 20);
            this.AvgTextBox.TabIndex = 11;
            // 
            // StudentScores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(380, 319);
            this.Controls.Add(this.AvgTextBox);
            this.Controls.Add(this.ScoreCountTextBox);
            this.Controls.Add(this.ScoreTotalTextBox);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.DeleteBtn);
            this.Controls.Add(this.UpdateBtn);
            this.Controls.Add(this.AddNewBtn);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.StudentScoresListBox);
            this.Name = "StudentScores";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Student Scores";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button AddNewBtn;
        private System.Windows.Forms.Button UpdateBtn;
        private System.Windows.Forms.Button DeleteBtn;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.TextBox ScoreTotalTextBox;
        private System.Windows.Forms.TextBox ScoreCountTextBox;
        private System.Windows.Forms.TextBox AvgTextBox;
        internal System.Windows.Forms.ListBox StudentScoresListBox;
    }
}

