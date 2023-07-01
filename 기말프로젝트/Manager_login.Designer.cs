
namespace 기말프로젝트
{
    partial class Manager_login
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
            this.loginlabel = new System.Windows.Forms.Label();
            this.okbtn = new System.Windows.Forms.Button();
            this.canclebtn = new System.Windows.Forms.Button();
            this.mgpw = new System.Windows.Forms.TextBox();
            this.not_loginlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // loginlabel
            // 
            this.loginlabel.AutoSize = true;
            this.loginlabel.Font = new System.Drawing.Font("나눔고딕 ExtraBold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.loginlabel.Location = new System.Drawing.Point(89, 51);
            this.loginlabel.Name = "loginlabel";
            this.loginlabel.Size = new System.Drawing.Size(157, 28);
            this.loginlabel.TabIndex = 0;
            this.loginlabel.Text = "관리자 로그인";
            // 
            // okbtn
            // 
            this.okbtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okbtn.Location = new System.Drawing.Point(34, 240);
            this.okbtn.Name = "okbtn";
            this.okbtn.Size = new System.Drawing.Size(119, 53);
            this.okbtn.TabIndex = 5;
            this.okbtn.Text = "로그인";
            this.okbtn.UseVisualStyleBackColor = true;
            this.okbtn.Click += new System.EventHandler(this.okbtn_Click);
            // 
            // canclebtn
            // 
            this.canclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.canclebtn.Location = new System.Drawing.Point(181, 240);
            this.canclebtn.Name = "canclebtn";
            this.canclebtn.Size = new System.Drawing.Size(122, 53);
            this.canclebtn.TabIndex = 6;
            this.canclebtn.Text = "취소";
            this.canclebtn.UseVisualStyleBackColor = true;
            this.canclebtn.Click += new System.EventHandler(this.canclebtn_Click);
            // 
            // mgpw
            // 
            this.mgpw.Location = new System.Drawing.Point(72, 136);
            this.mgpw.Name = "mgpw";
            this.mgpw.Size = new System.Drawing.Size(194, 25);
            this.mgpw.TabIndex = 3;
            // 
            // not_loginlabel
            // 
            this.not_loginlabel.AutoSize = true;
            this.not_loginlabel.Font = new System.Drawing.Font("나눔고딕", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.not_loginlabel.Location = new System.Drawing.Point(68, 177);
            this.not_loginlabel.Name = "not_loginlabel";
            this.not_loginlabel.Size = new System.Drawing.Size(0, 17);
            this.not_loginlabel.TabIndex = 7;
            // 
            // Manager_login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(332, 338);
            this.Controls.Add(this.not_loginlabel);
            this.Controls.Add(this.canclebtn);
            this.Controls.Add(this.okbtn);
            this.Controls.Add(this.mgpw);
            this.Controls.Add(this.loginlabel);
            this.Name = "Manager_login";
            this.Text = "Manager_login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label loginlabel;
        private System.Windows.Forms.Button okbtn;
        private System.Windows.Forms.Button canclebtn;
        private System.Windows.Forms.TextBox mgpw;
        private System.Windows.Forms.Label not_loginlabel;
    }
}