namespace CNS_Tap_Test
{
    partial class JoinPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(JoinPage));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.duplication_check_btn = new System.Windows.Forms.Button();
            this.idtext_txtbox = new System.Windows.Forms.TextBox();
            this.pwtext_txtbox = new System.Windows.Forms.TextBox();
            this.nametext_txtbox = new System.Windows.Forms.TextBox();
            this.cancel_btn = new System.Windows.Forms.Button();
            this.check_btn = new System.Windows.Forms.Button();
            this.join_page_image = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.join_page_image)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(73, 143);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(16, 12);
            this.label1.TabIndex = 0;
            this.label1.Text = "ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(73, 216);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 12);
            this.label2.TabIndex = 1;
            this.label2.Text = "PW";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(73, 299);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(64, 12);
            this.label3.TabIndex = 2;
            this.label3.Text = "NickName";
            // 
            // duplication_check_btn
            // 
            this.duplication_check_btn.Location = new System.Drawing.Point(273, 138);
            this.duplication_check_btn.Name = "duplication_check_btn";
            this.duplication_check_btn.Size = new System.Drawing.Size(75, 23);
            this.duplication_check_btn.TabIndex = 3;
            this.duplication_check_btn.Text = "중복확인";
            this.duplication_check_btn.UseVisualStyleBackColor = true;
            // 
            // idtext_txtbox
            // 
            this.idtext_txtbox.Location = new System.Drawing.Point(156, 140);
            this.idtext_txtbox.Name = "idtext_txtbox";
            this.idtext_txtbox.Size = new System.Drawing.Size(100, 21);
            this.idtext_txtbox.TabIndex = 4;
            // 
            // pwtext_txtbox
            // 
            this.pwtext_txtbox.Location = new System.Drawing.Point(156, 213);
            this.pwtext_txtbox.Name = "pwtext_txtbox";
            this.pwtext_txtbox.Size = new System.Drawing.Size(100, 21);
            this.pwtext_txtbox.TabIndex = 5;
            // 
            // nametext_txtbox
            // 
            this.nametext_txtbox.Location = new System.Drawing.Point(156, 290);
            this.nametext_txtbox.Name = "nametext_txtbox";
            this.nametext_txtbox.Size = new System.Drawing.Size(100, 21);
            this.nametext_txtbox.TabIndex = 6;
            // 
            // cancel_btn
            // 
            this.cancel_btn.Location = new System.Drawing.Point(85, 355);
            this.cancel_btn.Name = "cancel_btn";
            this.cancel_btn.Size = new System.Drawing.Size(75, 23);
            this.cancel_btn.TabIndex = 7;
            this.cancel_btn.Text = "취소";
            this.cancel_btn.UseVisualStyleBackColor = true;
            // 
            // check_btn
            // 
            this.check_btn.Location = new System.Drawing.Point(215, 355);
            this.check_btn.Name = "check_btn";
            this.check_btn.Size = new System.Drawing.Size(75, 23);
            this.check_btn.TabIndex = 8;
            this.check_btn.Text = "확인";
            this.check_btn.UseVisualStyleBackColor = true;
            // 
            // join_page_image
            // 
            this.join_page_image.ErrorImage = null;
            this.join_page_image.Location = new System.Drawing.Point(0, 0);
            this.join_page_image.Name = "join_page_image";
            this.join_page_image.Size = new System.Drawing.Size(397, 111);
            this.join_page_image.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.join_page_image.TabIndex = 9;
            this.join_page_image.TabStop = false;
            // 
            // JoinPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(396, 447);
            this.Controls.Add(this.join_page_image);
            this.Controls.Add(this.check_btn);
            this.Controls.Add(this.cancel_btn);
            this.Controls.Add(this.nametext_txtbox);
            this.Controls.Add(this.pwtext_txtbox);
            this.Controls.Add(this.idtext_txtbox);
            this.Controls.Add(this.duplication_check_btn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "JoinPage";
            this.Text = "Join";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.JoinPage_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.join_page_image)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button duplication_check_btn;
        private System.Windows.Forms.TextBox idtext_txtbox;
        private System.Windows.Forms.TextBox pwtext_txtbox;
        private System.Windows.Forms.TextBox nametext_txtbox;
        private System.Windows.Forms.Button cancel_btn;
        private System.Windows.Forms.Button check_btn;
        private System.Windows.Forms.PictureBox join_page_image;
    }
}