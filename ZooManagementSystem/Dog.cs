using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagementSystem
{
    public class Dog : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Gau Gau");
        }
        public Dog() : base()
        {

        }
        public override void Viewinfo()
        {
            base.Viewinfo();
        }
        public Dog(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}