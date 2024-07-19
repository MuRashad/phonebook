using Animal_pjt.AnimalClass;
namespace Animal_pjt
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //prdicted=>call ctor parmless and print basic toString() 
            //Animal Dog=new Animal();
            //--------------------------
            //parametrized constructor and print basic toString()  
            //initialization but not encapsulation
            //Is Dog object or class ?
            //0=> is all animal is dog ? is dog has something differnt ?
            //>> Dog is animal but has some characteristic additional
            //if so i need inheritance that existe in class. 
            //Animal Dog = new Animal("Dog","German","black","tail",4);
            //Console.WriteLine(Dog);
            //Dog.Tail = "Dense.!";
            //Console.WriteLine(Dog);
            //prdicted =>print his parent ctor 
            //         =>child constructor
            //         =>to string for children if je doesnot have he will inheite it from parent ;
            Dog doberman = new Dog("America");
            Console.WriteLine(doberman);
            Console.WriteLine("-----------------------------\n");
            Cat sherazi = new Cat("Egypt");
            Console.WriteLine(sherazi); 
          
        }
    }
}
