using System;
using System.Collections.Generic;
using System.Text;

namespace ZooManagementSystem
{
  public  class Tiger : Animal
    {
        public override void speak()
        {
            Console.WriteLine("Gu gu");
        }
        public Tiger() : base()
        {

        }
        public override void Viewinfo()
        {
            base.Viewinfo();
        }
        public Tiger(string Name, int Age, string Description) : base(Name, Age, Description)
        {
        }
    }
}