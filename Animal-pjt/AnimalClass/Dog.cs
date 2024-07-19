using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_pjt.AnimalClass
{
    //i maake inheritance 
    public class Dog :Animal 
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
        public Dog(string type):base("Black German","Germany","blac and yellow" ,"has tail" ,4)
        {
            _type = type;
            Console.WriteLine($"this is parametrize consrtructor for childeren {this._Name},...!");
        }
        public new string ToString()
        {
            return $"the type of Dog is {_type}";
        }
    } 
}
