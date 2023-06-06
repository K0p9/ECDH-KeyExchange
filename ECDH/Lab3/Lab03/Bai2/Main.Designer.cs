namespace Lab03.Bai2
{
    partial class Main
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
            this.buttonListen = new System.Windows.Forms.Button();
            this.richTextBox = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonListen
            // 
            this.buttonListen.Location = new System.Drawing.Point(431, 10);
            this.buttonListen.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonListen.Name = "buttonListen";
            this.buttonListen.Size = new System.Drawing.Size(84, 32);
            this.buttonListen.TabIndex = 1;
            this.buttonListen.Text = "Listen";
            this.buttonListen.UseVisualStyleBackColor = true;
            this.buttonListen.Click += new System.EventHandler(this.buttonListen_Click);
            // 
            // richTextBox
            // 
            this.richTextBox.Location = new System.Drawing.Point(9, 50);
            this.richTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.richTextBox.Name = "richTextBox";
            this.richTextBox.Size = new System.Drawing.Size(507, 340);
            this.richTextBox.TabIndex = 3;
            this.richTextBox.Text = "";
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(526, 398);
            this.Controls.Add(this.richTextBox);
            this.Controls.Add(this.buttonListen);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bai2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button buttonListen;
        private System.Windows.Forms.RichTextBox richTextBox;
    }
}