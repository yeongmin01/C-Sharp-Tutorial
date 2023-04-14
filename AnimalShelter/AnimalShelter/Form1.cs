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

namespace AnimalShelter
{
    public partial class Form1 : Form
    {
        public Customer[] CustomerArray = new Customer[10];
        public int CustomerArrayIndex = 0;

        public Form1()
        {
            InitializeComponent();
        }

        private void CreatCustomer_Click(object sender, EventArgs e)
        {
            //DateTime birthday = new DateTime(2000, 1, 1);
            CustomerArray[CustomerArrayIndex] = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            //Customer cus = new Customer(CusNewFirstName.Text, CusNewLastName.Text, DateTime.Parse(CusNewBirthday.Text));
            CustomerArray[CustomerArrayIndex].Address = CusNewAddress.Text;
            CustomerArray[CustomerArrayIndex].Description = CusNewDescription.Text;

            CustomerList.Items.Add(CustomerArray[CustomerArrayIndex].FirstName);

            CustomerArrayIndex++;
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

            bool test = cus.IsQualified;
        }

        private void CustomerList_Click(object sender, EventArgs e)
        {
            string firstName = CustomerList.SelectedItem.ToString();

            for (int index =0; index < CustomerArrayIndex; index++)
            {
                if (CustomerArray[index].FirstName == firstName)
                {
                    ShowDetails(CustomerArray[index]);
                    break;
                }
            }
        }
    }
}
