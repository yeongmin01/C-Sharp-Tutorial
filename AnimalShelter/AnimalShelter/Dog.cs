using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalShelter
{
    public enum DogBreed { Mixed, Bulldog, Jindo, Yorkshire}

    public class Dog :Pet
    {
        public DogBreed Breed;
        /*
        public int PetId;
        public string Name;
        public string Color;
        public string Gender;
        public string Description;
        
        public Dog(int petId, string name, string color, string gender, DogBreed breed)
        {   
            this.PetId = petId;
            this.Color = color;
            this.Gender = gender;
            this.Name = name;
            this.Breed = breed;
        }

        public string MakeSound()
        {
            return "멍멍";
        }
        */
        public Dog(int petId, string name, string color, string gender, DogBreed breed) : base(petId, name, color, gender)
        {
            this.Breed = breed;
        }

        public override string MakeSound()
        {
            return "멍멍";
        }

        public string Bite()
        {
            return "물어뜯기";
        }
    }
}
