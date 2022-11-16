using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lecture_13_FIlters_ListVIew
{
    public class Car
    {
        string _make;
        string _model;
        int _year;
        bool _hasSunroof;
        bool _hasSpoiler;

        public Car(string make, string model, int year)
        {
            _make = make;
            _model = model;
            _year = year;
        }

        public string Make { get => _make; set => _make = value; }
        public string Model { get => _model; set => _model = value; }
        public int Year { get => _year; set => _year = value; }
        public bool HasSunroof { get => _hasSunroof; set => _hasSunroof = value; }
        public bool HasSpoiler { get => _hasSpoiler; set => _hasSpoiler = value; }
    }
}
