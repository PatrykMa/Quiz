namespace quiz
{
    partial class Viev
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
            this.questions1 = new quiz.Questions();
            this.SuspendLayout();
            // 
            // questions1
            // 
            this.questions1.Location = new System.Drawing.Point(12, 12);
            this.questions1.Name = "questions1";
            this.questions1.Size = new System.Drawing.Size(329, 275);
            this.questions1.TabIndex = 0;
            // 
            // Viev
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(358, 302);
            this.Controls.Add(this.questions1);
            this.Name = "Viev";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private Questions questions1;
    }
}

