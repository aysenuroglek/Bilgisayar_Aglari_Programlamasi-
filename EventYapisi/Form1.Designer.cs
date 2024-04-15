namespace EventYapisi
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
            this.txt_Yazı = new System.Windows.Forms.TextBox();
            this.btn_Yeni = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txt_Yazı
            // 
            this.txt_Yazı.Location = new System.Drawing.Point(252, 83);
            this.txt_Yazı.Multiline = true;
            this.txt_Yazı.Name = "txt_Yazı";
            this.txt_Yazı.Size = new System.Drawing.Size(166, 208);
            this.txt_Yazı.TabIndex = 0;
            // 
            // btn_Yeni
            // 
            this.btn_Yeni.Location = new System.Drawing.Point(569, 189);
            this.btn_Yeni.Name = "btn_Yeni";
            this.btn_Yeni.Size = new System.Drawing.Size(75, 23);
            this.btn_Yeni.TabIndex = 1;
            this.btn_Yeni.Text = "button1";
            this.btn_Yeni.UseVisualStyleBackColor = true;
            this.btn_Yeni.Click += new System.EventHandler(this.btn_Yeni_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Yeni);
            this.Controls.Add(this.txt_Yazı);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_Yazı;
        private System.Windows.Forms.Button btn_Yeni;
    }
}

