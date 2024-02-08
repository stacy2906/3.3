using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace ConsoleApp4
{
    internal class ExerciseNotebook: Notebook
    {
        public string CoverMaterial;

        public ExerciseNotebook(string name, int number, string coverMaterial) : base(name, number)
        {
            CoverMaterial = coverMaterial;
        }

        public override void PrintInfo()
        {
            Console.WriteLine($"Exercise Notebook: {Name}, Number of Pages: {Number}, Cover Material: {CoverMaterial}");
        }

        public override int GetCost()
        {
            return base.GetCost() + 50; // adding 50 rubles for the cover
        }
    }
}
