using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기말프로젝트
{
    public partial class Manager_login : Form
    {
        public Manager_login()
        {
            InitializeComponent();
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            Menu_Management man_menu = new Menu_Management();
            mgpw.Focus();
            if (mgpw.Text == "manager1234")
            {
                this.Visible = false;
                mgpw.Text = "";
                man_menu.ShowDialog();
            }
            else
            {
                not_loginlabel.Text = "관리자 비밀번호가 틀렸습니다.";
            }
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            mgpw.Text = "";
        }
    }
}
