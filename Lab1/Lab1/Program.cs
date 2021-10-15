using System;
namespace Extention
{
    public static class MyExtention
    {
        public static string[] SplitIntoWords(this String str)
        {
            char[] SplitParam = { ' ', '.', ',', '!', '?', ':' };
            return str.Split(SplitParam, System.StringSplitOptions.RemoveEmptyEntries);
        }
    }

}

namespace Lab1
{
        using Extention;
    class Program
    {
        static void Main(string[] args)
        {
            
            Employee employee1 = new Manager("Paladi", "Alexandru", new DateTime(2021, 7, 1, 7, 0, 0), DateTime.Today);
            Employee employee2 = new Architect("Onofrei", "Albert", new DateTime(2021, 2, 1, 7, 0, 0), new DateTime(2021, 10, 20, 7, 0, 0));
        
            Console.WriteLine(employee1.GetFullName() + " IsAlive: " + employee1.IsActive());
            Console.WriteLine(employee2.GetFullName() + " IsAlive: " + employee2.IsActive());

            Console.WriteLine("Salutation: " + employee1.Salutation());
            Console.WriteLine("Salutation: " + employee2.Salutation());

            String TestExtensionText = "Salut! Acesta este un test, si sper sa-l trec.";
            Console.WriteLine("Original text: " + TestExtensionText);
            Console.WriteLine("Words from the text: ");
            foreach (string word in TestExtensionText.SplitIntoWords())
            {
                Console.WriteLine(word);
            }
        }
    }
}
