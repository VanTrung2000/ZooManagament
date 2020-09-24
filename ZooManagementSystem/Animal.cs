using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Text;

namespace ZooManagementSystem
{
  public  abstract class Animal
    {
            public string Name { get; set; }
            public int Age { get; set; }
            public string Description { get; set; }
            public virtual void Viewinfo()
            {
                Console.WriteLine("Ten dong vat : {0} , Tuoi : {1} , Mo ta : {2}", Name, Age, Description);
            }
            public abstract void speak();

            public Animal(string name, int age, string description)
            {
                Name = name;
                Age = age;
                Description = description;
            }

            public Animal()
            {
            }
        }
    }
