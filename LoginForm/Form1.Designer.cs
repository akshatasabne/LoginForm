namespace LoginForm
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
            this.lableusername = new System.Windows.Forms.Label();
            this.lablePassward = new System.Windows.Forms.Label();
            this.Login = new System.Windows.Forms.Button();
            this.cancel = new System.Windows.Forms.Button();
            this.Passward = new System.Windows.Forms.TextBox();
            this.UserName = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lableusername
            // 
            this.lableusername.AutoSize = true;
            this.lableusername.Location = new System.Drawing.Point(90, 61);
            this.lableusername.Name = "lableusername";
            this.lableusername.Size = new System.Drawing.Size(73, 16);
            this.lableusername.TabIndex = 0;
            this.lableusername.Text = "UserName";
            this.lableusername.Click += new System.EventHandler(this.label1_Click);
            // 
            // lablePassward
            // 
            this.lablePassward.AutoSize = true;
            this.lablePassward.Location = new System.Drawing.Point(90, 128);
            this.lablePassward.Name = "lablePassward";
            this.lablePassward.Size = new System.Drawing.Size(67, 16);
            this.lablePassward.TabIndex = 1;
            this.lablePassward.Text = "Passward";
            this.lablePassward.Click += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // Login
            // 
            this.Login.Location = new System.Drawing.Point(172, 214);
            this.Login.Name = "Login";
            this.Login.Size = new System.Drawing.Size(75, 33);
            this.Login.TabIndex = 2;
            this.Login.Text = "Login";
            this.Login.UseVisualStyleBackColor = true;
            this.Login.Click += new System.EventHandler(this.button1_Click);
            // 
            // cancel
            // 
            this.cancel.Location = new System.Drawing.Point(308, 214);
            this.cancel.Name = "cancel";
            this.cancel.Size = new System.Drawing.Size(75, 33);
            this.cancel.TabIndex = 3;
            this.cancel.Text = "cancel";
            this.cancel.UseVisualStyleBackColor = true;
            this.cancel.Click += new System.EventHandler(this.button2_Click);
            // 
            // Passward
            // 
            this.Passward.Location = new System.Drawing.Point(230, 128);
            this.Passward.Name = "Passward";
            this.Passward.Size = new System.Drawing.Size(172, 22);
            this.Passward.TabIndex = 5;
            this.Passward.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // UserName
            // 
            this.UserName.Location = new System.Drawing.Point(230, 61);
            this.UserName.Name = "UserName";
            this.UserName.Size = new System.Drawing.Size(172, 22);
            this.UserName.TabIndex = 6;
            this.UserName.TextChanged += new System.EventHandler(this.textBox1_TextChanged_1);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(621, 311);
            this.Controls.Add(this.UserName);
            this.Controls.Add(this.Passward);
            this.Controls.Add(this.cancel);
            this.Controls.Add(this.Login);
            this.Controls.Add(this.lablePassward);
            this.Controls.Add(this.lableusername);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lableusername;
        private System.Windows.Forms.Label lablePassward;
        private System.Windows.Forms.Button Login;
        private System.Windows.Forms.Button cancel;
        private System.Windows.Forms.TextBox Passward;
        private System.Windows.Forms.TextBox UserName;
    }
}

