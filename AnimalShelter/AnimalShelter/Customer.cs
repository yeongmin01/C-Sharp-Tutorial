using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AnimalShelter
{
    public class Customer
    {
        // Field 필드 : 클래스에서 생성된 변수
        // 매서드 : 클래스에서 생성된 함수
        public string FirstName; 
        public string LastName;
        private DateTime _Birthday;
        public string Address;
        public string Description;
        private bool _IsQualified;

        public Customer(string firstName, string lastName, DateTime birthday) 
        { 
            this.FirstName = firstName;
            this.LastName = lastName;
            this._Birthday = birthday;

            this._IsQualified = Age >= 18;
        }

        public DateTime Birthday
        {
            get { return _Birthday; }
            set 
            { 
                _Birthday = value;
                _IsQualified = Age >= 18;
            }
        }

        /*
        public int GetAge()
        {
            return _Age;
        }

        public void SetAge(int age)
        {
            _Age = age;
            _IsQualified = age >= 18;
        }
        */

        /*
        <속성>
        get을 통해 값을 return 하며.
        set을 통해 매개변수가 들어오게 되며 그 매개변수는 value라는 이름의 int(선언한 타입을 따른다)이다. 
        */
        
        public int Age 
        {
            get { return DateTime.Now.Year - _Birthday.Year; }
        }

        /*
        public bool GetIsQualified() 
        {
            return _IsQualified;        
        }
        */

        public bool IsQualified
        {
            get { return _IsQualified; }
        }

        public string FullName
        {
            get { return FirstName + " " + LastName; }
        }

        /*
        public string GetFullName()
        {
            return FirstName + " "  + LastName;
        }
        */
    }
}
