
namespace 기말프로젝트
{
    partial class Complete_Payment
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
            this.pushbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label1.Location = new System.Drawing.Point(269, 328);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(811, 92);
            this.label1.TabIndex = 0;
            this.label1.Text = "결제가 완료되었습니다";
            // 
            // pushbtn
            // 
            this.pushbtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pushbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.pushbtn.Font = new System.Drawing.Font("나눔고딕", 18F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.pushbtn.Location = new System.Drawing.Point(0, 0);
            this.pushbtn.Name = "pushbtn";
            this.pushbtn.Size = new System.Drawing.Size(1282, 753);
            this.pushbtn.TabIndex = 1;
            this.pushbtn.Text = "화면을 눌러주세요.";
            this.pushbtn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pushbtn.UseVisualStyleBackColor = true;
            this.pushbtn.Click += new System.EventHandler(this.pushbtn_Click);
            // 
            // Complete_Payment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1282, 753);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.pushbtn);
            this.Name = "Complete_Payment";
            this.Text = "Complete_Payment";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button pushbtn;
    }
}