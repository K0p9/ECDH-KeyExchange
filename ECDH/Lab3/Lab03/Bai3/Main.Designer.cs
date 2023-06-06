namespace Lab03.Bai3
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
            this.buttonServer = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(32, 27);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(111, 66);
            this.buttonClient.TabIndex = 0;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // buttonServer
            // 
            this.buttonServer.Location = new System.Drawing.Point(172, 27);
            this.buttonServer.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(111, 66);
            this.buttonServer.TabIndex = 1;
            this.buttonServer.Text = "Server";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(317, 119);
            this.Controls.Add(this.buttonServer);
            this.Controls.Add(this.buttonClient);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Main";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonClient;
        private System.Windows.Forms.Button buttonServer;
    }
}