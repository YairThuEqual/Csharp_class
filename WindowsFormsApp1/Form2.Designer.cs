
namespace WindowsFormsApp1
{
    partial class Frm_reset
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
            this.count = new System.Windows.Forms.Label();
            this.btn_increase = new System.Windows.Forms.Button();
            this.rbtn_male = new System.Windows.Forms.RadioButton();
            this.rbtn_famale = new System.Windows.Forms.RadioButton();
            this.rbtn_other = new System.Windows.Forms.RadioButton();
            this.btn_choose = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // count
            // 
            this.count.AutoSize = true;
            this.count.Location = new System.Drawing.Point(70, 97);
            this.count.Name = "count";
            this.count.Size = new System.Drawing.Size(42, 20);
            this.count.TabIndex = 0;
            this.count.Text = "label";
            // 
            // btn_increase
            // 
            this.btn_increase.Location = new System.Drawing.Point(65, 159);
            this.btn_increase.Name = "btn_increase";
            this.btn_increase.Size = new System.Drawing.Size(107, 37);
            this.btn_increase.TabIndex = 1;
            this.btn_increase.Text = "reset";
            this.btn_increase.UseVisualStyleBackColor = true;
            this.btn_increase.Click += new System.EventHandler(this.btn_increase_Click);
            // 
            // rbtn_male
            // 
            this.rbtn_male.AutoSize = true;
            this.rbtn_male.Location = new System.Drawing.Point(302, 113);
            this.rbtn_male.Name = "rbtn_male";
            this.rbtn_male.Size = new System.Drawing.Size(68, 24);
            this.rbtn_male.TabIndex = 2;
            this.rbtn_male.TabStop = true;
            this.rbtn_male.Text = "male";
            this.rbtn_male.UseVisualStyleBackColor = true;
            // 
            // rbtn_famale
            // 
            this.rbtn_famale.AutoSize = true;
            this.rbtn_famale.Location = new System.Drawing.Point(302, 171);
            this.rbtn_famale.Name = "rbtn_famale";
            this.rbtn_famale.Size = new System.Drawing.Size(82, 24);
            this.rbtn_famale.TabIndex = 3;
            this.rbtn_famale.TabStop = true;
            this.rbtn_famale.Text = "female";
            this.rbtn_famale.UseVisualStyleBackColor = true;
            // 
            // rbtn_other
            // 
            this.rbtn_other.AutoSize = true;
            this.rbtn_other.Location = new System.Drawing.Point(302, 229);
            this.rbtn_other.Name = "rbtn_other";
            this.rbtn_other.Size = new System.Drawing.Size(71, 24);
            this.rbtn_other.TabIndex = 4;
            this.rbtn_other.TabStop = true;
            this.rbtn_other.Text = "other";
            this.rbtn_other.UseVisualStyleBackColor = true;
            // 
            // btn_choose
            // 
            this.btn_choose.Location = new System.Drawing.Point(302, 281);
            this.btn_choose.Name = "btn_choose";
            this.btn_choose.Size = new System.Drawing.Size(102, 39);
            this.btn_choose.TabIndex = 5;
            this.btn_choose.Text = "choose";
            this.btn_choose.UseVisualStyleBackColor = true;
            this.btn_choose.Click += new System.EventHandler(this.btn_choose_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(557, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 6;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
         //   this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_reset
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_choose);
            this.Controls.Add(this.rbtn_other);
            this.Controls.Add(this.rbtn_famale);
            this.Controls.Add(this.rbtn_male);
            this.Controls.Add(this.btn_increase);
            this.Controls.Add(this.count);
            this.Name = "Frm_reset";
            this.Text = "Form2";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label count;
        private System.Windows.Forms.Button btn_increase;
        private System.Windows.Forms.RadioButton rbtn_male;
        private System.Windows.Forms.RadioButton rbtn_famale;
        private System.Windows.Forms.RadioButton rbtn_other;
        private System.Windows.Forms.Button btn_choose;
        private System.Windows.Forms.Button button1;
    }
}