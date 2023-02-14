using System;

namespace lab8ex1
{
    class Program
    {
        static void Main(string[] args)
        {
            Train myTrain = new Train("My Train");


            myTrain.AddVagon(new VagonForMarfa(2000, 2015, "coal", 50));
            myTrain.AddVagon(new VagonForMarfa(2500, 2018, "wood", 40));
            myTrain.AddVagon(new VagonForMarfa(2000, 2015, "wood", 50));

            myTrain.AddVagon(new VagonForPeople(3000, 2020, 50));
            myTrain.AddVagon(new VagonForPeople(3000, 2020, 22));
            myTrain.AddVagon(new VagonForPeopleClass1(3500, 2021, 30));
            myTrain.AddVagon(new VagonForPeopleClass1(3500, 2021, 11));


            Console.WriteLine("Summary of cargo on the train:");
            var summary = myTrain.SumarMarfa();
            foreach (var item in summary)
            {
                Console.WriteLine("{0}: {1} tons", item.Item1, item.Item2);
            }

            Console.WriteLine("Total number of seats on the train: {0}", myTrain.NumarDeLocuri());

            myTrain.LeaveFromStation();

            myTrain.StopInStation();
        }
    }
}
