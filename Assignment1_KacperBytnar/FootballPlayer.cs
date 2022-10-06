using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment1_KacperBytnar
{
    public class FootballPlayer
    {
        private int _id;
        private string _name;
        private int _age;
        private int _shirtNumber;

        public FootballPlayer(int id, string name, int age, int shirtNumber)
        {
            Id = id;
            Name = name;
            Age = age;
            ShirtNumber = shirtNumber;
        }

        public int Id 
        { 
            get => _id; 
            set => _id = value; 
        }
        public string Name { get => _name; set => _name = value; }
        public int Age { get => _age; set => _age = value; }
        public int ShirtNumber { get => _shirtNumber; set => _shirtNumber = value; }

        public void NameValidator()
        {
            if (Name.Length < 2)
            {
                throw new ArgumentException("Name must be at least 2 characters");
            }
        }
        public void AgeValidator()
        {
            if (Age < 1)
            {
                throw new ArgumentOutOfRangeException("Age must be bigger than 2");
            }
        }
        public void ShirtNumberValidator()
        {
            if ((ShirtNumber >= 99) || (ShirtNumber <= 1))
            {
                throw new ArgumentOutOfRangeException("Shirt number must be between 1 and 99");
            }
        }
        public void Validate()
        {
            AgeValidator();
            ShirtNumberValidator();
            NameValidator();
        }
    }
}
