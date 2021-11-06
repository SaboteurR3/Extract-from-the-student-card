using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_7
{
    class Employee
    {
        private string firstName;
        private string lastName;
        private int id;
        private int birthYear;
        private int age;
        private int salary;
        private byte rating;

        public string FirstName
        {
            get { return firstName; }
            set { firstName = value; }
        }
        public string LastName
        {
            get { return lastName; }
            set { lastName = value; }
        }
        public int Id
        {
            get { return id; }
            set { id = value; }
        }
        public int BirthYear
        {
            get { return birthYear; }
            set { birthYear = value; }
        }
        public int Salary
        {
            get { return salary; }
            set { salary = value; }
        }
        public byte Rating
        {
            get { return rating; }
            set { rating = value; }
        }
        public int Age
        {
            get { return age; }
            set { age = value; }
        }

        public override string ToString()
        {
            return "First name : " + firstName + ", last name: " + lastName + ", id: " + id
                + ", birthYear: " + birthYear + ", age: " + age + ", salary: " + salary + ", rating: " + rating;
        }
    }
}