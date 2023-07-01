using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.OleDb;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace 기말프로젝트
{
    public partial class AddMenuForm : Form
    {
        Menu_Management mmf;
        AddMenu am = new AddMenu();
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public AddMenuForm()
        {
            try
            {
                conn.Open(); //디비 열기
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            InitializeComponent();
        }
        public AddMenuForm(Menu_Management managerform) //관리자 화면에서 추가하고싶은 버튼을 눌렀을 때 사용
        {
            InitializeComponent();
            mmf = managerform;
        }
        private void loadimage_Click(object sender, EventArgs e)
        {
            openFileDialog1.InitialDirectory = @"C:\Users\황정민\source\repos\기말프로젝트\Resources";
            openFileDialog1.Filter = "이미지 파일(*.png)|*.png|모든 파일(*.*)|*.*";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true; //초기 디렉토리로 되돌아가기 여부
            openFileDialog1.ShowDialog();
            showfile.Text = openFileDialog1.FileName;
        }

        private void Savebtn_Click(object sender, EventArgs e)
        {
            am.M_Name = nametxt.Text;
            am.M_Price = pricetxt.Text;
            string[] coffee = new string[] { "핫 아메리카노", "아이스 아메리카노", "핫 카페라떼", "아이스 카페라떼", "핫 카페모카", "아이스 카페모카", "핫 카푸치노", "아이스 카푸치노", "핫 바닐라라떼", "아이스 바닐라라떼"};
            string[] beverage = new string[] { "핫 초콜릿", "아이스 초콜릿", "핫 화이트 초콜릿", "아이스 화이트 초콜릿", "핫 녹차라떼", "아이스 녹차라떼", "핫 고구마라떼", "아이스 고구마라떼" };
            string[] smoothie = new string[] { "초콜릿 칩 스무디", "녹차 스무디", "자몽 스무디", "망고 스무디", "플레인 요거트 스무디" };
            string[] shake = new string[] { "플레인 쉐이크", "초코쿠키 쉐이크", "딸기 쉐이크" };
            string[] ade = new string[] { "레몬 에이드", "청포도 에이드", "자몽 에이드" };

            Button[] menubtn = new Button[] { mmf.menu1, mmf.menu2, mmf.menu3, mmf.menu4, mmf.menu5, mmf.menu6, mmf.menu7, mmf.menu8, mmf.menu9, mmf.menu10, mmf.menu11, mmf.menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { mmf.groupBox1, mmf.groupBox2, mmf.groupBox3, mmf.groupBox4, mmf.groupBox5, mmf.groupBox6, mmf.groupBox7, mmf.groupBox8, mmf.groupBox9, mmf.groupBox10, mmf.groupBox11, mmf.groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { mmf.price1, mmf.price2, mmf.price3, mmf.price4, mmf.price5, mmf.price6, mmf.price7, mmf.price8, mmf.price9, mmf.price10, mmf.price11, mmf.price12 };

            if (nametxt.Text == "" || pricetxt.Text == "")
            {
                MessageBox.Show("메뉴 이름과 가격을 입력해주세요");
                return;
            }
            else
            {
                conn.Open();
                for (int j = 0; j < 12; j++)
                {
                    if (menubtn[j].DialogResult == DialogResult.OK)
                    {
                        string usql = "UPDATE Menu SET addCheck = Yes WHERE menuName = '" + am.M_Name + "'";
                        OleDbCommand comm = new OleDbCommand(usql, conn);

                        //커피 메뉴 추가 시
                        if (mmf.Coffee_menu.BackColor == Color.LightSkyBlue)
                        {
                            for (int cnt = 0; cnt < 10; cnt++)
                            {
                                if (am.M_Name == coffee[cnt])
                                {
                                    menubtn[j].Text = am.M_Name;
                                    menulb[j].Text = am.M_Price;
                                    menubtn[j].BackgroundImage = new Bitmap(openFileDialog1.FileName);
                                }
                            }
                            int i = comm.ExecuteNonQuery(); //update 실행
                        }
                        //음료 메뉴 추가 시
                        else if (mmf.Beverage_menu.BackColor == Color.LightSkyBlue)
                        {
                            for (int cnt = 0; cnt < 8; cnt++)
                            {
                                if (am.M_Name == beverage[cnt])
                                {
                                    menubtn[j].Text = am.M_Name;
                                    menulb[j].Text = am.M_Price;
                                    menubtn[j].BackgroundImage = new Bitmap(openFileDialog1.FileName);
                                }
                            }
                            int i = comm.ExecuteNonQuery();
                        }
                        //스무디 메뉴 추가 시
                        else if (mmf.Smoothie_menu.BackColor == Color.LightSkyBlue)
                        {
                            for (int cnt = 0; cnt < 5; cnt++)
                            {
                                if (am.M_Name == smoothie[cnt])
                                {
                                    menubtn[j].Text = am.M_Name;
                                    menulb[j].Text = am.M_Price;
                                    menubtn[j].BackgroundImage = new Bitmap(openFileDialog1.FileName);
                                }
                            }
                            int i = comm.ExecuteNonQuery();
                        }
                        //쉐이크 메뉴 추가 시
                        else if (mmf.Shake_menu.BackColor == Color.LightSkyBlue)
                        {
                            for (int cnt = 0; cnt < 3; cnt++)
                            {
                                if (am.M_Name == shake[cnt])
                                {
                                    menubtn[j].Text = am.M_Name;
                                    menulb[j].Text = am.M_Price;
                                    menubtn[j].BackgroundImage = new Bitmap(openFileDialog1.FileName);
                                }
                            }
                            int i = comm.ExecuteNonQuery();
                        }
                        //에이드 메뉴 추가 시
                        else
                        {
                            for (int cnt = 0; cnt < 3; cnt++)
                            {
                                if (am.M_Name == ade[cnt])
                                {
                                    menubtn[j].Text = am.M_Name;
                                    menulb[j].Text = am.M_Price;
                                    menubtn[j].BackgroundImage = new Bitmap(openFileDialog1.FileName);
                                }
                            }
                            int i = comm.ExecuteNonQuery();
                        }
                    }
                }
                conn.Close();
                this.Close();
            }
        }

        private void Canclebtn_Click(object sender, EventArgs e)
        {
            this.Close();
            conn.Close();
        }
    }
}
