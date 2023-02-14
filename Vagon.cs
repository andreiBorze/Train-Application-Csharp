using System;
using System.Collections.Generic;
using System.Text;

namespace lab8ex1
{
    public class Vagon
    {
        public int WeightTones { get; set; }
        public int YearBuilt { get; set; }
    
        public Vagon( int weight, int year)
        {
            WeightTones = weight;
            YearBuilt = year;
        }
    
    }
}
