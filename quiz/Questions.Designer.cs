namespace quiz
{
    partial class Questions
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
            this.textBoxQuestion = new System.Windows.Forms.TextBox();
            this.textBoxAnswer1 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer2 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer3 = new System.Windows.Forms.TextBox();
            this.textBoxAnswer4 = new System.Windows.Forms.TextBox();
            this.checkBoxAnswer1 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer2 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer3 = new System.Windows.Forms.CheckBox();
            this.checkBoxAnswer4 = new System.Windows.Forms.CheckBox();
            this.buttonSaveOpen = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.textBoxQname = new System.Windows.Forms.TextBox();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // textBoxQuestion
            // 
            this.textBoxQuestion.Location = new System.Drawing.Point(22, 59);
            this.textBoxQuestion.Name = "textBoxQuestion";
            this.textBoxQuestion.Size = new System.Drawing.Size(265, 20);
            this.textBoxQuestion.TabIndex = 1;
            // 
            // textBoxAnswer1
            // 
            this.textBoxAnswer1.Location = new System.Drawing.Point(22, 94);
            this.textBoxAnswer1.Name = "textBoxAnswer1";
            this.textBoxAnswer1.Size = new System.Drawing.Size(230, 20);
            this.textBoxAnswer1.TabIndex = 2;
            // 
            // textBoxAnswer2
            // 
            this.textBoxAnswer2.Location = new System.Drawing.Point(22, 132);
            this.textBoxAnswer2.Name = "textBoxAnswer2";
            this.textBoxAnswer2.Size = new System.Drawing.Size(230, 20);
            this.textBoxAnswer2.TabIndex = 3;
            // 
            // textBoxAnswer3
            // 
            this.textBoxAnswer3.Location = new System.Drawing.Point(22, 168);
            this.textBoxAnswer3.Name = "textBoxAnswer3";
            this.textBoxAnswer3.Size = new System.Drawing.Size(230, 20);
            this.textBoxAnswer3.TabIndex = 4;
            // 
            // textBoxAnswer4
            // 
            this.textBoxAnswer4.Location = new System.Drawing.Point(22, 203);
            this.textBoxAnswer4.Name = "textBoxAnswer4";
            this.textBoxAnswer4.Size = new System.Drawing.Size(230, 20);
            this.textBoxAnswer4.TabIndex = 5;
            // 
            // checkBoxAnswer1
            // 
            this.checkBoxAnswer1.AutoSize = true;
            this.checkBoxAnswer1.Location = new System.Drawing.Point(272, 100);
            this.checkBoxAnswer1.Name = "checkBoxAnswer1";
            this.checkBoxAnswer1.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer1.TabIndex = 6;
            this.checkBoxAnswer1.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer2
            // 
            this.checkBoxAnswer2.AutoSize = true;
            this.checkBoxAnswer2.Location = new System.Drawing.Point(272, 138);
            this.checkBoxAnswer2.Name = "checkBoxAnswer2";
            this.checkBoxAnswer2.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer2.TabIndex = 7;
            this.checkBoxAnswer2.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer3
            // 
            this.checkBoxAnswer3.AutoSize = true;
            this.checkBoxAnswer3.Location = new System.Drawing.Point(272, 174);
            this.checkBoxAnswer3.Name = "checkBoxAnswer3";
            this.checkBoxAnswer3.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer3.TabIndex = 8;
            this.checkBoxAnswer3.UseVisualStyleBackColor = true;
            // 
            // checkBoxAnswer4
            // 
            this.checkBoxAnswer4.AutoSize = true;
            this.checkBoxAnswer4.Location = new System.Drawing.Point(272, 209);
            this.checkBoxAnswer4.Name = "checkBoxAnswer4";
            this.checkBoxAnswer4.Size = new System.Drawing.Size(15, 14);
            this.checkBoxAnswer4.TabIndex = 9;
            this.checkBoxAnswer4.UseVisualStyleBackColor = true;
            // 
            // buttonSaveOpen
            // 
            this.buttonSaveOpen.Location = new System.Drawing.Point(133, 243);
            this.buttonSaveOpen.Name = "buttonSaveOpen";
            this.buttonSaveOpen.Size = new System.Drawing.Size(75, 23);
            this.buttonSaveOpen.TabIndex = 12;
            this.buttonSaveOpen.Text = "Save";
            this.buttonSaveOpen.UseVisualStyleBackColor = true;
            this.buttonSaveOpen.Click += new System.EventHandler(this.buttonSaveOpen_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // textBoxQname
            // 
            this.textBoxQname.Location = new System.Drawing.Point(22, 24);
            this.textBoxQname.Name = "textBoxQname";
            this.textBoxQname.Size = new System.Drawing.Size(265, 20);
            this.textBoxQname.TabIndex = 0;
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(22, 243);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 11;
            this.buttonBack.Text = "<-";
            this.buttonBack.UseVisualStyleBackColor = true;
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(246, 243);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(75, 23);
            this.buttonForward.TabIndex = 10;
            this.buttonForward.Text = "->";
            this.buttonForward.UseVisualStyleBackColor = true;
            // 
            // Questions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.buttonForward);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.textBoxQname);
            this.Controls.Add(this.buttonSaveOpen);
            this.Controls.Add(this.checkBoxAnswer4);
            this.Controls.Add(this.checkBoxAnswer3);
            this.Controls.Add(this.checkBoxAnswer2);
            this.Controls.Add(this.checkBoxAnswer1);
            this.Controls.Add(this.textBoxAnswer4);
            this.Controls.Add(this.textBoxAnswer3);
            this.Controls.Add(this.textBoxAnswer2);
            this.Controls.Add(this.textBoxAnswer1);
            this.Controls.Add(this.textBoxQuestion);
            this.Name = "Questions";
            this.Size = new System.Drawing.Size(329, 275);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxQuestion;
        private System.Windows.Forms.TextBox textBoxAnswer1;
        private System.Windows.Forms.TextBox textBoxAnswer2;
        private System.Windows.Forms.TextBox textBoxAnswer3;
        private System.Windows.Forms.TextBox textBoxAnswer4;
        private System.Windows.Forms.CheckBox checkBoxAnswer1;
        private System.Windows.Forms.CheckBox checkBoxAnswer2;
        private System.Windows.Forms.CheckBox checkBoxAnswer3;
        private System.Windows.Forms.CheckBox checkBoxAnswer4;
        private System.Windows.Forms.Button buttonSaveOpen;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox textBoxQname;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonForward;
    }
}
