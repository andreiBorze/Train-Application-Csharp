using System;
using System.Collections.Generic;
using System.Text;

namespace lab8ex1
{
    public class VagonForPeople: Vagon
    {
        public int NumberOfSeates { get; set; }
        public VagonForPeople(int weight, int year, int nrSeates): base(weight, year)
        {
            NumberOfSeates = nrSeates;
        }

        public void CloseDoors()
        {
            Console.WriteLine("The Doors are closing...");
            Console.WriteLine("The Doors are Closed!");
        }

        public void OpenDoors()
        {
            Console.WriteLine("The Doors are opening...");
            Console.WriteLine("The Doors are open!");
        }
    }
}
