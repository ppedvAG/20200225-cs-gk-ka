namespace MyFirstWindowsForm
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
            this.KlickMe1 = new System.Windows.Forms.Button();
            this.KlickMe2 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // KlickMe1
            // 
            this.KlickMe1.Location = new System.Drawing.Point(166, 25);
            this.KlickMe1.Name = "KlickMe1";
            this.KlickMe1.Size = new System.Drawing.Size(93, 42);
            this.KlickMe1.TabIndex = 0;
            this.KlickMe1.Text = "KlickMe1";
            this.KlickMe1.UseVisualStyleBackColor = true;
            this.KlickMe1.Click += new System.EventHandler(this.button1_Click);
            // 
            // KlickMe2
            // 
            this.KlickMe2.Location = new System.Drawing.Point(60, 25);
            this.KlickMe2.Name = "KlickMe2";
            this.KlickMe2.Size = new System.Drawing.Size(88, 42);
            this.KlickMe2.TabIndex = 1;
            this.KlickMe2.Text = "KlickMe2";
            this.KlickMe2.UseVisualStyleBackColor = true;
            this.KlickMe2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1104, 542);
            this.Controls.Add(this.KlickMe2);
            this.Controls.Add(this.KlickMe1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button KlickMe1;
        private System.Windows.Forms.Button KlickMe2;
    }
}

