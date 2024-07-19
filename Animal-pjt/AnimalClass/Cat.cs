using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_pjt.AnimalClass
{
    public  class Cat :Animal
    {
        private string _type;
        public string _Type

        {
            get { return _type; }
            set { _type = value; }
        }


        //i can make ctor in the children if the parent have parmatrless costructor 
        //if doesnot have parameterless constructor i have to pass to base class constructor parameters 
        //here i make initialization to class from here parent to DOfg but not setting values or getting it 
        public Cat(string type) : base("sherazi", "Egypt", "white and black", "has tail", 4)
        {
            _type = type;
            Console.WriteLine($"this is parametrize consrtructor for childeren {this._Name},...!");
        }
        public override string ToString()
        {
            return $"the type of cat is {_type}";
        }
    }
}
