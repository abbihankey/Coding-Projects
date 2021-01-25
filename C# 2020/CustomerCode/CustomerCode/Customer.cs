using System;
using System.Collections.Generic;
using System.Text;

namespace CustomerCode
{
    class Customer
    {
        //def var
        private string customerFullName;
        private string customerBirthdate;
        private int customerMonthNumber;
        private string customerLastName;
        private int customerBirthYear;
        private string customerPurchaseMonth;

        //get sets 
        public string FullName
        {
            get
            {
                return customerFullName;
            }
            set
            {
                customerFullName = value;
            }
        }
        public string Birthdate
        {
            get
            {
                return customerBirthdate;
            }
            set
            {
                customerBirthdate = value;
            }
        }
        public int MonthNumber
        {
            get
            {
                return customerMonthNumber;
            }
            set
            {
                customerMonthNumber = value;
            }
        }
        public string LastName
        {
            get
            {
                //Is there a better place for this?
                GetFirstName(customerFullName);
                return customerLastName;
            }
        }
        public int BirthYear
        {
            get
            {
                GetBirthYear(customerBirthdate);
                return customerBirthYear;
            }
        }
        public string PurchaseMonth
        {
            get
            {
                GetMonth(customerMonthNumber);
                return customerPurchaseMonth;
            }
        }
        //constructors 
        public Customer() { }

        public Customer(string f, string b, int m)
        {
            customerFullName = f;
            Birthdate = b;
            customerMonthNumber = m;
        }
        public void GetFirstName(string f)
        {
            //get last name (split)
            string[] partition = f.Split(' ');
            customerLastName = partition[1];
        }
        public void GetBirthYear(string b)
        {
            string[] partition = b.Split('/');
            customerBirthYear = Convert.ToInt32(partition[2]);
        }
        public void GetMonth(int m)
        {
            //name of mont array
            string[] NameOfMonths =
            { "Jan", "Feb", "Mar",
            "Apr", "May", "Jun",
            "Jul", "Aug", "Sep",
            "Oct", "Nov", "Dec" };
            NameOfMonths[0] = NameOfMonths[0].TrimStart('0');
            customerPurchaseMonth = NameOfMonths[m - 1];
        }
    }
}


