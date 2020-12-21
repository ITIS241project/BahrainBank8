namespace BahrainBank
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
            this.label_CardNo = new System.Windows.Forms.Label();
            this.label_Password = new System.Windows.Forms.Label();
            this.textBox_UserName = new System.Windows.Forms.TextBox();
            this.textBox_Password = new System.Windows.Forms.TextBox();
            this.button_LogIn = new System.Windows.Forms.Button();
            this.button_register = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_CardNo
            // 
            this.label_CardNo.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_CardNo.Location = new System.Drawing.Point(12, 41);
            this.label_CardNo.Name = "label_CardNo";
            this.label_CardNo.Size = new System.Drawing.Size(116, 28);
            this.label_CardNo.TabIndex = 0;
            this.label_CardNo.Text = "User Name :";
            // 
            // label_Password
            // 
            this.label_Password.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Password.Location = new System.Drawing.Point(12, 84);
            this.label_Password.Name = "label_Password";
            this.label_Password.Size = new System.Drawing.Size(116, 28);
            this.label_Password.TabIndex = 1;
            this.label_Password.Text = "Password";
            // 
            // textBox_UserName
            // 
            this.textBox_UserName.BackColor = System.Drawing.Color.Tan;
            this.textBox_UserName.Location = new System.Drawing.Point(134, 41);
            this.textBox_UserName.Name = "textBox_UserName";
            this.textBox_UserName.Size = new System.Drawing.Size(145, 20);
            this.textBox_UserName.TabIndex = 2;
            this.textBox_UserName.TextChanged += new System.EventHandler(this.textBox_UserName_TextChanged);
            // 
            // textBox_Password
            // 
            this.textBox_Password.BackColor = System.Drawing.Color.Tan;
            this.textBox_Password.Location = new System.Drawing.Point(134, 85);
            this.textBox_Password.Name = "textBox_Password";
            this.textBox_Password.Size = new System.Drawing.Size(145, 20);
            this.textBox_Password.TabIndex = 3;
            // 
            // button_LogIn
            // 
            this.button_LogIn.BackColor = System.Drawing.Color.Tan;
            this.button_LogIn.Location = new System.Drawing.Point(85, 146);
            this.button_LogIn.Name = "button_LogIn";
            this.button_LogIn.Size = new System.Drawing.Size(142, 37);
            this.button_LogIn.TabIndex = 4;
            this.button_LogIn.Text = "Log in";
            this.button_LogIn.UseVisualStyleBackColor = false;
            this.button_LogIn.Click += new System.EventHandler(this.button_LogIn_Click);
            // 
            // button_register
            // 
            this.button_register.BackColor = System.Drawing.Color.Tan;
            this.button_register.Location = new System.Drawing.Point(85, 204);
            this.button_register.Name = "button_register";
            this.button_register.Size = new System.Drawing.Size(142, 37);
            this.button_register.TabIndex = 5;
            this.button_register.Text = "Register";
            this.button_register.UseVisualStyleBackColor = false;
            this.button_register.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(328, 293);
            this.Controls.Add(this.button_register);
            this.Controls.Add(this.button_LogIn);
            this.Controls.Add(this.textBox_Password);
            this.Controls.Add(this.textBox_UserName);
            this.Controls.Add(this.label_Password);
            this.Controls.Add(this.label_CardNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        public System.Windows.Forms.Label label_CardNo;
        public System.Windows.Forms.Label label_Password;
        public System.Windows.Forms.TextBox textBox_UserName;
        public System.Windows.Forms.TextBox textBox_Password;
        public System.Windows.Forms.Button button_LogIn;
        public System.Windows.Forms.Button button_register;
    }
}

