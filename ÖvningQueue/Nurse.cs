using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueue
{
    internal class Nurse : Person
    {
        public int Epxerience { get; set; }
        public Nurse(string _Name, int _Age, char _Gender, int _Id, int _Experience) : base(_Name, _Age, _Gender, _Id)
        {
            this.Epxerience = _Experience;
        }

        public void TempCheck()
        {

        }
    }
}
