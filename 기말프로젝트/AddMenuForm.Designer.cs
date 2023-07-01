
namespace 기말프로젝트
{
    partial class AddMenuForm
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
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.MenuName = new System.Windows.Forms.Label();
            this.MenuPrice = new System.Windows.Forms.Label();
            this.loadimage = new System.Windows.Forms.Button();
            this.Canclebtn = new System.Windows.Forms.Button();
            this.Savebtn = new System.Windows.Forms.Button();
            this.nametxt = new System.Windows.Forms.TextBox();
            this.pricetxt = new System.Windows.Forms.TextBox();
            this.showfile = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // MenuName
            // 
            this.MenuName.AutoSize = true;
            this.MenuName.Location = new System.Drawing.Point(37, 61);
            this.MenuName.Name = "MenuName";
            this.MenuName.Size = new System.Drawing.Size(72, 15);
            this.MenuName.TabIndex = 0;
            this.MenuName.Text = "메뉴 이름";
            // 
            // MenuPrice
            // 
            this.MenuPrice.AutoSize = true;
            this.MenuPrice.Location = new System.Drawing.Point(37, 117);
            this.MenuPrice.Name = "MenuPrice";
            this.MenuPrice.Size = new System.Drawing.Size(72, 15);
            this.MenuPrice.TabIndex = 1;
            this.MenuPrice.Text = "메뉴 가격";
            // 
            // loadimage
            // 
            this.loadimage.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.loadimage.Location = new System.Drawing.Point(40, 207);
            this.loadimage.Name = "loadimage";
            this.loadimage.Size = new System.Drawing.Size(239, 34);
            this.loadimage.TabIndex = 2;
            this.loadimage.Text = "이미지 파일";
            this.loadimage.UseVisualStyleBackColor = true;
            this.loadimage.Click += new System.EventHandler(this.loadimage_Click);
            // 
            // Canclebtn
            // 
            this.Canclebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Canclebtn.Location = new System.Drawing.Point(166, 291);
            this.Canclebtn.Name = "Canclebtn";
            this.Canclebtn.Size = new System.Drawing.Size(113, 34);
            this.Canclebtn.TabIndex = 3;
            this.Canclebtn.Text = "취소";
            this.Canclebtn.UseVisualStyleBackColor = true;
            this.Canclebtn.Click += new System.EventHandler(this.Canclebtn_Click);
            // 
            // Savebtn
            // 
            this.Savebtn.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Savebtn.Location = new System.Drawing.Point(40, 291);
            this.Savebtn.Name = "Savebtn";
            this.Savebtn.Size = new System.Drawing.Size(113, 35);
            this.Savebtn.TabIndex = 5;
            this.Savebtn.Text = "저장";
            this.Savebtn.UseVisualStyleBackColor = true;
            this.Savebtn.Click += new System.EventHandler(this.Savebtn_Click);
            // 
            // nametxt
            // 
            this.nametxt.Location = new System.Drawing.Point(115, 57);
            this.nametxt.Name = "nametxt";
            this.nametxt.Size = new System.Drawing.Size(164, 25);
            this.nametxt.TabIndex = 6;
            // 
            // pricetxt
            // 
            this.pricetxt.Location = new System.Drawing.Point(115, 114);
            this.pricetxt.Name = "pricetxt";
            this.pricetxt.Size = new System.Drawing.Size(164, 25);
            this.pricetxt.TabIndex = 7;
            // 
            // showfile
            // 
            this.showfile.BackColor = System.Drawing.Color.White;
            this.showfile.Location = new System.Drawing.Point(41, 167);
            this.showfile.Name = "showfile";
            this.showfile.ReadOnly = true;
            this.showfile.Size = new System.Drawing.Size(237, 25);
            this.showfile.TabIndex = 8;
            // 
            // AddMenuForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(317, 353);
            this.Controls.Add(this.showfile);
            this.Controls.Add(this.pricetxt);
            this.Controls.Add(this.nametxt);
            this.Controls.Add(this.Savebtn);
            this.Controls.Add(this.Canclebtn);
            this.Controls.Add(this.loadimage);
            this.Controls.Add(this.MenuPrice);
            this.Controls.Add(this.MenuName);
            this.Name = "AddMenuForm";
            this.Text = "AddMenuForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label MenuName;
        private System.Windows.Forms.Label MenuPrice;
        private System.Windows.Forms.Button loadimage;
        private System.Windows.Forms.Button Canclebtn;
        private System.Windows.Forms.Button Savebtn;
        private System.Windows.Forms.TextBox nametxt;
        private System.Windows.Forms.TextBox pricetxt;
        private System.Windows.Forms.TextBox showfile;
        public System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}