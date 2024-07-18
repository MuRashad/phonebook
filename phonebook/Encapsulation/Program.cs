namespace phonebook.Encapsulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            phonebook Note = new phonebook(3);
            //reference note point to phonebook
            //phonebook is a struct has size = 3, number=0, names=>null
            Note.addPerson(PName:"Mustaf", index:0 ,PNum:123);
            Note.addPerson(PName: "Abdo", index: 1, PNum: 564);
            Note.addPerson(PName: "Ahmed", index: 2, PNum: 879);
            //Note.print();
            //int personNumber = Note.GetNumber("shimaaa");
            //Console.WriteLine(personNumber == -1 ? "not found" : personNumber);
            //set anf get using indexer property
            //Note["Mustafa"]=564;
            //Console.WriteLine(Note["Mustafa"]);
            //0string name = "Mustafa";//works as indexer =>right? yes alright 
            //Console.WriteLine(name[0]);
       
            for(int i = 0; i < Note.Size; i++)
            {
                Console.WriteLine(Note[i]);
            }
          
           
        
        }
    }
}
