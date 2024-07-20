using System.Runtime.Intrinsics.Arm;

namespace _Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Privilage priv;
            //Enum.TryParse(Console.ReadLine(), out priv);
            Employee[] EmpArr =new Employee[3] 
        {
            new Employee(1, "Mustafa Rashad=>DBA", "High", 50000, Gender.M, Privilege.DBA),
            new Employee(2, "Ahmed Muhamed=>GUEST ", "Meduime", 50000, Gender.F, Privilege.guest),
            new Employee(3, "Amr Muhamed =>security Officer", "Low", 50000, Gender.M, Privilege.guest|Privilege.developer|Privilege.secrtary|Privilege.DBA),
        };

            EmpArr[0].setDate(10, 4, 2002);
            EmpArr[1].setDate(20, 12, 2009);
            EmpArr[2].setDate(25, 7, 2008);
            Console.WriteLine( EmpArr[1].getDate());

        }
    }
}
