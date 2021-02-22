using System;

namespace ZooLibrary
{
    class Animal
        {
            private string _name;

            public int Legs { get; set; }
            public DateTime DateOfBirth { get; set; }

            public string Name
            {
                get => _name;
                set
                {
                    if (value.Length <= 0)
                        _name = " ";
                    else
                        _name = value;
                }
            }

            public int Age => DateTime.Today.Year - DateOfBirth.Year;

            public Animal(int legs, DateTime dateOfBirth, string name)
            {
                Legs = legs;
                DateOfBirth = dateOfBirth;
                Name = name;
            }

            public Animal()
            {
                Legs = 7;
                DateOfBirth = new DateTime(2000, 5, 6, 4, 0, 0);
                Name = "Mary";
            }

            public override string ToString()
            {
                //return ("Name: " + Name + " Age: " + Age.ToString());
                return $"Name: {Name} Age: {Age}";
            }


    }

}
