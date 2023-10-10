namespace if_else_lisboks___örnek_1
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbTek = new System.Windows.Forms.ListBox();
            this.lbCift = new System.Windows.Forms.ListBox();
            this.txtSayi = new System.Windows.Forms.TextBox();
            this.btnEkle = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.Location = new System.Drawing.Point(238, 165);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "ÇİFT SAYILAR";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label2.Location = new System.Drawing.Point(27, 165);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "TEK SAYILAR";
            // 
            // lbTek
            // 
            this.lbTek.BackColor = System.Drawing.Color.RosyBrown;
            this.lbTek.FormattingEnabled = true;
            this.lbTek.Location = new System.Drawing.Point(30, 181);
            this.lbTek.Name = "lbTek";
            this.lbTek.Size = new System.Drawing.Size(159, 251);
            this.lbTek.TabIndex = 2;
            // 
            // lbCift
            // 
            this.lbCift.BackColor = System.Drawing.Color.RosyBrown;
            this.lbCift.FormattingEnabled = true;
            this.lbCift.Location = new System.Drawing.Point(208, 181);
            this.lbCift.Name = "lbCift";
            this.lbCift.Size = new System.Drawing.Size(159, 251);
            this.lbCift.TabIndex = 3;
            // 
            // txtSayi
            // 
            this.txtSayi.BackColor = System.Drawing.Color.Brown;
            this.txtSayi.Location = new System.Drawing.Point(30, 92);
            this.txtSayi.Multiline = true;
            this.txtSayi.Name = "txtSayi";
            this.txtSayi.Size = new System.Drawing.Size(159, 34);
            this.txtSayi.TabIndex = 4;
            // 
            // btnEkle
            // 
            this.btnEkle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.btnEkle.Location = new System.Drawing.Point(219, 92);
            this.btnEkle.Name = "btnEkle";
            this.btnEkle.Size = new System.Drawing.Size(115, 34);
            this.btnEkle.TabIndex = 5;
            this.btnEkle.Text = "EKLE";
            this.btnEkle.UseVisualStyleBackColor = false;
            this.btnEkle.Click += new System.EventHandler(this.btnEkle_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(467, 442);
            this.Controls.Add(this.btnEkle);
            this.Controls.Add(this.txtSayi);
            this.Controls.Add(this.lbCift);
            this.Controls.Add(this.lbTek);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ListBox lbTek;
        private System.Windows.Forms.ListBox lbCift;
        private System.Windows.Forms.TextBox txtSayi;
        private System.Windows.Forms.Button btnEkle;
    }
}

