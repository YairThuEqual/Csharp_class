
namespace WindowsFormsApp1.simple_project
{
    partial class frm_customer_register
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
            this.label5 = new System.Windows.Forms.Label();
            this.linlbl_alreadyaccount = new System.Windows.Forms.LinkLabel();
            this.btn_signup = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_confirm_password = new System.Windows.Forms.TextBox();
            this.txt_password = new System.Windows.Forms.TextBox();
            this.txt_email = new System.Windows.Forms.TextBox();
            this.txt_user_name = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(311, 62);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(191, 32);
            this.label5.TabIndex = 21;
            this.label5.Text = "Try  Hack Me";
            // 
            // linlbl_alreadyaccount
            // 
            this.linlbl_alreadyaccount.AutoSize = true;
            this.linlbl_alreadyaccount.Location = new System.Drawing.Point(491, 387);
            this.linlbl_alreadyaccount.Name = "linlbl_alreadyaccount";
            this.linlbl_alreadyaccount.Size = new System.Drawing.Size(130, 20);
            this.linlbl_alreadyaccount.TabIndex = 20;
            this.linlbl_alreadyaccount.TabStop = true;
            this.linlbl_alreadyaccount.Text = "Already_Account";
            this.linlbl_alreadyaccount.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linlbl_alreadyaccount_LinkClicked);
            // 
            // btn_signup
            // 
            this.btn_signup.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_signup.Location = new System.Drawing.Point(326, 445);
            this.btn_signup.Name = "btn_signup";
            this.btn_signup.Size = new System.Drawing.Size(166, 44);
            this.btn_signup.TabIndex = 19;
            this.btn_signup.Text = "Signup";
            this.btn_signup.UseVisualStyleBackColor = true;
            this.btn_signup.Click += new System.EventHandler(this.btn_signup_Click_1);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(181, 337);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(214, 26);
            this.label4.TabIndex = 18;
            this.label4.Text = "Confirm Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(181, 276);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(123, 26);
            this.label3.TabIndex = 17;
            this.label3.Text = "Password:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(181, 215);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 26);
            this.label2.TabIndex = 16;
            this.label2.Text = "Email:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(181, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(135, 26);
            this.label1.TabIndex = 15;
            this.label1.Text = "User name:";
            // 
            // txt_confirm_password
            // 
            this.txt_confirm_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_confirm_password.Location = new System.Drawing.Point(428, 331);
            this.txt_confirm_password.Name = "txt_confirm_password";
            this.txt_confirm_password.PasswordChar = '*';
            this.txt_confirm_password.Size = new System.Drawing.Size(193, 32);
            this.txt_confirm_password.TabIndex = 14;
            // 
            // txt_password
            // 
            this.txt_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_password.Location = new System.Drawing.Point(428, 270);
            this.txt_password.Name = "txt_password";
            this.txt_password.Size = new System.Drawing.Size(193, 32);
            this.txt_password.TabIndex = 13;
            // 
            // txt_email
            // 
            this.txt_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_email.Location = new System.Drawing.Point(428, 212);
            this.txt_email.Name = "txt_email";
            this.txt_email.Size = new System.Drawing.Size(193, 32);
            this.txt_email.TabIndex = 12;
            // 
            // txt_user_name
            // 
            this.txt_user_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_user_name.Location = new System.Drawing.Point(428, 159);
            this.txt_user_name.Name = "txt_user_name";
            this.txt_user_name.Size = new System.Drawing.Size(193, 32);
            this.txt_user_name.TabIndex = 11;
            // 
            // frm_customer_register
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 516);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linlbl_alreadyaccount);
            this.Controls.Add(this.btn_signup);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_confirm_password);
            this.Controls.Add(this.txt_password);
            this.Controls.Add(this.txt_email);
            this.Controls.Add(this.txt_user_name);
            this.Name = "frm_customer_register";
            this.Text = "frm_customer_register";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.LinkLabel linlbl_alreadyaccount;
        private System.Windows.Forms.Button btn_signup;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_confirm_password;
        private System.Windows.Forms.TextBox txt_password;
        private System.Windows.Forms.TextBox txt_email;
        private System.Windows.Forms.TextBox txt_user_name;
    }
}