namespace _2_TCP
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
            this.txt_GelenMesajlar = new System.Windows.Forms.TextBox();
            this.btn_baslat = new System.Windows.Forms.Button();
            this.txt_Port = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // txt_GelenMesajlar
            // 
            this.txt_GelenMesajlar.Location = new System.Drawing.Point(23, 130);
            this.txt_GelenMesajlar.Multiline = true;
            this.txt_GelenMesajlar.Name = "txt_GelenMesajlar";
            this.txt_GelenMesajlar.Size = new System.Drawing.Size(264, 259);
            this.txt_GelenMesajlar.TabIndex = 0;
            // 
            // btn_baslat
            // 
            this.btn_baslat.Location = new System.Drawing.Point(299, 33);
            this.btn_baslat.Name = "btn_baslat";
            this.btn_baslat.Size = new System.Drawing.Size(88, 29);
            this.btn_baslat.TabIndex = 1;
            this.btn_baslat.Text = "BAŞLAT";
            this.btn_baslat.UseVisualStyleBackColor = true;
            this.btn_baslat.Click += new System.EventHandler(this.btn_baslat_Click);
            // 
            // txt_Port
            // 
            this.txt_Port.Location = new System.Drawing.Point(170, 36);
            this.txt_Port.Multiline = true;
            this.txt_Port.Name = "txt_Port";
            this.txt_Port.Size = new System.Drawing.Size(117, 50);
            this.txt_Port.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 46);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "PORT";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_Port);
            this.Controls.Add(this.btn_baslat);
            this.Controls.Add(this.txt_GelenMesajlar);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txt_GelenMesajlar;
        private System.Windows.Forms.Button btn_baslat;
        private System.Windows.Forms.TextBox txt_Port;
        private System.Windows.Forms.Label label1;
    }
}

