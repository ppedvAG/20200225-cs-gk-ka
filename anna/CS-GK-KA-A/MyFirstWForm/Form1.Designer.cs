namespace MyFirstWForm
{
    partial class btnLeft
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
            this.btnLinks = new System.Windows.Forms.Button();
            this.btnRechts = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnLinks
            // 
            this.btnLinks.Location = new System.Drawing.Point(132, 70);
            this.btnLinks.Name = "btnLinks";
            this.btnLinks.Size = new System.Drawing.Size(108, 56);
            this.btnLinks.TabIndex = 0;
            this.btnLinks.Text = "Button Links";
            this.btnLinks.UseVisualStyleBackColor = true;
            this.btnLinks.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnRechts
            // 
            this.btnRechts.Location = new System.Drawing.Point(375, 70);
            this.btnRechts.Name = "btnRechts";
            this.btnRechts.Size = new System.Drawing.Size(113, 56);
            this.btnRechts.TabIndex = 1;
            this.btnRechts.Text = "Button Rechts";
            this.btnRechts.UseVisualStyleBackColor = true;
            this.btnRechts.Click += new System.EventHandler(this.btnRechts_Click);
            // 
            // btnLeft
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnRechts);
            this.Controls.Add(this.btnLinks);
            this.Name = "btnLeft";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnLinks;
        private System.Windows.Forms.Button btnRechts;
    }
}

