using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace 기말프로젝트
{
    public partial class Main : Form
    {
        BeverageMenu bm = new BeverageMenu();
        SmoothieMenu smm = new SmoothieMenu();
        ShakeMenu skm = new ShakeMenu();
        AdeMenu am = new AdeMenu();
        public Main()
        {
            InitializeComponent();
        }

        CoffeeMenu cm = new CoffeeMenu();
        Manager_login mlogin = new Manager_login();
        private void home_Click(object sender, EventArgs e) //Home 버튼 누를 시
        {
            Form1 home = new Form1();
            this.Close(); //현재 폼 닫기
            home.Visible = true; //Form1 숨김 해제
        }

        private void managerbtn_Click(object sender, EventArgs e) //관리자 버튼 누를 시
        {
            mlogin.Show(); //매니저 로그인 폼 열기
            this.Close();
        }

        private void payment_Click(object sender, EventArgs e) //결제 버튼 누를 시
        {
            if(putin_menu1.Text == "" && putin_menu2.Text == "" && putin_menu3.Text == "" && putin_menu4.Text == "" && putin_menu5.Text == "")
            {
                MessageBox.Show("메뉴를 담아주세요");
            }
            else
            {
                Payment pm = new Payment(this);
                this.Visible = false; //현재 폼 숨기기
                pm.Show(); //결제 폼 열기
            }
        }

        private void rpbtn_Click(object sender, EventArgs e) //오른쪽 페이지 넘김 버튼 누를 시
        {
            if(Coffee_menu.BackColor.Equals(Color.LightSkyBlue)) //커피 버튼 색이 하늘색일 때
            {
                Coffee_menu.BackColor = Color.White; //커피 버튼 색 흰색으로 변경
                Beverage_menu.BackColor = Color.LightSkyBlue; //음료 버튼 색 하늘색으로 변경
                lpbtn.Visible = true; //왼쪽 페이지 버튼 보이기
                rpbtn.Visible = true; //오른쪽 페이지 버튼 보이기
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                bm.menu1(menu1, price1, groupBox7);
                bm.menu2(menu2, price2, groupBox8);
                bm.menu3(menu3, price3, groupBox9);
                bm.menu4(menu4, price4, groupBox10);
                bm.menu5(menu5, price5, groupBox11);
                bm.menu6(menu6, price6, groupBox12);
                bm.menu7(menu7, price7, groupBox13);
                bm.menu8(menu8, price8, groupBox14);
            }
            else if(Beverage_menu.BackColor.Equals(Color.LightSkyBlue)) //음료 버튼 색이 하늘색일 때
            {
                Beverage_menu.BackColor = Color.White;
                Smoothie_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                smm.menu1(menu1, price1, groupBox7);
                smm.menu2(menu2, price2, groupBox8);
                smm.menu3(menu3, price3, groupBox9);
                smm.menu4(menu4, price4, groupBox10);
                smm.menu5(menu5, price5, groupBox11);
            }
            else if(Smoothie_menu.BackColor.Equals(Color.LightSkyBlue)) //스무디 버튼 색이 하늘색일 때
            {
                Smoothie_menu.BackColor = Color.White;
                Shake_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                skm.menu1(menu1, price1, groupBox7);
                skm.menu2(menu2, price2, groupBox8);
                skm.menu3(menu3, price3, groupBox9);

            }
            else //쉐이크 버튼 색이 하늘색일 때
            {
                Shake_menu.BackColor = Color.White;
                Ade_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = false; //오른쪽 페이지 넘김 버튼 숨기기
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                am.menu1(menu1, price1, groupBox7);
                am.menu2(menu2, price2, groupBox8);
                am.menu3(menu3, price3, groupBox9);
            }
        }

        private void lpbtn_Click(object sender, EventArgs e) //왼쪽 페이지 넘김 버튼 누를 시
        {
            if(Beverage_menu.BackColor.Equals(Color.LightSkyBlue)) //음료 버튼 색이 하늘색일 때
            {
                Coffee_menu.BackColor = Color.LightSkyBlue; //커피 버튼 색 하늘색으로 변경
                Beverage_menu.BackColor = Color.White; //음료 버튼 색 흰색으로 변경
                rpbtn.Visible = true; //오른쪽 페이지 넘김 버튼 보이기
                lpbtn.Visible = false; //왼쪽 페이지 넘김 버튼 숨기기
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                cm.menu1(menu1, price1, groupBox7);
                cm.menu2(menu2, price2, groupBox8);
                cm.menu3(menu3, price3, groupBox9);
                cm.menu4(menu4, price4, groupBox10);
                cm.menu5(menu5, price5, groupBox11);
                cm.menu6(menu6, price6, groupBox12);
                cm.menu7(menu7, price7, groupBox13);
                cm.menu8(menu8, price8, groupBox14);
                cm.menu9(menu9, price9, groupBox15);
                cm.menu10(menu10, price10, groupBox16);
            }
            else if(Smoothie_menu.BackColor.Equals(Color.LightSkyBlue)) //스무디 버튼 색이 하늘색일 때
            {
                Beverage_menu.BackColor = Color.LightSkyBlue;
                Smoothie_menu.BackColor = Color.White;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                bm.menu1(menu1, price1, groupBox7);
                bm.menu2(menu2, price2, groupBox8);
                bm.menu3(menu3, price3, groupBox9);
                bm.menu4(menu4, price4, groupBox10);
                bm.menu5(menu5, price5, groupBox11);
                bm.menu6(menu6, price6, groupBox12);
                bm.menu7(menu7, price7, groupBox13);
                bm.menu8(menu8, price8, groupBox14);
            }
            else if(Shake_menu.BackColor.Equals(Color.LightSkyBlue)) //쉐이크 버튼 색이 하늘색일 때
            {
                Smoothie_menu.BackColor = Color.LightSkyBlue;
                Shake_menu.BackColor = Color.White;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                smm.menu1(menu1, price1, groupBox7);
                smm.menu2(menu2, price2, groupBox8);
                smm.menu3(menu3, price3, groupBox9);
                smm.menu4(menu4, price4, groupBox10);
                smm.menu5(menu5, price5, groupBox11);
            }
            else //에이드 버튼 색이 하늘색일 때
            {
                Shake_menu.BackColor = Color.LightSkyBlue;
                Ade_menu.BackColor = Color.White;
                rpbtn.Visible = true; //오른쪽 페이지 넘김 버튼 보이기
                lpbtn.Visible = true;
                Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
                GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
                Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (menubtn[i].Text == "")
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                skm.menu1(menu1, price1, groupBox7);
                skm.menu2(menu2, price2, groupBox8);
                skm.menu3(menu3, price3, groupBox9);
            }
        }

        private void Coffee_menu_Click(object sender, EventArgs e) //커피 버튼 누를 시
        {
            //커피 버튼을 제외한 모든 버튼 흰색으로 변경, 왼쪽 페이지 넘김 버튼 숨기기, 오른쪽 페이지 넘김 버튼 보이기
            Coffee_menu.BackColor = Color.LightSkyBlue; //커피 버튼 하늘색으로 변경
            Beverage_menu.BackColor = Color.White;
            Smoothie_menu.BackColor = Color.White;
            Shake_menu.BackColor = Color.White;
            Ade_menu.BackColor = Color.White;
            lpbtn.Visible = false;
            rpbtn.Visible = true;
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (menubtn[i].Text == "")
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            cm.menu1(menu1, price1, groupBox7);
            cm.menu2(menu2, price2, groupBox8);
            cm.menu3(menu3, price3, groupBox9);
            cm.menu4(menu4, price4, groupBox10);
            cm.menu5(menu5, price5, groupBox11);
            cm.menu6(menu6, price6, groupBox12);
            cm.menu7(menu7, price7, groupBox13);
            cm.menu8(menu8, price8, groupBox14);
            cm.menu9(menu9, price9, groupBox15);
            cm.menu10(menu10, price10, groupBox16);
        }

        private void Beverage_menu_Click(object sender, EventArgs e) //음료 버튼 누를 시
        {
            //음료 버튼을 제외 한 모든 버튼 흰색으로 변경, 왼쪽,오른쪽 페이지 넘김 버튼 보이기
            Coffee_menu.BackColor = Color.White;
            Beverage_menu.BackColor = Color.LightSkyBlue; //음료 버튼 하늘색으로 변경
            Smoothie_menu.BackColor = Color.White;
            Shake_menu.BackColor = Color.White;
            Ade_menu.BackColor = Color.White;
            lpbtn.Visible = true;
            rpbtn.Visible = true;
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (menubtn[i].Text == "")
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            bm.menu1(menu1, price1, groupBox7);
            bm.menu2(menu2, price2, groupBox8);
            bm.menu3(menu3, price3, groupBox9);
            bm.menu4(menu4, price4, groupBox10);
            bm.menu5(menu5, price5, groupBox11);
            bm.menu6(menu6, price6, groupBox12);
            bm.menu7(menu7, price7, groupBox13);
            bm.menu8(menu8, price8, groupBox14);

        }

        private void Smoothie_menu_Click(object sender, EventArgs e) //스무디 버튼 누를 시
        {
            //스무디 버튼을 제외한 모든 버튼 흰색으로 변경, 왼쪽,오른쪽 페이지 넘김 버튼 보이기
            Coffee_menu.BackColor = Color.White;
            Beverage_menu.BackColor = Color.White;
            Smoothie_menu.BackColor = Color.LightSkyBlue; //스무디 버튼 하늘색으로 변경
            Shake_menu.BackColor = Color.White;
            Ade_menu.BackColor = Color.White;
            lpbtn.Visible = true;
            rpbtn.Visible = true;
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (menubtn[i].Text == "")
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            smm.menu1(menu1, price1, groupBox7);
            smm.menu2(menu2, price2, groupBox8);
            smm.menu3(menu3, price3, groupBox9);
            smm.menu4(menu4, price4, groupBox10);
            smm.menu5(menu5, price5, groupBox11);

        }

        private void Shake_menu_Click(object sender, EventArgs e) //쉐이크 버튼 누를 시
        {
            //쉐이크를 제외한 모든 버튼 흰색으로 변경, 왼쪽,오른쪽 페이지 넘김 버튼 보이기
            Coffee_menu.BackColor = Color.White;
            Beverage_menu.BackColor = Color.White;
            Smoothie_menu.BackColor = Color.White;
            Shake_menu.BackColor = Color.LightSkyBlue; //쉐이크 버튼 하늘색으로 변경
            Ade_menu.BackColor = Color.White;
            lpbtn.Visible = true;
            rpbtn.Visible = true;
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (menubtn[i].Text == "")
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            skm.menu1(menu1, price1, groupBox7);
            skm.menu2(menu2, price2, groupBox8);
            skm.menu3(menu3, price3, groupBox9);
        }

        private void Ade_menu_Click(object sender, EventArgs e) //에이드 버튼 누를 시
        {
            //에이드 버튼 제외한 모든 버튼 흰색으로 변경, 왼쪽 페이지 넘김 버튼 보이기, 오른쪽 페이지 넘김 버튼 숨기기
            Coffee_menu.BackColor = Color.White;
            Beverage_menu.BackColor = Color.White;
            Smoothie_menu.BackColor = Color.White;
            Shake_menu.BackColor = Color.White;
            Ade_menu.BackColor = Color.LightSkyBlue; //에이드 버튼 하늘색으로 변경
            lpbtn.Visible = true;
            rpbtn.Visible = false;
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12, groupBox13, groupBox14, groupBox15, groupBox16, groupBox17, groupBox18 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (menubtn[i].Text == "")
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            am.menu1(menu1, price1, groupBox7);
            am.menu2(menu2, price2, groupBox8);
            am.menu3(menu3, price3, groupBox9);
        }

        private void Main_Load(object sender, EventArgs e)
        {
            if (Coffee_menu.BackColor == Color.LightSkyBlue)
            {
                lpbtn.Visible = false;
                cm.menu1(menu1, price1, groupBox7);
                cm.menu2(menu2, price2, groupBox8);
                cm.menu3(menu3, price3, groupBox9);
                cm.menu4(menu4, price4, groupBox10);
                cm.menu5(menu5, price5, groupBox11);
                cm.menu6(menu6, price6, groupBox12);
                cm.menu7(menu7, price7, groupBox13);
                cm.menu8(menu8, price8, groupBox14);
                cm.menu9(menu9, price9, groupBox15);
                cm.menu10(menu10, price10, groupBox16);
            }
        }

        private void menu1_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
                MessageBox.Show("5개가 넘는 메뉴를 담을 수 없습니다.");

            //카트에 메뉴 1번이 담기지 않았을 때
            //1번 카트
            if (putin_menu1.Text == "" && putin_menu2.Text != menu1.Text && putin_menu3.Text != menu1.Text && putin_menu4.Text != menu1.Text && putin_menu5.Text != menu1.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu1.Text;
                putin_menu1.BackgroundImage = menu1.BackgroundImage;
            }
            //2번 카트
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu1.Text && putin_menu3.Text != menu1.Text && putin_menu4.Text != menu1.Text && putin_menu5.Text != menu1.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu1.Text;
                putin_menu2.BackgroundImage = menu1.BackgroundImage;
            }
            //3번 카트
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu1.Text && putin_menu2.Text != menu1.Text && putin_menu4.Text != menu1.Text && putin_menu5.Text != menu1.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu1.Text;
                putin_menu3.BackgroundImage = menu1.BackgroundImage;
            }
            //4번 카트
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu1.Text && putin_menu2.Text != menu1.Text && putin_menu3.Text != menu1.Text && putin_menu5.Text != menu1.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu1.Text;
                putin_menu4.BackgroundImage = menu1.BackgroundImage;
            }
            //5번 카트
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu1.Text && putin_menu2.Text != menu1.Text && putin_menu3.Text != menu1.Text && putin_menu4.Text != menu1.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu1.Text;
                putin_menu5.BackgroundImage = menu1.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu1.Text || cartmenu[1] == menu1.Text || cartmenu[2] == menu1.Text || cartmenu[3] == menu1.Text || cartmenu[4] == menu1.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu1.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }
        private void menu2_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }

            //카트에 메뉴 2번이 담기지 않았을 때
            if (putin_menu1.Text == "" && putin_menu2.Text != menu2.Text && putin_menu3.Text != menu2.Text && putin_menu4.Text != menu2.Text && putin_menu5.Text != menu2.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu2.Text;
                putin_menu1.BackgroundImage = menu2.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu2.Text && putin_menu3.Text != menu2.Text && putin_menu4.Text != menu2.Text && putin_menu5.Text != menu2.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu2.Text;
                putin_menu2.BackgroundImage = menu2.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu2.Text && putin_menu2.Text != menu2.Text && putin_menu4.Text != menu2.Text && putin_menu5.Text != menu2.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu2.Text;
                putin_menu3.BackgroundImage = menu2.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu2.Text && putin_menu2.Text != menu2.Text && putin_menu3.Text != menu2.Text && putin_menu5.Text != menu2.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu2.Text;
                putin_menu4.BackgroundImage = menu2.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu2.Text && putin_menu2.Text != menu2.Text && putin_menu3.Text != menu2.Text && putin_menu4.Text != menu2.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu2.Text;
                putin_menu5.BackgroundImage = menu2.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu2.Text || cartmenu[1] == menu2.Text || cartmenu[2] == menu2.Text || cartmenu[3] == menu2.Text || cartmenu[4] == menu2.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu2.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }

            if (putin_menu1.Text == "" && putin_menu2.Text != menu3.Text && putin_menu3.Text != menu3.Text && putin_menu4.Text != menu3.Text && putin_menu5.Text != menu3.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu3.Text;
                putin_menu1.BackgroundImage = menu3.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu3.Text && putin_menu3.Text != menu3.Text && putin_menu4.Text != menu3.Text && putin_menu5.Text != menu3.Text)
            { 
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu3.Text;
                putin_menu2.BackgroundImage = menu3.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu3.Text && putin_menu2.Text != menu3.Text && putin_menu4.Text != menu3.Text && putin_menu5.Text != menu3.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu3.Text;
                putin_menu3.BackgroundImage = menu3.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu3.Text && putin_menu2.Text != menu3.Text && putin_menu3.Text != menu3.Text && putin_menu5.Text != menu3.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu3.Text;
                putin_menu4.BackgroundImage = menu3.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu3.Text && putin_menu2.Text != menu3.Text && putin_menu3.Text != menu3.Text && putin_menu4.Text != menu3.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu3.Text;
                putin_menu5.BackgroundImage = menu3.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu3.Text || cartmenu[1] == menu3.Text || cartmenu[2] == menu3.Text || cartmenu[3] == menu3.Text || cartmenu[4] == menu3.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu3.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu4.Text && putin_menu3.Text != menu4.Text && putin_menu4.Text != menu4.Text && putin_menu5.Text != menu4.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu4.Text;
                putin_menu1.BackgroundImage = menu4.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu4.Text && putin_menu3.Text != menu4.Text && putin_menu4.Text != menu4.Text && putin_menu5.Text != menu4.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu4.Text;
                putin_menu2.BackgroundImage = menu4.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu4.Text && putin_menu2.Text != menu4.Text && putin_menu4.Text != menu4.Text && putin_menu5.Text != menu4.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu4.Text;
                putin_menu3.BackgroundImage = menu4.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu4.Text && putin_menu2.Text != menu4.Text && putin_menu3.Text != menu4.Text && putin_menu5.Text != menu4.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu4.Text;
                putin_menu4.BackgroundImage = menu4.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu4.Text && putin_menu2.Text != menu4.Text && putin_menu3.Text != menu4.Text && putin_menu4.Text != menu4.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu4.Text;
                putin_menu5.BackgroundImage = menu4.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu4.Text || cartmenu[1] == menu4.Text || cartmenu[2] == menu4.Text || cartmenu[3] == menu4.Text || cartmenu[4] == menu4.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu4.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu5.Text && putin_menu3.Text != menu5.Text && putin_menu4.Text != menu5.Text && putin_menu5.Text != menu5.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu5.Text;
                putin_menu1.BackgroundImage = menu5.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu5.Text && putin_menu3.Text != menu5.Text && putin_menu4.Text != menu5.Text && putin_menu5.Text != menu5.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu5.Text;
                putin_menu2.BackgroundImage = menu5.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu5.Text && putin_menu2.Text != menu5.Text && putin_menu4.Text != menu5.Text && putin_menu5.Text != menu5.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu5.Text;
                putin_menu3.BackgroundImage = menu5.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu5.Text && putin_menu2.Text != menu5.Text && putin_menu3.Text != menu5.Text && putin_menu5.Text != menu5.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu5.Text;
                putin_menu4.BackgroundImage = menu5.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu5.Text && putin_menu2.Text != menu5.Text && putin_menu3.Text != menu5.Text && putin_menu4.Text != menu5.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu5.Text;
                putin_menu5.BackgroundImage = menu5.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu5.Text || cartmenu[1] == menu5.Text || cartmenu[2] == menu5.Text || cartmenu[3] == menu5.Text || cartmenu[4] == menu5.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu5.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu6.Text && putin_menu3.Text != menu6.Text && putin_menu4.Text != menu6.Text && putin_menu5.Text != menu6.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu6.Text;
                putin_menu1.BackgroundImage = menu6.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu6.Text && putin_menu3.Text != menu6.Text && putin_menu4.Text != menu6.Text && putin_menu5.Text != menu6.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu6.Text;
                putin_menu2.BackgroundImage = menu6.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu6.Text && putin_menu2.Text != menu6.Text && putin_menu4.Text != menu6.Text && putin_menu5.Text != menu6.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu6.Text;
                putin_menu3.BackgroundImage = menu6.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu6.Text && putin_menu2.Text != menu6.Text && putin_menu3.Text != menu6.Text && putin_menu5.Text != menu6.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu6.Text;
                putin_menu4.BackgroundImage = menu6.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu6.Text && putin_menu2.Text != menu6.Text && putin_menu3.Text != menu6.Text && putin_menu4.Text != menu6.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu6.Text;
                putin_menu5.BackgroundImage = menu6.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu6.Text || cartmenu[1] == menu6.Text || cartmenu[2] == menu6.Text || cartmenu[3] == menu6.Text || cartmenu[4] == menu6.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu6.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu7_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu7.Text && putin_menu3.Text != menu7.Text && putin_menu4.Text != menu7.Text && putin_menu5.Text != menu7.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu7.Text;
                putin_menu1.BackgroundImage = menu7.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu7.Text && putin_menu3.Text != menu7.Text && putin_menu4.Text != menu7.Text && putin_menu5.Text != menu7.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu7.Text;
                putin_menu2.BackgroundImage = menu7.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu7.Text && putin_menu2.Text != menu7.Text && putin_menu4.Text != menu7.Text && putin_menu5.Text != menu7.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu7.Text;
                putin_menu3.BackgroundImage = menu7.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu7.Text && putin_menu2.Text != menu7.Text && putin_menu3.Text != menu7.Text && putin_menu5.Text != menu7.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu7.Text;
                putin_menu4.BackgroundImage = menu7.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu7.Text && putin_menu2.Text != menu7.Text && putin_menu3.Text != menu7.Text && putin_menu4.Text != menu7.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu7.Text;
                putin_menu5.BackgroundImage = menu7.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu7.Text || cartmenu[1] == menu7.Text || cartmenu[2] == menu7.Text || cartmenu[3] == menu7.Text || cartmenu[4] == menu7.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu7.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu8_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu8.Text && putin_menu3.Text != menu8.Text && putin_menu4.Text != menu8.Text && putin_menu5.Text != menu8.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu8.Text;
                putin_menu1.BackgroundImage = menu8.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu8.Text && putin_menu3.Text != menu8.Text && putin_menu4.Text != menu8.Text && putin_menu5.Text != menu8.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu8.Text;
                putin_menu2.BackgroundImage = menu8.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu8.Text && putin_menu2.Text != menu8.Text && putin_menu4.Text != menu8.Text && putin_menu5.Text != menu8.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu8.Text;
                putin_menu3.BackgroundImage = menu8.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu8.Text && putin_menu2.Text != menu8.Text && putin_menu3.Text != menu8.Text && putin_menu5.Text != menu8.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu8.Text;
                putin_menu4.BackgroundImage = menu8.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu8.Text && putin_menu2.Text != menu8.Text && putin_menu3.Text != menu8.Text && putin_menu4.Text != menu8.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu8.Text;
                putin_menu5.BackgroundImage = menu8.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu8.Text || cartmenu[1] == menu8.Text || cartmenu[2] == menu8.Text || cartmenu[3] == menu8.Text || cartmenu[4] == menu8.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu8.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu9_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu9.Text && putin_menu3.Text != menu9.Text && putin_menu4.Text != menu9.Text && putin_menu5.Text != menu9.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu9.Text;
                putin_menu1.BackgroundImage = menu9.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu9.Text && putin_menu3.Text != menu9.Text && putin_menu4.Text != menu9.Text && putin_menu5.Text != menu9.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu9.Text;
                putin_menu2.BackgroundImage = menu9.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu9.Text && putin_menu2.Text != menu9.Text && putin_menu4.Text != menu9.Text && putin_menu5.Text != menu9.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu9.Text;
                putin_menu3.BackgroundImage = menu9.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu9.Text && putin_menu2.Text != menu9.Text && putin_menu3.Text != menu9.Text && putin_menu5.Text != menu9.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu9.Text;
                putin_menu4.BackgroundImage = menu9.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu9.Text && putin_menu2.Text != menu9.Text && putin_menu3.Text != menu9.Text && putin_menu4.Text != menu9.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu9.Text;
                putin_menu5.BackgroundImage = menu9.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu9.Text || cartmenu[1] == menu9.Text || cartmenu[2] == menu9.Text || cartmenu[3] == menu9.Text || cartmenu[4] == menu9.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu9.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void menu10_Click(object sender, EventArgs e)
        {
            conn.Open();
            //5개 넘었을 때 추가 시 오류메세지
            string[] cartmenu = new string[] { putin_menu1.Text, putin_menu2.Text, putin_menu3.Text, putin_menu4.Text, putin_menu5.Text };
            if (cartmenu[0] != "" && cartmenu[1] != "" && cartmenu[2] != "" && cartmenu[3] != "" && cartmenu[4] != "")
            {
                MessageBox.Show("5개 넘는 메뉴를 담을 수 없습니다.");
            }
            if (putin_menu1.Text == "" && putin_menu2.Text != menu10.Text && putin_menu3.Text != menu10.Text && putin_menu4.Text != menu10.Text && putin_menu5.Text != menu10.Text)
            {
                amount1.Visible = true;
                m1.Visible = true;
                p1.Visible = true;
                amount1.Text = 1.ToString();
                putin_menu1.Text = menu10.Text;
                putin_menu1.BackgroundImage = menu10.BackgroundImage;
            }
            else if (putin_menu2.Text == "" && putin_menu1.Text != menu10.Text && putin_menu3.Text != menu10.Text && putin_menu4.Text != menu10.Text && putin_menu5.Text != menu10.Text)
            {
                amount2.Visible = true;
                m2.Visible = true;
                p2.Visible = true;
                amount2.Text = 1.ToString();
                putin_menu2.Text = menu10.Text;
                putin_menu2.BackgroundImage = menu10.BackgroundImage;
            }
            else if (putin_menu3.Text == "" && putin_menu1.Text != menu10.Text && putin_menu2.Text != menu10.Text && putin_menu4.Text != menu10.Text && putin_menu5.Text != menu10.Text)
            {
                amount3.Visible = true;
                m3.Visible = true;
                p3.Visible = true;
                amount3.Text = 1.ToString();
                putin_menu3.Text = menu10.Text;
                putin_menu3.BackgroundImage = menu10.BackgroundImage;
            }
            else if (putin_menu4.Text == "" && putin_menu1.Text != menu10.Text && putin_menu2.Text != menu10.Text && putin_menu3.Text != menu10.Text && putin_menu5.Text != menu10.Text)
            {
                amount4.Visible = true;
                m4.Visible = true;
                p4.Visible = true;
                amount4.Text = 1.ToString();
                putin_menu4.Text = menu10.Text;
                putin_menu4.BackgroundImage = menu10.BackgroundImage;
            }
            else if (putin_menu5.Text == "" && putin_menu1.Text != menu10.Text && putin_menu2.Text != menu10.Text && putin_menu3.Text != menu10.Text && putin_menu4.Text != menu10.Text)
            {
                amount5.Visible = true;
                m5.Visible = true;
                p5.Visible = true;
                amount5.Text = 1.ToString();
                putin_menu5.Text = menu10.Text;
                putin_menu5.BackgroundImage = menu10.BackgroundImage;
            }

            //메뉴가 담겨져 있을 때 버튼을 한 번 더 누르면
            if (cartmenu[0] == menu10.Text || cartmenu[1] == menu10.Text || cartmenu[2] == menu10.Text || cartmenu[3] == menu10.Text || cartmenu[4] == menu10.Text)
                MessageBox.Show("추가/삭제는 +/-버튼을 눌러주세요");
            else //메뉴가 담겨져 있지 않을 때 총 가격 연산
            {
                string sql = "select menuPrice from Menu where menuName = '" + menu10.Text + "'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        //담은 메뉴 갯수 더하기, 빼기(삭제)
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        private void m1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount1.Text);
            a--;
            amount1.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu1.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while(rd.Read())
            {
                int total = Convert.ToInt32(totalP.Text) - Convert.ToInt32(rd["menuPrice"]);
                totalP.Text = total.ToString();
                if (a == 0)
                {
                    a = 1;
                    putin_menu1.Text = "";
                    putin_menu1.BackgroundImage = null;
                    amount1.Text = a.ToString();
                    amount1.Visible = false;
                    m1.Visible = false;
                    p1.Visible = false;
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void p1_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount1.Text);
            a++;
            amount1.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu1.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                if(a < 10)
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("주문 가능한 최대 잔 수는 10잔입니다.");
                    a = 10;
                    amount1.Text = a.ToString();
                }
            }
            conn.Close();
        }

        private void m2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount2.Text);
            a--;    
            amount2.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu2.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                int total = Convert.ToInt32(totalP.Text) - Convert.ToInt32(rd["menuPrice"]);
                totalP.Text = total.ToString();
                if (a == 0)
                {
                    a = 1;
                    putin_menu2.Text = "";
                    putin_menu2.BackgroundImage = null;
                    amount2.Text = a.ToString();
                    amount2.Visible = false;
                    m2.Visible = false;
                    p2.Visible = false;
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void p2_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount2.Text);
            a++;
            amount2.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu2.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                if (a < 10)
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("주문 가능한 최대 잔 수는 10잔입니다.");
                    a = 10;
                    amount2.Text = a.ToString();
                }
            }
            conn.Close();
        }

        private void m3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount3.Text);
            a--;
            amount3.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu3.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                int total = Convert.ToInt32(totalP.Text) - Convert.ToInt32(rd["menuPrice"]);
                totalP.Text = total.ToString();
                if (a == 0)
                {
                    a = 1;
                    putin_menu3.Text = "";
                    putin_menu3.BackgroundImage = null;
                    amount3.Text = a.ToString();
                    amount3.Visible = false;
                    m3.Visible = false;
                    p3.Visible = false;
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void p3_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount3.Text);
            a++;
            amount3.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu3.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                if (a < 10)
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("주문 가능한 최대 잔 수는 10잔입니다.");
                    a = 10;
                    amount3.Text = a.ToString();
                }
            }
            conn.Close();
        }

        private void m4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount4.Text);
            a--;
            amount4.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu4.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                int total = Convert.ToInt32(totalP.Text) - Convert.ToInt32(rd["menuPrice"]);
                totalP.Text = total.ToString();
                if (a == 0)
                {
                    a = 1;
                    putin_menu4.Text = "";
                    putin_menu4.BackgroundImage = null;
                    amount4.Text = a.ToString();
                    amount4.Visible = false;
                    m4.Visible = false;
                    p4.Visible = false;
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void p4_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount4.Text);
            a++;
            amount4.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu4.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                if (a < 10)
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("주문 가능한 최대 잔 수는 10잔입니다.");
                    a = 10;
                    amount4.Text = a.ToString();
                }
            }
            conn.Close();
        }

        private void m5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount5.Text);
            a--;
            amount5.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu5.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                int total = Convert.ToInt32(totalP.Text) - Convert.ToInt32(rd["menuPrice"]);
                totalP.Text = total.ToString();
                if (a == 0)
                {
                    a = 1;
                    putin_menu5.Text = "";
                    putin_menu5.BackgroundImage = null;
                    amount5.Text = a.ToString();
                    amount5.Visible = false;
                    m5.Visible = false;
                    p5.Visible = false;
                    totalP.Text = total.ToString();
                }
            }
            conn.Close();
        }

        private void p5_Click(object sender, EventArgs e)
        {
            int a = Convert.ToInt32(amount5.Text);
            a++;
            amount5.Text = a.ToString();
            conn.Open();
            string sql = "select menuPrice from Menu where menuName = '" + putin_menu5.Text + "'";
            OleDbCommand comm = new OleDbCommand(sql, conn);
            OleDbDataReader rd = comm.ExecuteReader(); //select 문
            while (rd.Read())
            {
                if (a < 10)
                {
                    int total = Convert.ToInt32(totalP.Text) + Convert.ToInt32(rd["menuPrice"]);
                    totalP.Text = total.ToString();
                }
                else
                {
                    MessageBox.Show("주문 가능한 최대 잔 수는 10잔입니다.");
                    a = 10;
                    amount5.Text = a.ToString();
                }
            }
            conn.Close();
        }

        propay pp = new propay();
        TotalPr tp = new TotalPr();
        private void Main_FormClosing(object sender, FormClosingEventArgs e) //폼 닫을 때 
        {
            //propay의 음료 잔 수 인덱서에 저장
            pp[0] = Convert.ToInt32(amount1.Text);
            pp[1] = Convert.ToInt32(amount2.Text);
            pp[2] = Convert.ToInt32(amount3.Text);
            pp[3] = Convert.ToInt32(amount4.Text);
            pp[4] = Convert.ToInt32(amount5.Text);
            Console.WriteLine(pp[0] + pp[1] + pp[2] + pp[3] + pp[4]);

            //TotalPr의 총 금액 인덱서에 저장
            tp[0] = Convert.ToInt32(totalP.Text);
            Console.WriteLine(tp[0]);

            //디비 닫기
            cm.dbClose();
            bm.dbClose();
            smm.dbClose();
            skm.dbClose();
            am.dbClose();
        }
    }
}