using System;
using System.Collections.Generic;
using System.Text;

namespace lab8ex1
{
    public class VagonForPeopleClass1 : VagonForPeople
    {
        bool AirConditioningOpen { get; set; }
        public VagonForPeopleClass1(int weight, int year, int nrSeates):base(weight,year,nrSeates)
        {
            AirConditioningOpen = false;
        }

        public void StartAirConditioning()
        {
            AirConditioningOpen = true;
            Console.WriteLine("Air conditioning has been started.");
        }

        public void StopAirConditioning()
        {
            AirConditioningOpen = false;
            Console.WriteLine("Air conditioning has been stopped.");
        }
    }
}
