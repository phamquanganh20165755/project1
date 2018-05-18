namespace Project1
{
    partial class MainForm
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.ButtonStart = new System.Windows.Forms.Button();
            this.ButtonStop = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.NotifyIconThongBao = new System.Windows.Forms.NotifyIcon(this.components);
            this.ButtonLog = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ButtonStart
            // 
            this.ButtonStart.Location = new System.Drawing.Point(66, 139);
            this.ButtonStart.Name = "ButtonStart";
            this.ButtonStart.Size = new System.Drawing.Size(75, 23);
            this.ButtonStart.TabIndex = 0;
            this.ButtonStart.Text = "Start";
            this.ButtonStart.UseVisualStyleBackColor = true;
            this.ButtonStart.Click += new System.EventHandler(this.ButtonStart_Click);
            // 
            // ButtonStop
            // 
            this.ButtonStop.Location = new System.Drawing.Point(173, 139);
            this.ButtonStop.Name = "ButtonStop";
            this.ButtonStop.Size = new System.Drawing.Size(75, 23);
            this.ButtonStop.TabIndex = 1;
            this.ButtonStop.Text = "Stop";
            this.ButtonStop.UseVisualStyleBackColor = true;
            this.ButtonStop.Click += new System.EventHandler(this.ButtonStop_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(163)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(340, 55);
            this.label1.TabIndex = 2;
            this.label1.Text = "Bộ gõ QA Key";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(110, 177);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(242, 13);
            this.label2.TabIndex = 3;
            this.label2.Text = "Designed by Quang Anh Pham. All rights reserved";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(280, 52);
            this.label3.TabIndex = 4;
            this.label3.Text = "Đầu tiên bạn hãy bật một chương trình soạn thảo văn bản\r\nNhấn Start để bắt đầu gõ" +
    " Tiếng Việt\r\nNhấn Stop để kết thúc\r\nNhấn Log để xem các kí tự đã gõ";
            // 
            // NotifyIconThongBao
            // 
            this.NotifyIconThongBao.BalloonTipIcon = System.Windows.Forms.ToolTipIcon.Info;
            this.NotifyIconThongBao.BalloonTipText = "Phần mềm được phát triển bởi designer Phạm Quang Anh\r\n";
            this.NotifyIconThongBao.BalloonTipTitle = "Thông tin";
            this.NotifyIconThongBao.Icon = ((System.Drawing.Icon)(resources.GetObject("NotifyIconThongBao.Icon")));
            this.NotifyIconThongBao.Text = "Bộ gõ QA Key";
            this.NotifyIconThongBao.Visible = true;
            this.NotifyIconThongBao.Click += new System.EventHandler(this.NotifyIconThongBao_Click);
            // 
            // ButtonLog
            // 
            this.ButtonLog.Location = new System.Drawing.Point(276, 139);
            this.ButtonLog.Name = "ButtonLog";
            this.ButtonLog.Size = new System.Drawing.Size(75, 23);
            this.ButtonLog.TabIndex = 5;
            this.ButtonLog.Text = "Log";
            this.ButtonLog.UseVisualStyleBackColor = true;
            this.ButtonLog.Click += new System.EventHandler(this.ButtonLog_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(363, 204);
            this.Controls.Add(this.ButtonLog);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ButtonStop);
            this.Controls.Add(this.ButtonStart);
            this.KeyPreview = true;
            this.Name = "MainForm";
            this.Text = "Chương trình gõ Tiếng Việt";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ButtonStart;
        private System.Windows.Forms.Button ButtonStop;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.NotifyIcon NotifyIconThongBao;
        private System.Windows.Forms.Button ButtonLog;
    }
}

