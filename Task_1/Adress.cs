using System;

namespace Task_1
{
    public class Adress
    {
        private string _index;
        private string _country;
        private string _city;
        private string _street;
        private string _house;
        private string _apartment;
        
        public string Index
        {
            get { return _index; }
            set { _index = value; }
        }
        public string Country
        {
            get { return _country; }
            set { _country = value; }
        }
        public string City
        {
            get { return _city; }
            set { _city = value; }
        }
        public string Street
        {
            get { return _street; }
            set { _street = value; }
        }
        public string House
        {
            get { return _house; }
            set { _house = value; }
        }
        public string Apartment
        {
            get { return _apartment; }
            set { _apartment = value; }
        }
    }
}