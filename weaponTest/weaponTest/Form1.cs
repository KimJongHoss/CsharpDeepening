using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace weaponTest
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //라이플 전투력 출력
            Rifle rifle = new Rifle();
            textBox1.Text = "라이플 전투력 : "+ rifle.CombatPoint().ToString()+"\r\n";

            //나이프 전투력 출력
            Knife knife = new Knife();
            textBox1.Text += "나이프 전투력 : "+ knife.CombatPoint().ToString() + "\r\n";

            //라이플 공격력 변경
            textBox1.Text += "라이플 공격력 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10)) + "\r\n";
            textBox1.Text += "라이플 공격력, 공격 속도 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10, 20)) + "\r\n";
            textBox1.Text += "라이플 공격력, 공격 속도, 장탄 수 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10, 20, 30)) + "\r\n";

            //나이프 공격력 변경
            textBox1.Text += "나이프 공격력 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(10)) + "\r\n";
            textBox1.Text += "나이프 공격력, 공격 속도 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(10, 20)) + "\r\n";
            textBox1.Text += "나이프 공격력, 공격 속도, 장탄 수 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(100, 100, 100)) + "\r\n";

        }

        

       
    }
}
