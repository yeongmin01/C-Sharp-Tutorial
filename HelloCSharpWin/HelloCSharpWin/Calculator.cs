using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace HelloCSharpWin
{
    public enum Operators
    {
        Add, Sub, Multi, Div
    }

    public partial class Calculator : Form
    {
        public int Result = 0;
        public bool isNewNum = true;
        public Operators Opt = Operators.Add;

        public Calculator()
        {
            InitializeComponent();
        }

        public int Add(int number1, int number2) 
        {
            int sum = number1 + number2;
            return sum;
        }

        public float Add(float number1, float number2)
        {
            float sum = number1 + number2;
            return sum;
        }

        public int Sub(int number1, int number2)
        {
            int sub = number1 - number2;
            return sub;
        }

        public void SetNum(string num)
        {
            if (isNewNum)
            {
                NumScreen.Text = num;
                isNewNum = false;
            }

            else if (NumScreen.Text == "0")
            {
                NumScreen.Text = num;
            }

            else
            {
                NumScreen.Text = NumScreen.Text + num;
            }
        }

        private void NumButton1_Click(object sender, EventArgs e) // 숫자 패드 : 같은 핸들러 공유
        {
            Button numButton = (Button)sender;
            SetNum(numButton.Text);
        }

        private void NumPlus_Click(object sender, EventArgs e) // 연산자 : 같은 핸들러 공유
        {
            if (isNewNum == false) // 연산자 이후 숫자가 눌러진 경우에만 계산 수행
            {
                int num = int.Parse(NumScreen.Text);
                if (Opt == Operators.Add)
                {
                    Result = Add(Result, num);
                }
                else if (Opt == Operators.Sub)
                {
                    Result = Sub(Result, num);
                }

                NumScreen.Text = Result.ToString();
                isNewNum = true;
            }

            Button optButton = (Button)sender;

            if(optButton.Text == "+") 
            {
                Opt = Operators.Add;
            }
            else if(optButton.Text == "-")
            {
                Opt = Operators.Sub;
            }
        }

        private void NumClear_Click(object sender, EventArgs e)
        {
            Result = 0;
            isNewNum = true;
            Opt = Operators.Add;

            NumScreen.Text = "0";
        }
    }
}
 