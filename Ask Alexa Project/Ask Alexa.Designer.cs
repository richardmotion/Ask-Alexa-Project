namespace Ask_Alexa_Project
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.btnOpen = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.askalexa = new System.Windows.Forms.Label();
            this.developedby = new System.Windows.Forms.Label();
            this.version = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpen
            // 
            this.btnOpen.Location = new System.Drawing.Point(708, 420);
            this.btnOpen.Name = "btnOpen";
            this.btnOpen.Size = new System.Drawing.Size(83, 23);
            this.btnOpen.TabIndex = 0;
            this.btnOpen.Text = "Next Question";
            this.btnOpen.UseVisualStyleBackColor = true;
            this.btnOpen.Click += new System.EventHandler(this.btnOpen_Click);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(153, 232);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(472, 118);
            this.textBox1.TabIndex = 1;
            // 
            // askalexa
            // 
            this.askalexa.AutoSize = true;
            this.askalexa.Font = new System.Drawing.Font("Raleway Light", 70F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.askalexa.Location = new System.Drawing.Point(158, 46);
            this.askalexa.Name = "askalexa";
            this.askalexa.Size = new System.Drawing.Size(467, 110);
            this.askalexa.TabIndex = 2;
            this.askalexa.Text = "Ask Alexa";
            // 
            // developedby
            // 
            this.developedby.AutoSize = true;
            this.developedby.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.developedby.Font = new System.Drawing.Font("Raleway Light", 21F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.developedby.Location = new System.Drawing.Point(187, 156);
            this.developedby.Name = "developedby";
            this.developedby.Size = new System.Drawing.Size(394, 35);
            this.developedby.TabIndex = 3;
            this.developedby.Text = "Developed by Richard Motion";
            // 
            // version
            // 
            this.version.AutoSize = true;
            this.version.Location = new System.Drawing.Point(12, 425);
            this.version.Name = "version";
            this.version.Size = new System.Drawing.Size(60, 13);
            this.version.TabIndex = 4;
            this.version.Text = "Version 1.0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(803, 450);
            this.Controls.Add(this.version);
            this.Controls.Add(this.developedby);
            this.Controls.Add(this.askalexa);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnOpen);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Ask Alexa";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpen;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label askalexa;
        private System.Windows.Forms.Label developedby;
        private System.Windows.Forms.Label version;
    }
}