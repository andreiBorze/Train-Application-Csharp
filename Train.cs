using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace lab8ex1
{
    public class Train
    {
        private List<Vagon> _vagoane = new List<Vagon>();
        private Locomotive _locomotive;
        private string _name;

        public Train(string nume)
        {
            _name = nume;
            _locomotive = new Locomotive();
        }


        public void AddVagon( Vagon vagon)
        {
            _vagoane.Add(vagon);
        }

        public void LeaveFromStation()
        {
            foreach(var v in _vagoane)
            {
                if( v is VagonForPeopleClass1 vagonForPeople1) // Daca ii vagon pt persoane -> include si cele de clasa 1
                {
                    vagonForPeople1.CloseDoors();
                    vagonForPeople1.StartAirConditioning();
                }
                else if (v is VagonForPeople vagonForPeople)
                {
                    vagonForPeople.CloseDoors();
                }
            }

            _locomotive.Porneste();

            Console.WriteLine("The train is leaving the station!");
        }

        public void StopInStation()
        {
            foreach(var v in _vagoane)
            {
                if(v is VagonForPeopleClass1 vagonForPeople1)
                {
                   vagonForPeople1.StopAirConditioning();
                   vagonForPeople1.OpenDoors();
                }
                else if(v is VagonForPeople vagonForPeople)
                {
                    vagonForPeople.OpenDoors();
                }
            }

            Console.WriteLine("The train has stopped!");
        }

        public int NumarDeLocuri()
        {
            int number = 0;

            foreach(var v in _vagoane)
            {
                if (v is VagonForPeopleClass1 vagonForPeople1)
                {
                    number += vagonForPeople1.NumberOfSeates;
                }
                else if (v is VagonForPeople vagonForPeople)
                {
                    number += vagonForPeople.NumberOfSeates;
                }
            }
            return number;
        }

        public List<(string, int)> SumarMarfa()
        {
            List<(string, int)> sumarMarfa = new List<(string, int)>();

            foreach(var v in _vagoane)
            {
                if(v is VagonForMarfa vagonForMarfa)
                {
                    var tipMarfa = vagonForMarfa.TypeOfGoods;

                    var existing = sumarMarfa.FirstOrDefault(t => t.Item1 == tipMarfa);

                    if(existing != default)
                    {
                        var index = sumarMarfa.IndexOf(existing);
                        sumarMarfa[index] = (existing.Item1, existing.Item2 + vagonForMarfa.CapacityInTones);
                    }
                    else
                    {
                        var tuple = (tipMarfa, vagonForMarfa.CapacityInTones);
                        sumarMarfa.Add(tuple);
                    }
                }
            }
            return sumarMarfa;
        }

    }
}
