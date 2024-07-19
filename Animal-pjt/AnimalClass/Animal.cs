using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
//in namespace i can write(Enum , struct , class , interface)
namespace Animal_pjt.AnimalClass
{
  //there is no start point 
  //when i add class i add refernce to this class pont to null 
  //call parameter less constructor i existed  
    public class Animal
    { //i have no logic as well i have used Automatic property =>Clr make a hide property setter and getter
        private string _name;
        private string _description;
        private string _hair;
        private string _tail { set; get; }
        private int _legs;
        public Animal(string name , string desc , string hair , string tail, int legs)
        {
            _name=name;
            _description=desc;
            _hair=hair;
            _tail=tail;
            _legs=legs;
            Console.WriteLine("this parameterize constructor for Animal class..,!");
        }


        public void canEat() { Console.WriteLine("Animal can eat,...!"); }
        public void canSleep () { Console.WriteLine("Animal can sleep,..!"); }
        public void canRun () { Console.WriteLine("Animal can run,...!"); }
        public override string ToString()
        {
            return $"This anmila name is {_name} ,{_description},{_hair} ,{_tail} and {_legs}";
        }

        public string _Name
        {
            get { return _name; }
            set { _name = value; }
        }    
      
        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }     
        public string Tail
        {
            get { return _tail; }
            set { _tail = value; }
        }    
        public string _Hair
        {
            get { return _hair; }
            set { _hair = value; }
        }
        public int _Leg
        {
            get { return _legs; }
            set { _legs = value; }
        }
    }
}
