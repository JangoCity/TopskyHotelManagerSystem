﻿namespace SYS.FormUI
{
    partial class FrmUpLoadNotice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmUpLoadNotice));
            this.UpLoadNotice = new System.Windows.Forms.Button();
            this.pnlUpLoad = new System.Windows.Forms.Panel();
            this.txtNoticePerson = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cboSelectClub = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.rtbNoticeContent = new System.Windows.Forms.RichTextBox();
            this.dtpUpLoadDate = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtNoticeTheme = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtUpLoadNo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpLoad = new System.Windows.Forms.Button();
            this.pnlUpLoad.SuspendLayout();
            this.SuspendLayout();
            // 
            // UpLoadNotice
            // 
            this.UpLoadNotice.BackColor = System.Drawing.Color.DeepSkyBlue;
            this.UpLoadNotice.FlatAppearance.BorderSize = 0;
            this.UpLoadNotice.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.UpLoadNotice.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.UpLoadNotice.Location = new System.Drawing.Point(12, 8);
            this.UpLoadNotice.Name = "UpLoadNotice";
            this.UpLoadNotice.Size = new System.Drawing.Size(103, 23);
            this.UpLoadNotice.TabIndex = 0;
            this.UpLoadNotice.Text = "上传任命公告";
            this.UpLoadNotice.UseVisualStyleBackColor = false;
            this.UpLoadNotice.Click += new System.EventHandler(this.UpLoadNotice_Click);
            // 
            // pnlUpLoad
            // 
            this.pnlUpLoad.Controls.Add(this.txtNoticePerson);
            this.pnlUpLoad.Controls.Add(this.label6);
            this.pnlUpLoad.Controls.Add(this.cboSelectClub);
            this.pnlUpLoad.Controls.Add(this.label4);
            this.pnlUpLoad.Controls.Add(this.btnUpLoad);
            this.pnlUpLoad.Controls.Add(this.rtbNoticeContent);
            this.pnlUpLoad.Controls.Add(this.dtpUpLoadDate);
            this.pnlUpLoad.Controls.Add(this.label3);
            this.pnlUpLoad.Controls.Add(this.txtNoticeTheme);
            this.pnlUpLoad.Controls.Add(this.label2);
            this.pnlUpLoad.Controls.Add(this.txtUpLoadNo);
            this.pnlUpLoad.Controls.Add(this.label1);
            this.pnlUpLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.pnlUpLoad.Location = new System.Drawing.Point(3, 37);
            this.pnlUpLoad.Name = "pnlUpLoad";
            this.pnlUpLoad.Size = new System.Drawing.Size(974, 456);
            this.pnlUpLoad.TabIndex = 1;
            this.pnlUpLoad.Visible = false;
            // 
            // txtNoticePerson
            // 
            this.txtNoticePerson.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtNoticePerson.Location = new System.Drawing.Point(403, 423);
            this.txtNoticePerson.Name = "txtNoticePerson";
            this.txtNoticePerson.Size = new System.Drawing.Size(88, 21);
            this.txtNoticePerson.TabIndex = 11;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label6.Location = new System.Drawing.Point(357, 427);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 15);
            this.label6.TabIndex = 10;
            this.label6.Text = "发布人：";
            // 
            // cboSelectClub
            // 
            this.cboSelectClub.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.cboSelectClub.FormattingEnabled = true;
            this.cboSelectClub.Items.AddRange(new object[] {
            "人力资源管理部"});
            this.cboSelectClub.Location = new System.Drawing.Point(229, 424);
            this.cboSelectClub.Name = "cboSelectClub";
            this.cboSelectClub.Size = new System.Drawing.Size(114, 23);
            this.cboSelectClub.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label4.Location = new System.Drawing.Point(158, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(67, 15);
            this.label4.TabIndex = 8;
            this.label4.Text = "发布部门：";
            // 
            // rtbNoticeContent
            // 
            this.rtbNoticeContent.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.rtbNoticeContent.Location = new System.Drawing.Point(0, 47);
            this.rtbNoticeContent.Name = "rtbNoticeContent";
            this.rtbNoticeContent.Size = new System.Drawing.Size(611, 365);
            this.rtbNoticeContent.TabIndex = 6;
            this.rtbNoticeContent.Text = "";
            // 
            // dtpUpLoadDate
            // 
            this.dtpUpLoadDate.Location = new System.Drawing.Point(505, 14);
            this.dtpUpLoadDate.Name = "dtpUpLoadDate";
            this.dtpUpLoadDate.Size = new System.Drawing.Size(106, 21);
            this.dtpUpLoadDate.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label3.Location = new System.Drawing.Point(424, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 19);
            this.label3.TabIndex = 4;
            this.label3.Text = "发布日期：";
            // 
            // txtNoticeTheme
            // 
            this.txtNoticeTheme.Location = new System.Drawing.Point(273, 14);
            this.txtNoticeTheme.Name = "txtNoticeTheme";
            this.txtNoticeTheme.Size = new System.Drawing.Size(145, 21);
            this.txtNoticeTheme.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label2.Location = new System.Drawing.Point(190, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(89, 19);
            this.label2.TabIndex = 2;
            this.label2.Text = "公告主题：";
            // 
            // txtUpLoadNo
            // 
            this.txtUpLoadNo.Location = new System.Drawing.Point(84, 14);
            this.txtUpLoadNo.Name = "txtUpLoadNo";
            this.txtUpLoadNo.Size = new System.Drawing.Size(100, 21);
            this.txtUpLoadNo.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("华文中宋", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.label1.Location = new System.Drawing.Point(5, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 19);
            this.label1.TabIndex = 0;
            this.label1.Text = "公告编号：";
            // 
            // btnUpLoad
            // 
            this.btnUpLoad.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnUpLoad.BackgroundImage")));
            this.btnUpLoad.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnUpLoad.FlatAppearance.BorderSize = 0;
            this.btnUpLoad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpLoad.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.btnUpLoad.Location = new System.Drawing.Point(497, 422);
            this.btnUpLoad.Name = "btnUpLoad";
            this.btnUpLoad.Size = new System.Drawing.Size(75, 23);
            this.btnUpLoad.TabIndex = 7;
            this.btnUpLoad.Text = "发布";
            this.btnUpLoad.UseVisualStyleBackColor = true;
            this.btnUpLoad.Click += new System.EventHandler(this.btnUpLoad_Click);
            // 
            // FrmUpLoadNotice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SkyBlue;
            this.ClientSize = new System.Drawing.Size(989, 497);
            this.Controls.Add(this.pnlUpLoad);
            this.Controls.Add(this.UpLoadNotice);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUpLoadNotice";
            this.Text = "FrmCashList";
            this.Load += new System.EventHandler(this.FrmUpLoad_Load);
            this.pnlUpLoad.ResumeLayout(false);
            this.pnlUpLoad.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button UpLoadNotice;
        private System.Windows.Forms.Panel pnlUpLoad;
        private System.Windows.Forms.Button btnUpLoad;
        private System.Windows.Forms.RichTextBox rtbNoticeContent;
        private System.Windows.Forms.DateTimePicker dtpUpLoadDate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtNoticeTheme;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtUpLoadNo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboSelectClub;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtNoticePerson;
        private System.Windows.Forms.Label label6;
    }
}