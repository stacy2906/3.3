using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Создание объекта базового класса
            Notebook notebook = new Notebook("Math", 100);
            notebook.PrintInfo();
            Console.WriteLine($"Cost: {notebook.GetCost()} rub.");

            //Создание объекта производного класса
            ExerciseNotebook exerciseNotebook = new ExerciseNotebook("English", 120, "Soft");
            exerciseNotebook.PrintInfo();
            Console.WriteLine($"Cost: {exerciseNotebook.GetCost()} rub.");
            Console.ReadKey();
        }
    }
}
