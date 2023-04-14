using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public class Pet
    {
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;

        public Pet(int petId, string name, string color, string gender)
        {
            this.PetId = petId;
            this.Color = color;
            this.Gender = gender;
            this.Name = name;
        }

        public virtual string MakeSound()
        {// virtual : 가상 메서드 - child class에 같은 이름을 가진 함수를 만들면 그것이 대신 불러와 진다.
            return "";
        }
    }
}
