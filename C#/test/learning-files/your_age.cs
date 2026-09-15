namespace MyFirrsyProgram
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("What year is it?");
            int year = int.Parse(Console.ReadLine());
            Console.WriteLine("What year were you born in?");
            int age = int.Parse(Console.ReadLine());
            int math = year - age;
            Console.WriteLine("You are " + math + " years old.");  
        }
    }
}
