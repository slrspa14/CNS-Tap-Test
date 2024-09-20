namespace CNS_Tap_Test
{
    partial class TapTest
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TapTest));
            this.btnTap = new System.Windows.Forms.Button();
            this.lblResult = new System.Windows.Forms.Label();
            this.timeTen = new System.Windows.Forms.Timer(this.components);
            this.lblTimeLimit = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnTap
            // 
            this.btnTap.Font = new System.Drawing.Font("맑은 고딕", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btnTap.Location = new System.Drawing.Point(12, 183);
            this.btnTap.Name = "btnTap";
            this.btnTap.Size = new System.Drawing.Size(776, 255);
            this.btnTap.TabIndex = 0;
            this.btnTap.Text = "Tap";
            this.btnTap.UseVisualStyleBackColor = true;
            this.btnTap.Click += new System.EventHandler(this.btnTap_Click);
            // 
            // lblResult
            // 
            this.lblResult.Location = new System.Drawing.Point(294, 9);
            this.lblResult.Name = "lblResult";
            this.lblResult.Size = new System.Drawing.Size(210, 79);
            this.lblResult.TabIndex = 1;
            this.lblResult.Text = "GYM";
            this.lblResult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeTen
            // 
            this.timeTen.Interval = 1000;
            this.timeTen.Tick += new System.EventHandler(this.timeTen_Tick);
            // 
            // lblTimeLimit
            // 
            this.lblTimeLimit.Location = new System.Drawing.Point(10, 9);
            this.lblTimeLimit.Name = "lblTimeLimit";
            this.lblTimeLimit.Size = new System.Drawing.Size(162, 57);
            this.lblTimeLimit.TabIndex = 2;
            this.lblTimeLimit.Text = "Time";
            // 
            // TapTest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblTimeLimit);
            this.Controls.Add(this.lblResult);
            this.Controls.Add(this.btnTap);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "TapTest";
            this.Text = "Tap";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.TapTest_FormClosing);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnTap;
        private System.Windows.Forms.Label lblResult;
        private System.Windows.Forms.Timer timeTen;
        private System.Windows.Forms.Label lblTimeLimit;
    }
}

