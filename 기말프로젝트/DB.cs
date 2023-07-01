using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.OleDb;
using System.Windows.Forms;
using System.Drawing;

namespace 기말프로젝트
{
    abstract class DB
    {
        //커피 버튼 활성화
        public abstract void menu1(Button menu, Label price, GroupBox gb);
        public abstract void menu2(Button menu, Label price, GroupBox gb);
        public abstract void menu3(Button menu, Label price, GroupBox gb);
        public abstract void menu4(Button menu, Label price, GroupBox gb);
        public abstract void menu5(Button menu, Label price, GroupBox gb);
        public abstract void menu6(Button menu, Label price, GroupBox gb);
        public abstract void menu7(Button menu, Label price, GroupBox gb);
        public abstract void menu8(Button menu, Label price, GroupBox gb);
        public abstract void menu9(Button menu, Label price, GroupBox gb);
        public abstract void menu10(Button menu, Label price, GroupBox gb);
        public abstract void dbClose(); //닫을 때 
    }
    //커피 카테고리 메뉴 넣기
    class CoffeeMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public CoffeeMenu()
        {
            conn.Open(); //디비 열기
        }
        public override void dbClose()
        {
            conn.Close(); //디비 닫기
        }
        public override void menu1(Button menu, Label price, GroupBox gb) 
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee1'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_americano;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee2'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_americano;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee3'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_cafelatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu4(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee4'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_cafelatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu5(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee5'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_cafemoca;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu6(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee6'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_cafemoca;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu7(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee7'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_cappuccino;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu8(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee8'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_cappuccino;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu9(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee9'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_vanillalatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu10(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'coffee10'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_vanillalatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
    }
    // 음료 카테고리 메뉴 넣기
    class BeverageMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public BeverageMenu()
        {
            conn.Open(); //디비 열기
        }
        public override void dbClose()
        {
            conn.Close(); //디비 닫기
        }
        public override void menu1(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage1'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_chocolate;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage2'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_chocolate;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage3'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_whitechocolate;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu4(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage4'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_chocolate;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu5(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage5'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_greentealatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu6(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage6'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_greentealatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu7(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage7'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.hot_sweetpotatolatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu8(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'beverage8'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.iced_sweetpotatolatte;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu9(Button menu, Label price, GroupBox gb) { }
        public override void menu10(Button menu, Label price, GroupBox gb) { }
    }
    //스무디 카테고리 메뉴 넣기
    class SmoothieMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public SmoothieMenu()
        {
            conn.Open(); //디비 열기
        }
        public override void dbClose()
        {
            conn.Close(); //디비 닫기
        }
        public override void menu1(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'smoothie1'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.chocolatechipsmoothie;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'smoothie2'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.greenteasmoothie;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'smoothie3'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.grapefruitsmoothie;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu4(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'smoothie4'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.mangosmoothie;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu5(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'smoothie5'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.plainyogertsmoothie;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu6(Button menu, Label price, GroupBox gb) { }
        public override void menu7(Button menu, Label price, GroupBox gb) { }
        public override void menu8(Button menu, Label price, GroupBox gb) { }
        public override void menu9(Button menu, Label price, GroupBox gb) { }
        public override void menu10(Button menu, Label price, GroupBox gb) { }
    }
    //쉐이크 카테고리 메뉴 넣기
    class ShakeMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public ShakeMenu()
        {
            conn.Open(); //디비 열기
        }
        public override void dbClose()
        {
            conn.Close(); //디비 닫기
        }
        public override void menu1(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'shake1'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.plainshake;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'shake2'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.chococookieshake;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'shake3'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.berryshake;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu4(Button menu, Label price, GroupBox gb) { }
        public override void menu5(Button menu, Label price, GroupBox gb) { }
        public override void menu6(Button menu, Label price, GroupBox gb) { }
        public override void menu7(Button menu, Label price, GroupBox gb) { }
        public override void menu8(Button menu, Label price, GroupBox gb) { }
        public override void menu9(Button menu, Label price, GroupBox gb) { }
        public override void menu10(Button menu, Label price, GroupBox gb) { }
    }
    //에이드 카테고리 메뉴 넣기
    class AdeMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");
        public AdeMenu()
        {
            conn.Open(); //디비 열기
        }
        public override void dbClose()
        {
            conn.Close(); //디비 닫기
        }
        public override void menu1(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'ade1'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.lemonade;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'ade2'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.greengrapeade;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            try
            {
                string sql = "select * from Menu where addCheck = Yes and menuCategory = 'ade3'";
                OleDbCommand comm = new OleDbCommand(sql, conn);
                OleDbDataReader rd = comm.ExecuteReader(); //select 문
                while (rd.Read())
                {
                    menu.Text = rd["menuName"].ToString();
                    price.Text = rd["menuPrice"].ToString() + "원";
                    menu.BackgroundImage = Properties.Resources.grapefruitade;
                    if (menu.Text != "" && price.Text != "")
                    {
                        menu.Visible = true;
                        price.Visible = true;
                        gb.Visible = true;
                    }
                }
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }
        public override void menu4(Button menu, Label price, GroupBox gb) { }
        public override void menu5(Button menu, Label price, GroupBox gb) { }
        public override void menu6(Button menu, Label price, GroupBox gb) { }
        public override void menu7(Button menu, Label price, GroupBox gb) { }
        public override void menu8(Button menu, Label price, GroupBox gb) { }
        public override void menu9(Button menu, Label price, GroupBox gb) { }
        public override void menu10(Button menu, Label price, GroupBox gb) { }
    }

    //메뉴 삭제
    class deleteMenu : DB
    {
        OleDbConnection conn = new OleDbConnection("Provider = Microsoft.ACE.OLEDB.12.0; Data Source = Cafe_kiosk.accdb");

        public deleteMenu()
        {
            conn.Open();
        }
        public override void dbClose()
        {
            conn.Close();
        }
        public override void menu1(Button menu, Label price, GroupBox gb)
        {
            string dsql = "update Menu set addCheck = No where menuName = '" + menu.Text + "'";
            OleDbCommand comm = new OleDbCommand(dsql, conn);
            menu.Text = "";
            price.Text = "";
            menu.BackgroundImage = null;
            int i = comm.ExecuteNonQuery();
        }
        public override void menu2(Button menu, Label price, GroupBox gb)
        {
            
        }
        public override void menu3(Button menu, Label price, GroupBox gb)
        {
            
        }
        public override void menu4(Button menu, Label price, GroupBox gb) { }
        public override void menu5(Button menu, Label price, GroupBox gb) { }
        public override void menu6(Button menu, Label price, GroupBox gb) { }
        public override void menu7(Button menu, Label price, GroupBox gb) { }
        public override void menu8(Button menu, Label price, GroupBox gb) { }
        public override void menu9(Button menu, Label price, GroupBox gb) { }
        public override void menu10(Button menu, Label price, GroupBox gb) { }
    }
}
