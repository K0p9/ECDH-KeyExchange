namespace Lab03.Bai1
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
            this.buttonClient = new System.Windows.Forms.Button();
            this.buttonSever = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(20, 21);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(105, 28);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "UDP Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonSever
            // 
            this.buttonSever.Location = new System.Drawing.Point(156, 21);
            this.buttonSever.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonSever.Name = "buttonSever";
            this.buttonSever.Size = new System.Drawing.Size(105, 28);
            this.buttonSever.TabIndex = 1;
            this.buttonSever.Text = "UDP Sever";
            this.buttonSever.UseVisualStyleBackColor = true;
            this.buttonSever.Click += new System.EventHandler(this.buttonSever_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 64);
            this.Controls.Add(this.buttonSever);
            this.Controls.Add(this.buttonClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.Load += new System.EventHandler(this.Main_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonSever;
    }
}