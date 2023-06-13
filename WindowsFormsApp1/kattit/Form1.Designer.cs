
namespace WindowsFormsApp1.kattit
{
    partial class two_teo
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
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(195, 85);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(230, 26);
            this.textBox1.TabIndex = 0;
            // 
            // btn_click
            // 
            this.btn_click.Location = new System.Drawing.Point(252, 175);
            this.btn_click.Name = "btn_click";
            this.btn_click.Size = new System.Drawing.Size(100, 30);
            this.btn_click.TabIndex = 1;
            this.btn_click.Text = "click";
            this.btn_click.UseVisualStyleBackColor = true;
            this.btn_click.Click += new System.EventHandler(this.btn_click_Click);
            // 
            // two_teo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_click);
            this.Controls.Add(this.textBox1);
            this.Name = "two_teo";
            this.Text = "frm_kittit";
           // this.Load += new System.EventHandler(this.two_teo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btn_click;
    }
}