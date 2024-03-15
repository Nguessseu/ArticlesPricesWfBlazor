namespace ArticlesPricesWfBlazor
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
            this.blazorWebView1 = new Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView();
            this.button1 = new Button();
            this.SuspendLayout();
            // 
            // blazorWebView1
            // 
            this.blazorWebView1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            this.blazorWebView1.BackColor = Color.Cyan;
            this.blazorWebView1.Location = new Point(182, 0);
            this.blazorWebView1.Margin = new Padding(3, 2, 3, 2);
            this.blazorWebView1.Name = "blazorWebView1";
            this.blazorWebView1.Size = new Size(527, 338);
            this.blazorWebView1.StartPath = "/";
            this.blazorWebView1.TabIndex = 0;
            this.blazorWebView1.Text = "Click me";
            this.blazorWebView1.Click += this.blazorWebView1_Click;
            // 
            // button1
            // 
            this.button1.Location = new Point(12, 26);
            this.button1.Margin = new Padding(3, 2, 3, 2);
            this.button1.Name = "button1";
            this.button1.Size = new Size(153, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += this.button1_ClickAsync;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new SizeF(7F, 15F);
            this.AutoScaleMode = AutoScaleMode.Font;
            this.BackColor = Color.FromArgb(192, 0, 192);
            this.ClientSize = new Size(709, 338);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.blazorWebView1);
            this.Margin = new Padding(3, 2, 3, 2);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
        }

        #endregion

        private Microsoft.AspNetCore.Components.WebView.WindowsForms.BlazorWebView blazorWebView1;
        private Button button1;
    }
}
