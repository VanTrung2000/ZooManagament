using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagementSystem
{
   public class Cat:Animal
    {
        public override void speak()
        {
            Console.WriteLine("Meo meo");
        }
        public Cat() : base()
        {

        }
        public override void Viewinfo()
        {
            base.Viewinfo();
        }
        public Cat(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}