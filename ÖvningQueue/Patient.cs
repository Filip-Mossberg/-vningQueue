using System;
using System.Collections.Generic;
using System.Text;

namespace ÖvningQueue
{
    internal class Patient : Person
    {
        public string CheckInTime { get; set; }
        public bool HasCovid { get; set; }
        public bool IsRealeased { get; set; }
        public Patient(string _Name, int _Age, char _Gender, int _Id, string _CheckInTime) : base(_Name, _Age, _Gender, _Id)
        {
            CheckInTime = _CheckInTime;
        }
        public bool IsVaccinated<T>(T obj, T obj2)
        {
            return obj.Equals(obj2);
        }
    }
}
