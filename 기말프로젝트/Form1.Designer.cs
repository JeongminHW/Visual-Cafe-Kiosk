
namespace 기말프로젝트
{
    partial class Form1
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
            this.pushbtn = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // pushbtn
            // 
            this.pushbtn.BackColor = System.Drawing.Color.White;
            this.pushbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pushbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pushbtn.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pushbtn.Location = new System.Drawing.Point(0, 0);
            this.pushbtn.Name = "pushbtn";
            this.pushbtn.Size = new System.Drawing.Size(1282, 753);
            this.pushbtn.TabIndex = 0;
            this.pushbtn.Text = "화면을 눌러주세요.";
            this.pushbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pushbtn.UseVisualStyleBackColor = false;
            this.pushbtn.Click += new System.EventHandler(this.pushbtn_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("한컴 말랑말랑 Bold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(455, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(417, 103);
            this.label1.TabIndex = 1;
            this.label1.Text = "비주얼 카페";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pushbtn);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button pushbtn;
        private System.Windows.Forms.Label label1;
    }
}

