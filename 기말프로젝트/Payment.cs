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
    public partial class Payment : Form
    {
        Main mm;
        public Payment()
        {
            InitializeComponent();
        }
        public Payment(Main main)
        {
            InitializeComponent();
            mm = main;
        }

        private void canclebtn_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            this.Close();
            main.Show();
        }

        private void nextbtn_Click(object sender, EventArgs e) //다음 화면으로 넘어감
        {
            if (getprice.Text == "")
                MessageBox.Show("금액을 입력해주세요");
            else if (change.Text == "")
                MessageBox.Show("확인 버튼을 눌러주세요.");
            else
            {
                Complete_Payment cp = new Complete_Payment();
                this.Close();
                cp.Show();
            }
        }

        private void okbtn_Click(object sender, EventArgs e) //거스름 돈 나타냄
        {
            if (getprice.Text == "")
                MessageBox.Show("금액을 입력해주세요");
            else if (Convert.ToInt32(getprice.Text) < Convert.ToInt32(totalprice.Text))
                MessageBox.Show("받은 금액이 총 금액보다 적게 입력되었습니다.\n금액을 다시 입력해주세요.");
            else
            {
                int cg = Convert.ToInt32(textBox1.Text) - tp[0];
                change.Text = cg.ToString();
            }
        }

        //계산기 숫자
        private void button1_Click(object sender, EventArgs e)
        {
            textBox1.Text += button1.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text += button2.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            textBox1.Text += button3.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            textBox1.Text += button4.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            textBox1.Text += button5.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button6_Click(object sender, EventArgs e)
        {
            textBox1.Text += button6.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox1.Text += button7.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            textBox1.Text += button8.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            textBox1.Text += button9.Text.ToString();
            getprice.Text = textBox1.Text;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("0은 맨 처음 입력할 수 없습니다.");
            }
            else
            {
                textBox1.Text += button0.Text.ToString();
                getprice.Text = textBox1.Text;
            }
        }

        private void button00_Click(object sender, EventArgs e)
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("0은 맨 처음 입력할 수 없습니다.");
            }
            else
            {
                textBox1.Text += button00.Text.ToString();
                getprice.Text = textBox1.Text;
            }
        }

        private void delbtn_Click(object sender, EventArgs e) //한 칸 지우기
        {
            if(textBox1.Text == "")
            {
                MessageBox.Show("더 이상 지울 수 없습니다.");
            }
            else
            {
                textBox1.Text = textBox1.Text.Substring(0, textBox1.Text.Length - 1);
                getprice.Text = textBox1.Text;
            }
        }
        propay pp = new propay();
        TotalPr tp = new TotalPr();
        private void Payment_Load(object sender, EventArgs e)
        {
            //음료 잔 수 인덱서에 저장
            pp[0] = Convert.ToInt32(mm.amount1.Text);
            pp[1] = Convert.ToInt32(mm.amount2.Text);
            pp[2] = Convert.ToInt32(mm.amount3.Text);
            pp[3] = Convert.ToInt32(mm.amount4.Text);
            pp[4] = Convert.ToInt32(mm.amount5.Text);

            //음료 금액 인덱서에 저장
            tp[0] = Convert.ToInt32(mm.totalP.Text);

            totalamount.Text = ((pp.Amount()).ToString() + " 개");
            totalprice.Text = tp[0].ToString();
        }
    }
}
