
namespace WindowsFormsApp1.kattit
{
    partial class frm_three
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btn_click = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btn_one_click = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_x = new System.Windows.Forms.TextBox();
            this.txt_y = new System.Windows.Forms.TextBox();
            this.txt_z = new System.Windows.Forms.TextBox();
            this.btn_input_click = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(97, 155);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(108, 221);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(75, 23);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "button1";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(97, 109);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 26);
            this.textBox2.TabIndex = 2;
            // 
            // btn_one_click
            // 
            this.btn_one_click.Location = new System.Drawing.Point(307, 220);
            this.btn_one_click.Name = "btn_one_click";
            this.btn_one_click.Size = new System.Drawing.Size(108, 39);
            this.btn_one_click.TabIndex = 3;
            this.btn_one_click.Text = "One click";
            this.btn_one_click.UseVisualStyleBackColor = true;
            this.btn_one_click.Click += new System.EventHandler(this.btn_one_click_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(343, 93);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "label";
            // 
            // txt_x
            // 
            this.txt_x.Location = new System.Drawing.Point(566, 86);
            this.txt_x.Name = "txt_x";
            this.txt_x.Size = new System.Drawing.Size(100, 26);
            this.txt_x.TabIndex = 5;
            // 
            // txt_y
            // 
            this.txt_y.Location = new System.Drawing.Point(566, 144);
            this.txt_y.Name = "txt_y";
            this.txt_y.Size = new System.Drawing.Size(100, 26);
            this.txt_y.TabIndex = 6;
            // 
            // txt_z
            // 
            this.txt_z.Location = new System.Drawing.Point(566, 202);
            this.txt_z.Name = "txt_z";
            this.txt_z.Size = new System.Drawing.Size(100, 26);
            this.txt_z.TabIndex = 7;
            // 
            // btn_input_click
            // 
            this.btn_input_click.Location = new System.Drawing.Point(558, 269);
            this.btn_input_click.Name = "btn_input_click";
            this.btn_input_click.Size = new System.Drawing.Size(108, 39);
            this.btn_input_click.TabIndex = 8;
            this.btn_input_click.Text = "click here";
            this.btn_input_click.UseVisualStyleBackColor = true;
            this.btn_input_click.Click += new System.EventHandler(this.btn_input_click_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(710, 86);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "label2";
            // 
            // frm_three
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn_input_click);
            this.Controls.Add(this.txt_z);
            this.Controls.Add(this.txt_y);
            this.Controls.Add(this.txt_x);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_one_click);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.textBox1);
            this.Name = "frm_three";
            this.Text = "Form3";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_click;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btn_one_click;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txt_x;
        private System.Windows.Forms.TextBox txt_y;
        private System.Windows.Forms.TextBox txt_z;
        private System.Windows.Forms.Button btn_input_click;
        private System.Windows.Forms.Label label2;
    }
}