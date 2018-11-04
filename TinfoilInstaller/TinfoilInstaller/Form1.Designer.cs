namespace TinfoilInstaller
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
            this.SelectFileBtn = new System.Windows.Forms.Button();
            this.NspLBx = new System.Windows.Forms.ListBox();
            this.button2 = new System.Windows.Forms.Button();
            this.StartBtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // SelectFileBtn
            // 
            this.SelectFileBtn.Location = new System.Drawing.Point(12, 12);
            this.SelectFileBtn.Name = "SelectFileBtn";
            this.SelectFileBtn.Size = new System.Drawing.Size(75, 23);
            this.SelectFileBtn.TabIndex = 0;
            this.SelectFileBtn.Text = "Select file";
            this.SelectFileBtn.UseVisualStyleBackColor = true;
            this.SelectFileBtn.Click += new System.EventHandler(this.SelectFileBtn_Click);
            // 
            // NspLBx
            // 
            this.NspLBx.FormattingEnabled = true;
            this.NspLBx.Location = new System.Drawing.Point(93, 12);
            this.NspLBx.Name = "NspLBx";
            this.NspLBx.Size = new System.Drawing.Size(324, 186);
            this.NspLBx.TabIndex = 1;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 41);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "Select folder";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // StartBtn
            // 
            this.StartBtn.Location = new System.Drawing.Point(12, 175);
            this.StartBtn.Name = "StartBtn";
            this.StartBtn.Size = new System.Drawing.Size(75, 23);
            this.StartBtn.TabIndex = 3;
            this.StartBtn.Text = "Start";
            this.StartBtn.UseVisualStyleBackColor = true;
            this.StartBtn.Click += new System.EventHandler(this.StartBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(429, 219);
            this.Controls.Add(this.StartBtn);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.NspLBx);
            this.Controls.Add(this.SelectFileBtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SelectFileBtn;
        private System.Windows.Forms.ListBox NspLBx;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button StartBtn;
    }
}

