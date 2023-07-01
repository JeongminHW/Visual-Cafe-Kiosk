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
    public partial class Menu_Management : Form
    {
        Main main = new Main();
        CoffeeMenu cm = new CoffeeMenu();
        public Menu_Management()
        {
            InitializeComponent();
        }

        private void Menu_Management_Load(object sender, EventArgs e) //폼이 로드 되었을 때
        {

            if (Coffee_menu.BackColor == Color.LightSkyBlue)
            {
                lpbtn.Visible = false;
                cm.menu1(menu1, price1, groupBox1);
                cm.menu2(menu2, price2, groupBox2);
                cm.menu3(menu3, price3, groupBox3);
                cm.menu4(menu4, price4, groupBox4);
                cm.menu5(menu5, price5, groupBox5);
                cm.menu6(menu6, price6, groupBox6);
                cm.menu7(menu7, price7, groupBox7);
                cm.menu8(menu8, price8, groupBox8);
                cm.menu9(menu9, price9, groupBox9);
                cm.menu10(menu10, price10, groupBox10);
            }
        }

        //홈 버튼 클릭 시
        private void home_Click(object sender, EventArgs e)
        {
            Main main = new Main();
            Form1 home = new Form1();
            this.Close();
            main.Close();
            home.Visible = true;
            //디비 닫기
            cm.dbClose();
            bm.dbClose();
            smm.dbClose();
            skm.dbClose();
            am.dbClose();
        }

        //로그아웃 버튼 클릭 시
        private void logoutbtn_Click(object sender, EventArgs e)
        {
            main.Show();
            this.Close();
            //디비 닫기
            cm.dbClose();
            bm.dbClose();
            smm.dbClose();
            skm.dbClose();
            am.dbClose();
            dm.dbClose();
        }

        BeverageMenu bm = new BeverageMenu();
        SmoothieMenu smm = new SmoothieMenu();
        ShakeMenu skm = new ShakeMenu();
        AdeMenu am = new AdeMenu();
        //오른쪽 페이지 넘김 버튼 누를 시
        private void rpbtn_Click(object sender, EventArgs e) //오른쪽 페이지 넘김 버튼 누를 시
        {
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };

            if (Coffee_menu.BackColor.Equals(Color.LightSkyBlue)) //커피 버튼 색이 하늘색일 때
            {
                Coffee_menu.BackColor = Color.White; //커피 버튼 색 흰색으로 변경
                Beverage_menu.BackColor = Color.LightSkyBlue; //음료 버튼 색 하늘색으로 변경
                lpbtn.Visible = true; //왼쪽 페이지 버튼 보이기
                rpbtn.Visible = true; //오른쪽 페이지 버튼 보이기
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                bm.menu1(menu1, price1, groupBox1);
                bm.menu2(menu2, price2, groupBox2);
                bm.menu3(menu3, price3, groupBox3);
                bm.menu4(menu4, price4, groupBox4);
                bm.menu5(menu5, price5, groupBox5);
                bm.menu6(menu6, price6, groupBox6);
                bm.menu7(menu7, price7, groupBox7);
                bm.menu8(menu8, price8, groupBox8);
            }
            else if (Beverage_menu.BackColor.Equals(Color.LightSkyBlue)) //음료 버튼 색이 하늘색일 때
            {
                Beverage_menu.BackColor = Color.White;
                Smoothie_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                smm.menu1(menu1, price1, groupBox1);
                smm.menu2(menu2, price2, groupBox2);
                smm.menu3(menu3, price3, groupBox3);
                smm.menu4(menu4, price4, groupBox4);
                smm.menu5(menu5, price5, groupBox5);
            }
            else if (Smoothie_menu.BackColor.Equals(Color.LightSkyBlue)) //스무디 버튼 색이 하늘색일 때
            {
                Smoothie_menu.BackColor = Color.White;
                Shake_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                skm.menu1(menu1, price1, groupBox1);
                skm.menu2(menu2, price2, groupBox2);
                skm.menu3(menu3, price3, groupBox3);
            }
            else //쉐이크 버튼 색이 하늘색일 때
            {
                Shake_menu.BackColor = Color.White;
                Ade_menu.BackColor = Color.LightSkyBlue;
                rpbtn.Visible = false; //오른쪽 페이지 넘김 버튼 숨기기
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                am.menu1(menu1, price1, groupBox1);
                am.menu2(menu2, price2, groupBox2);
                am.menu3(menu3, price3, groupBox3);
            }
        }

        private void lpbtn_Click(object sender, EventArgs e) //왼쪽 페이지 넘김 버튼 누를 시
        {
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            if (Beverage_menu.BackColor.Equals(Color.LightSkyBlue)) //음료 버튼 색이 하늘색일 때
            {
                Coffee_menu.BackColor = Color.LightSkyBlue; //커피 버튼 색 하늘색으로 변경
                Beverage_menu.BackColor = Color.White; //음료 버튼 색 흰색으로 변경
                rpbtn.Visible = true; //오른쪽 페이지 넘김 버튼 보이기
                lpbtn.Visible = false; //왼쪽 페이지 넘김 버튼 숨기기
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                cm.menu1(menu1, price1, groupBox1);
                cm.menu2(menu2, price2, groupBox2);
                cm.menu3(menu3, price3, groupBox3);
                cm.menu4(menu4, price4, groupBox4);
                cm.menu5(menu5, price5, groupBox5);
                cm.menu6(menu6, price6, groupBox6);
                cm.menu7(menu7, price7, groupBox7);
                cm.menu8(menu8, price8, groupBox8);
                cm.menu9(menu9, price9, groupBox9);
                cm.menu10(menu10, price10, groupBox10);
            }
            else if (Smoothie_menu.BackColor.Equals(Color.LightSkyBlue)) //스무디 버튼 색이 하늘색일 때
            {
                Beverage_menu.BackColor = Color.LightSkyBlue;
                Smoothie_menu.BackColor = Color.White;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                bm.menu1(menu1, price1, groupBox1);
                bm.menu2(menu2, price2, groupBox2);
                bm.menu3(menu3, price3, groupBox3);
                bm.menu4(menu4, price4, groupBox4);
                bm.menu5(menu5, price5, groupBox5);
                bm.menu6(menu6, price6, groupBox6);
                bm.menu7(menu7, price7, groupBox7);
                bm.menu8(menu8, price8, groupBox8);
            }
            else if (Shake_menu.BackColor.Equals(Color.LightSkyBlue)) //쉐이크 버튼 색이 하늘색일 때
            {
                Smoothie_menu.BackColor = Color.LightSkyBlue;
                Shake_menu.BackColor = Color.White;
                rpbtn.Visible = true;
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                smm.menu1(menu1, price1, groupBox1);
                smm.menu2(menu2, price2, groupBox2);
                smm.menu3(menu3, price3, groupBox3);
                smm.menu4(menu4, price4, groupBox4);
                smm.menu5(menu5, price5, groupBox5);
            }
            else //에이드 버튼 색이 하늘색일 때
            {
                Shake_menu.BackColor = Color.LightSkyBlue;
                Ade_menu.BackColor = Color.White;
                rpbtn.Visible = true; //오른쪽 페이지 넘김 버튼 보이기
                lpbtn.Visible = true;
                for (int i = 0; i < 12; i++)
                {
                    if (menubtn[i].Text != "")
                    {
                        menubtn[i].Text = "";
                        menulb[i].Text = "";
                        menubtn[i].BackgroundImage = null;
                        if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                        {
                            menubtn[i].Visible = true;
                            menugb[i].Visible = true;
                        }
                        else //추가 버튼이 보일 때
                        {
                            menubtn[i].Visible = false;
                            menugb[i].Visible = false;
                        }
                    }
                }
                skm.menu1(menu1, price1, groupBox1);
                skm.menu2(menu2, price2, groupBox2);
                skm.menu3(menu3, price3, groupBox3);
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
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                    {
                        menubtn[i].Visible = true;
                        menugb[i].Visible = true;
                    }
                    else //추가 버튼이 보일 때
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            cm.menu1(menu1, price1, groupBox1);
            cm.menu2(menu2, price2, groupBox2);
            cm.menu3(menu3, price3, groupBox3);
            cm.menu4(menu4, price4, groupBox4);
            cm.menu5(menu5, price5, groupBox5);
            cm.menu6(menu6, price6, groupBox6);
            cm.menu7(menu7, price7, groupBox7);
            cm.menu8(menu8, price8, groupBox8);
            cm.menu9(menu9, price9, groupBox9);
            cm.menu10(menu10, price10, groupBox10);
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
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                    {
                        menubtn[i].Visible = true;
                        menugb[i].Visible = true;
                    }
                    else //추가 버튼이 보일 때
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            bm.menu1(menu1, price1, groupBox1);
            bm.menu2(menu2, price2, groupBox2);
            bm.menu3(menu3, price3, groupBox3);
            bm.menu4(menu4, price4, groupBox4);
            bm.menu5(menu5, price5, groupBox5);
            bm.menu6(menu6, price6, groupBox6);
            bm.menu7(menu7, price7, groupBox7);
            bm.menu8(menu8, price8, groupBox8);
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
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                    {
                        menubtn[i].Visible = true;
                        menugb[i].Visible = true;
                    }
                    else //추가 버튼이 보일 때
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            smm.menu1(menu1, price1, groupBox1);
            smm.menu2(menu2, price2, groupBox2);
            smm.menu3(menu3, price3, groupBox3);
            smm.menu4(menu4, price4, groupBox4);
            smm.menu5(menu5, price5, groupBox5);
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
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                    {
                        menubtn[i].Visible = true;
                        menugb[i].Visible = true;
                    }
                    else //추가 버튼이 보일 때
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            skm.menu1(menu1, price1, groupBox1);
            skm.menu2(menu2, price2, groupBox2);
            skm.menu3(menu3, price3, groupBox3);
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
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text != "")
                {
                    menubtn[i].Text = "";
                    menulb[i].Text = "";
                    menubtn[i].BackgroundImage = null;
                    if (addbtn.Visible == false) // 추가 버튼이 보이지 않을 때
                    {
                        menubtn[i].Visible = true;
                        menugb[i].Visible = true;
                    }
                    else //추가 버튼이 보일 때
                    {
                        menubtn[i].Visible = false;
                        menugb[i].Visible = false;
                    }
                }
            }
            am.menu1(menu1, price1, groupBox1);
            am.menu2(menu2, price2, groupBox2);
            am.menu3(menu3, price3, groupBox3);
        }

        //추가, 확인 버튼 이벤트
        public void menubtn_Show()
        {
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                menubtn[i].Visible = true;
                menugb[i].Visible = true;
                menulb[i].Visible = true;
            }
        }
        public void menubtn_Hide()
        {
            Button[] menubtn = new Button[] { menu1, menu2, menu3, menu4, menu5, menu6, menu7, menu8, menu9, menu10, menu11, menu12 }; //버튼 배열
            GroupBox[] menugb = new GroupBox[] { groupBox1, groupBox2, groupBox3, groupBox4, groupBox5, groupBox6, groupBox7, groupBox8, groupBox9, groupBox10, groupBox11, groupBox12 }; //그룹박스 배열
            Label[] menulb = new Label[] { price1, price2, price3, price4, price5, price6, price7, price8, price9, price10, price11, price12 };
            for (int i = 0; i < 12; i++)
            {
                if (menubtn[i].Text == "")
                {
                    menubtn[i].Visible = false;
                    menugb[i].Visible = false;
                    menulb[i].Visible = false;
                }
            }
        }
        private void addbtn_Click(object sender, EventArgs e)
        {
            menubtn_Show();
            addbtn.Visible = false;
            okbtn.Visible = true;
        }

        private void okbtn_Click(object sender, EventArgs e)
        {
            menubtn_Hide();
            okbtn.Visible = false;
            addbtn.Visible = true;
        }

        //메뉴버튼 1~12 누를 시 버튼 이벤트
        deleteMenu dm = new deleteMenu();
        public void menu1_Click(object sender, EventArgs e)
        {
            if(menu1.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu1.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else //메뉴 삭제
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu1, price1, groupBox1);
                else
                    return;
            }
        }

        private void menu2_Click(object sender, EventArgs e)
        {
            if(menu2.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu2.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else //메뉴 삭제
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu2, price2, groupBox2);
                else
                    return;
            }
        }

        private void menu3_Click(object sender, EventArgs e)
        {
            if(menu3.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu3.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else //메뉴 삭제
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu3, price3, groupBox3);
                else
                    return;
            }
        }

        private void menu4_Click(object sender, EventArgs e)
        {
            if (menu4.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu4.DialogResult = DialogResult.OK;
                addf.ShowDialog();
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu4, price4, groupBox4);
                else
                    return;
            }
        }

        private void menu5_Click(object sender, EventArgs e)
        {
            if (menu5.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu5.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu5, price5, groupBox5);
                else
                    return;
            }
        }

        private void menu6_Click(object sender, EventArgs e)
        {
            if(menu6.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu6.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu6, price6, groupBox6);
                else
                    return;
            }
        }

        private void menu7_Click(object sender, EventArgs e)
        {
            if(menu7.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu7.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu7, price7, groupBox7);
                else
                    return;
            }
        }

        private void menu8_Click(object sender, EventArgs e)
        {
            if(menu8.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu8.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가

            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu8, price8, groupBox8);
                else
                    return;
            }
        }

        private void menu9_Click(object sender, EventArgs e)
        {
            if(menu9.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu9.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu9, price9, groupBox9);
                else
                    return;
            }
        }

        private void menu10_Click(object sender, EventArgs e)
        {
            if(menu10.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu10.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu10, price10, groupBox10);
                else
                    return;
            }
        }

        private void menu11_Click(object sender, EventArgs e)
        {
            if(menu11.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu11.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu11, price11, groupBox11);
                else
                    return;
            }
        }

        private void menu12_Click(object sender, EventArgs e)
        {
            if(menu12.Text == "")
            {
                AddMenuForm addf = new AddMenuForm(this);
                menu12.DialogResult = DialogResult.OK;
                addf.ShowDialog(); // 메뉴 추가
            }
            else
            {
                DialogResult dr = MessageBox.Show("메뉴를 삭제하시겠습니까?", "메뉴 삭제", MessageBoxButtons.OKCancel);
                if (dr == DialogResult.OK)
                    dm.menu1(menu12, price12, groupBox12);
                else
                    return;
            }
        }
    }
}