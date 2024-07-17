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

            ////라이플 전투력 출력
            //Rifle rifle = new Rifle();
            //textBox1.Text = "라이플 전투력 : "+ rifle.CombatPoint().ToString()+"\r\n";

            ////나이프 전투력 출력
            //Knife knife = new Knife();
            //textBox1.Text += "나이프 전투력 : "+ knife.CombatPoint().ToString() + "\r\n";

            ////라이플 공격력 변경
            //textBox1.Text += "라이플 공격력 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10)) + "\r\n";
            //textBox1.Text += "라이플 공격력, 공격 속도 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10, 20)) + "\r\n";
            //textBox1.Text += "라이플 공격력, 공격 속도, 장탄 수 변경 후 전투력 : " + rifle.CombatPoint(rifle.setCombatPoint(10, 20, 30)) + "\r\n";

            ////나이프 공격력 변경
            //textBox1.Text += "나이프 공격력 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(10)) + "\r\n";
            //textBox1.Text += "나이프 공격력, 공격 속도 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(10, 20)) + "\r\n";
            //textBox1.Text += "나이프 공격력, 공격 속도, 장탄 수 변경 후 전투력 : " + knife.CombatPoint(knife.setCombatPoint(100, 100, 100)) + "\r\n";

            //Dog dog = new Dog();
            //Dog dog2 = new Dog();
            //Dog dog3 = new Dog();


            //textBox1.Text = "인스턴스의 개수는 " + Dog.Num.ToString()+"개입니다.";

            //int num = 1;
            //textBox1.Text = minusOne(num).ToString();

            //setThree(out num);
            //textBox1.Text = num.ToString();

            //값의 참조1
            int length = 10;
            int[] numbers = new int[length];
            makeInstance(ref numbers);//배열은 기본적으로 포인터임

            textBox1.Text += "ref 사용 : ";
            for (int i = 0; i < length; i++) 
            {
                textBox1.Text += numbers[i].ToString() + " ";
            }
            textBox1.Text += "\r\n";

            //값의 참조2
            int[] number;
            makeInstance(out number, length);

            textBox1.Text +="out 사용 : "+ number.Length.ToString()+"개짜리 배열입니다.";

            //[보너스 실습] 두 수의 값을 더해서 더한 값을 전달하는 void 형 함수 생성
            int a = 1;
            int b = 2;
            int result = 0;
            addNum(a, b, ref result);
            textBox1.Text = "두 수의 합은 "+result.ToString()+"입니다.";



        }

        void makeInstance(ref int[] nums) 
        {
            for (int i = 0; i < nums.Length; i++) 
            {
                nums[i] = i+1;
            }

        }

        void makeInstance( out int []number, int length)
        {
            number = new int[length];
        }

        void addNum (int a, int b, ref int result) 
        {
            result = a + b;
        }

        //int minusOne(int x) => x - 1;

        //void setThree(out int x) => x = 3;
        //ref를 사용하면 x만 바뀌었다가 돌아가는 것이 아니라 실제 num을 바꾸게 됨
        //ref를 사용하면 값만 넘어가는게 아니라 주소도 같이 넘겨서 3을 쓰면 그 주소로 넘어가서 해당 주소에 3을 써버린다.
        //ref는 reference(참조)의 약자
        //out도 같은 기능을 하고 있음
        //ref와 out의 차이점?
        //ref는 값을 먼저 할당해주고 써야하는데 out은 그냥 int num;만 해도 된다
        //대신 out은 메서드에 x에 무조건 할당해야하고 ref는 메서드에 x에 할당 안해도 됨
        //ref는 참조값이다, out 은 할당 되어서 out(빠져나올거다)될거다

        


    }
}
