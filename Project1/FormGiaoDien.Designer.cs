namespace Project1
{
    partial class FormGiaoDien
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormGiaoDien));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ButtonTiepTuc = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.CheckBoxTangASCII = new System.Windows.Forms.CheckBox();
            this.CheckBoxDaoNguocChuoi = new System.Windows.Forms.CheckBox();
            this.CheckBoxGoTiengViet = new System.Windows.Forms.CheckBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(497, 55);
            this.label1.TabIndex = 0;
            this.label1.Text = "QAKeyboard Software";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label2.Location = new System.Drawing.Point(17, 93);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Chọn chức năng";
            // 
            // ButtonTiepTuc
            // 
            this.ButtonTiepTuc.Location = new System.Drawing.Point(125, 191);
            this.ButtonTiepTuc.Name = "ButtonTiepTuc";
            this.ButtonTiepTuc.Size = new System.Drawing.Size(75, 23);
            this.ButtonTiepTuc.TabIndex = 3;
            this.ButtonTiepTuc.Text = "Tiếp tục >>";
            this.ButtonTiepTuc.UseVisualStyleBackColor = true;
            this.ButtonTiepTuc.Click += new System.EventHandler(this.ButtonTiepTuc_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(356, 230);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(153, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Designed by Quang Anh Pham";
            // 
            // CheckBoxTangASCII
            // 
            this.CheckBoxTangASCII.AutoSize = true;
            this.CheckBoxTangASCII.Location = new System.Drawing.Point(24, 125);
            this.CheckBoxTangASCII.Name = "CheckBoxTangASCII";
            this.CheckBoxTangASCII.Size = new System.Drawing.Size(107, 17);
            this.CheckBoxTangASCII.TabIndex = 6;
            this.CheckBoxTangASCII.Text = "Mã ASCII cộng 1";
            this.CheckBoxTangASCII.UseVisualStyleBackColor = true;
            // 
            // CheckBoxDaoNguocChuoi
            // 
            this.CheckBoxDaoNguocChuoi.AutoSize = true;
            this.CheckBoxDaoNguocChuoi.Location = new System.Drawing.Point(24, 148);
            this.CheckBoxDaoNguocChuoi.Name = "CheckBoxDaoNguocChuoi";
            this.CheckBoxDaoNguocChuoi.Size = new System.Drawing.Size(176, 17);
            this.CheckBoxDaoNguocChuoi.TabIndex = 7;
            this.CheckBoxDaoNguocChuoi.Text = "Đảo ngược chuỗi kí tự đã nhập";
            this.CheckBoxDaoNguocChuoi.UseVisualStyleBackColor = true;
            // 
            // CheckBoxGoTiengViet
            // 
            this.CheckBoxGoTiengViet.AutoSize = true;
            this.CheckBoxGoTiengViet.Location = new System.Drawing.Point(24, 171);
            this.CheckBoxGoTiengViet.Name = "CheckBoxGoTiengViet";
            this.CheckBoxGoTiengViet.Size = new System.Drawing.Size(91, 17);
            this.CheckBoxGoTiengViet.TabIndex = 8;
            this.CheckBoxGoTiengViet.Text = "Gõ Tiếng Việt";
            this.CheckBoxGoTiengViet.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.BackgroundImage")));
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.pictureBox1.InitialImage = ((System.Drawing.Image)(resources.GetObject("pictureBox1.InitialImage")));
            this.pictureBox1.Location = new System.Drawing.Point(220, 93);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(290, 121);
            this.pictureBox1.TabIndex = 9;
            this.pictureBox1.TabStop = false;
            // 
            // FormGiaoDien
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 252);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.CheckBoxGoTiengViet);
            this.Controls.Add(this.CheckBoxDaoNguocChuoi);
            this.Controls.Add(this.CheckBoxTangASCII);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ButtonTiepTuc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "FormGiaoDien";
            this.Text = "Chương trình gõ";
            this.Load += new System.EventHandler(this.FormGiaoDien_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ButtonTiepTuc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox CheckBoxTangASCII;
        private System.Windows.Forms.CheckBox CheckBoxDaoNguocChuoi;
        private System.Windows.Forms.CheckBox CheckBoxGoTiengViet;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

