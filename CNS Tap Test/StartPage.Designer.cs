namespace CNS_Tap_Test
{
    partial class StartPage
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
            this.start_btn = new System.Windows.Forms.Button();
            this.start_picbox = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.start_picbox)).BeginInit();
            this.SuspendLayout();
            // 
            // start_btn
            // 
            this.start_btn.BackColor = System.Drawing.Color.White;
            this.start_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.start_btn.Location = new System.Drawing.Point(157, 111);
            this.start_btn.Name = "start_btn";
            this.start_btn.Size = new System.Drawing.Size(629, 329);
            this.start_btn.TabIndex = 0;
            this.start_btn.UseVisualStyleBackColor = false;
            // 
            // start_picbox
            // 
            this.start_picbox.Location = new System.Drawing.Point(0, 0);
            this.start_picbox.Name = "start_picbox";
            this.start_picbox.Size = new System.Drawing.Size(786, 440);
            this.start_picbox.TabIndex = 1;
            this.start_picbox.TabStop = false;
            // 
            // StartPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(784, 441);
            this.Controls.Add(this.start_btn);
            this.Controls.Add(this.start_picbox);
            this.Name = "StartPage";
            this.Text = "StartPage";
            ((System.ComponentModel.ISupportInitialize)(this.start_picbox)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button start_btn;
        private System.Windows.Forms.PictureBox start_picbox;
    }
}