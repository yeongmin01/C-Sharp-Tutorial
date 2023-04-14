using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Cat : Pet // A : B  : A는 B 클래스를 상속 받음
    {
        /*
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        */

        /*
        public Cat(int petId, string name, string color, string gender) 
        {
            this.PetId = petId;
            this.Color = color;
            this.Gender = gender;
            this.Name = name;
        }
        */

        /*
        public string MakeSound()
        {
            return "야옹";
        }
        */

        public Cat(int petId, string name, string color, string gender) : base(petId, name, color, gender)
        {
        }

        public override string MakeSound()
        {
            return "야옹";
        }

        public string Scratch()
        {
            return "할퀴기";
        }
    }
}
