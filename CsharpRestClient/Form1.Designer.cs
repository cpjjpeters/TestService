namespace CsharpRestClient
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
            this.txtRestURL = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txtRestURL
            // 
            this.txtRestURL.Location = new System.Drawing.Point(171, 56);
            this.txtRestURL.Name = "txtRestURL";
            this.txtRestURL.Size = new System.Drawing.Size(369, 38);
            this.txtRestURL.TabIndex = 0;
            this.txtRestURL.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // txtResponse
            // 
            this.txtResponse.Location = new System.Drawing.Point(171, 145);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtResponse.Size = new System.Drawing.Size(588, 38);
            this.txtResponse.TabIndex = 0;
            this.txtResponse.Text = "C#Rest Client";
            this.txtResponse.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtRestURL);
            this.Name = "Form1";
            this.Text = "C# REST Client";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtRestURL;
        private System.Windows.Forms.TextBox txtResponse;
    }
}

