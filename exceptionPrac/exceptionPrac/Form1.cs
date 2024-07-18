using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace exceptionPrac
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //string content = File.ReadAllText(@"C:\KJH\CsharpDeepening\exceptionPrac\test.txt");//@ : 여기에 있는 \는 탈출문자가 아니다를 의미

            //string content = File.ReadAllText("test.txt");
            string content;
            string[] strings;
            getArray(out content, out strings);
            splitNumString(strings);
            //textBox1.Text = content;

            string a = "\""; //\뒤에 있는 "는 실제 문자 "임을 나타냄 \:탈출문자
        }

        void getArray(out string content, out string[] strings) // 파일 경로를 입력받으면 결과를 배열로 반환하는 메소드
        {
            content = null;
            strings = null;
            try
            {
               
                List<string> lines = new List<string>();
                StreamReader sr = new StreamReader("test.txt");
                content = sr.ReadLine();
                lines.Add(content);
                while (content != null)
                {
                    Console.WriteLine(content);
                    content = sr.ReadLine();
                    lines.Add(content);
                }
                strings = lines.ToArray();
            }
            catch (Exception e)
            {
                Console.WriteLine("Exception: " + e.Message);
            }
            finally
            {
                Console.WriteLine("파일 경로부분 파이널");
            }

            
            
        }

        void splitNumString(string[] strings)
        {
            string result = null;
            for (int i = 0; i < strings.Length; i++)
            {
                if (strings[i] != null)
                {
                    try
                    {
                        int a = int.Parse(strings[i]); // 숫자 파싱
                        result += "숫자 : " + a.ToString() + "\r\n";
                    }
                    catch (FormatException) // 숫자로 파싱할 수 없는 경우
                    {
                        result += "문자 : " + strings[i] + "\r\n";
                    }
                    catch (Exception ex) // 그 외의 예외 처리
                    {
                        result += "오류 : " + ex.Message + "\r\n";
                    }
                }
            }

            Console.WriteLine("배열의 길이 : " + strings.Length);
            textBox1.Text = result;
        }

    }
}
