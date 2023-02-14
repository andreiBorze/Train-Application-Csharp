using System;
using System;
using System.Collections.Generic;
using System.Text;

namespace lab8ex1
{
    public class VagonForMarfa: Vagon
    {
        public string TypeOfGoods { get; set; }
        public int CapacityInTones { get; set; }

        public VagonForMarfa(int weight, int year, string type, int tones): base(weight,year)
        {
            TypeOfGoods = type;
            CapacityInTones = tones;
        }
    }
}
