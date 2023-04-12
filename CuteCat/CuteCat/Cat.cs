using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CuteCat
{
    public class Cat // internal : namespace 내에서만 틀래스 사용 가능
    {   // private : 해당 클래스 내부에서만 변수 사용 가능
        // public : 해당 클래스밖에서도 변수 사용 가능
        
        public string Name; 
        public int Age;

        private int Happiness = 50;

        public Cat(string name, int age) // 생성자
        {
            this.Name = name;
            this.Age = age;
        }

        public void GetBoard()
        {
            Happiness = Happiness - 10;

            if(Happiness < 0)
            {
                Happiness = 0;
            }
        }

        public void Play()
        {
            Happiness = Happiness + 10;

            if(Happiness > 100) 
            {
                Happiness = 100;
            }
        }

        public void Eat()
        {
            Happiness = Happiness + 20;

            if (Happiness > 100)
            {
                Happiness = 100;
            }
        }

        public string Express()
        {
            string message = "";

            if (Happiness >= 80)
            {
                message = "I'm very happy.";
            }
            else if (Happiness >= 60)
            {
                message = "I'm happy.";
            }
            else if (Happiness >= 40)
            {
                message = "I'm so so.";
            }
            else if (Happiness >= 20)
            {
                message = "I'm gloomy.";
            }
            else
            {
                message = "I'm sad.";
            }

            return this.Name + ": " + message;
        }
    }
}
