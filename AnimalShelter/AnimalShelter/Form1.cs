using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections;

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public List<Customer> Customers = new List<Customer>();

        public Form1()
        {
            InitializeComponent();
        }

        private void CreatCustomer_Click(object sender, EventArgs e)
        {
            //DateTime birthday = new DateTime(2000, 1, 1);
            Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            //Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            cus.Address = CusNewAddress.Text;
            cus.Description = CusNewDescription.Text;

            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);

            Customers.Add(cus);

            CusNewFirstName.Text = "";
            CusNewLastName.Text = "";
            CusNewBirthday.Text = "";
            CusNewAddress.Text = "";
            CusNewDescription.Text = "";
        }

        public void ShowDetails(Customer cus)
        {
            //CusFullName.Text = cus.GetFullName();
            CusFullName.Text = cus.FullName;
            //CusAge.Text = cus.GetAge().ToString();
            CusAge.Text = cus.Age.ToString();
            // 속성은 필드를 사용하는것 처럼 사용 가능.
            // 필드는 값을 선언하기만 하지만
            // 속성은 set에서 함수처럼 코딩을 할 수 있으므로 값에 대한 별도의 처리가 가능하다. 
            CusAddress.Text = cus.Address;
            CusDescription.Text = cus.Description;
            CusIsQualified.Text = cus.IsQualified.ToString();

            CusPetInfo.Text = "";
            foreach (Pet pet in cus.MyPets)
            {

                CusPetInfo.Text += pet.Name + ":" + pet.MakeSound();

                if (pet is Cat)
                {                
                    CusPetInfo.Text += "," + (pet as Cat).Scratch();
                }
                else if (pet is Dog)
                {
                    CusPetInfo.Text += "," + (pet as Dog).Bite();
                }

                CusPetInfo.Text+= Environment.NewLine;
            
            }

            /*
            foreach(Pet cat in cus.MyCats)
            {
                CusPetInfo.Text += cat.Name + ":" + cat.MakeSound() + Environment.NewLine;
            }

            foreach(Dog dog in cus.MyDogs)
            {
                CusPetInfo.Text += dog.Name + ":" + dog.MakeSound() + Environment.NewLine;
            }
            */
            bool test = cus.IsQualified;
        }

        private void CusList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string firstName = CusList.Rows[e.RowIndex].Cells[0].Value.ToString();

            foreach (Customer cus in Customers)
            {
                if (cus.FirstName == firstName)
                {
                    ShowDetails(cus);
                    break;
                }
            }

            CusDetailPanel.Show();
            CusNewPanel.Hide();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CusListPanel.Dock = DockStyle.Fill;
            CusDetailPanel.Dock = DockStyle.Right;
            CusNewPanel.Dock = DockStyle.Right;

            Customer cus = new Customer("Ian", "Na", new DateTime(2000, 1, 2));
            Cat cat = new Cat(1, "Lucas", "White", "Male");
            cus.Adopt(cat);
            Cat cat2 = new Cat(3, "Ruby", "Brown", "Female");
            cus.Adopt(cat2);


            Dog dog = new Dog(2, "Happy", "Black", "Male",DogBreed.Jindo);
            cus.Adopt(dog);

            Customers.Add(cus);
            CusList.Rows.Add(cus.FirstName, cus.Age, cus.IsQualified);

        }

        private void ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CusNewPanel.Show();
            CusDetailPanel.Hide();

            
        }
    }
}
