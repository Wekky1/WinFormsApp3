
namespace WinFormsApp3
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.TxtFirst = new System.Windows.Forms.TextBox();
            this.TxtSecond = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(130, 6);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(171, 75);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // TxtFirst
            // 
            this.TxtFirst.Location = new System.Drawing.Point(12, 12);
            this.TxtFirst.Name = "TxtFirst";
            this.TxtFirst.Size = new System.Drawing.Size(84, 23);
            this.TxtFirst.TabIndex = 1;
            // 
            // TxtSecond
            // 
            this.TxtSecond.Location = new System.Drawing.Point(12, 58);
            this.TxtSecond.Name = "TxtSecond";
            this.TxtSecond.Size = new System.Drawing.Size(84, 23);
            this.TxtSecond.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(353, 113);
            this.Controls.Add(this.TxtSecond);
            this.Controls.Add(this.TxtFirst);
            this.Controls.Add(this.button1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox TxtFirst;
        private System.Windows.Forms.TextBox TxtSecond;
    }
}

