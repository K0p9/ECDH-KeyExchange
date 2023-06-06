namespace Lab03.Bai4
{
    partial class Options
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
            this.buttonServer = new System.Windows.Forms.Button();
            this.buttonClient = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonServer
            // 
            this.buttonServer.Location = new System.Drawing.Point(143, 25);
            this.buttonServer.Margin = new System.Windows.Forms.Padding(2);
            this.buttonServer.Name = "buttonServer";
            this.buttonServer.Size = new System.Drawing.Size(79, 44);
            this.buttonServer.TabIndex = 5;
            this.buttonServer.Text = "Server";
            this.buttonServer.UseVisualStyleBackColor = true;
            this.buttonServer.Click += new System.EventHandler(this.buttonServer_Click);
            // 
            // buttonClient
            // 
            this.buttonClient.Location = new System.Drawing.Point(33, 25);
            this.buttonClient.Margin = new System.Windows.Forms.Padding(2);
            this.buttonClient.Name = "buttonClient";
            this.buttonClient.Size = new System.Drawing.Size(79, 44);
            this.buttonClient.TabIndex = 4;
            this.buttonClient.Text = "Client";
            this.buttonClient.UseVisualStyleBackColor = true;
            this.buttonClient.Click += new System.EventHandler(this.buttonClient_Click);
            // 
            // Options
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(256, 92);
            this.Controls.Add(this.buttonServer);
            this.Controls.Add(this.buttonClient);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Options";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Bai 4";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonServer;
        private System.Windows.Forms.Button buttonClient;
    }
}