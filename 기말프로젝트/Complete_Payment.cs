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
    public partial class Complete_Payment : Form
    {
        public Complete_Payment()
        {
            InitializeComponent();
        }

        private void pushbtn_Click(object sender, EventArgs e)
        {
            Form1 home = new Form1();
            this.Close();
            home.Show();
        }
    }
}
